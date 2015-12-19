using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using AudioExtractor.Helpers;
using AudioExtractor.Structures;
using AudioExtractor.Properties;

namespace AudioExtractor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(VariableHelper.ConfigFileName))
            {
                ConfigHelper.CreateConfiguration(VariableHelper.ConfigFileName);
            }

            ConfigHelper.LoadConfiguration(VariableHelper.ConfigFileName);

            if (!Directory.Exists(Path.GetFullPath(VariableHelper.AudioDecodersLocation)))
            {
                Directory.CreateDirectory(Path.GetFullPath(VariableHelper.AudioDecodersLocation));
            }

            mainImageList.Images.Add("Music", Resources.Music);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // Fix the initial state of the horizontal scroll bar in mainListView

            this.Size = new Size(this.Size.Width, this.Size.Height - 1);
            this.Size = new Size(this.Size.Width, this.Size.Height + 1);

            if (VariableHelper.AudioDecoders.Count == 0)
            {
                addFileToolStripButton.Enabled = false;
                addFolderToolStripButton.Enabled = false;

                FormHelper.ShowNoDecoderWarning();
            }
        }

        private void mainToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == addFileToolStripButton)
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Select audio files";
                    dlg.Filter = FormHelper.BuildFilterString();
                    dlg.Multiselect = true;

                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        FormHelper.AddAudioFilesToListView(mainListView, dlg.FileNames);

                        runToolStripButton.Enabled = (mainListView.Items.Count > 0);
                    }
                }
            }
            else if (e.ClickedItem == addFolderToolStripButton)
            {
                using (FolderBrowserDialog dlg = new FolderBrowserDialog())
                {
                    dlg.Description = "Select a folder contains audio files";
                    dlg.ShowNewFolderButton = false;

                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        FormHelper.AddAudioFilesToListView(mainListView, FileHelper.GetAudioFilesFromFolder(dlg.SelectedPath));

                        runToolStripButton.Enabled = (mainListView.Items.Count > 0);
                    }
                }
            }
            else if (e.ClickedItem == removeToolStripButton)
            {
                while (mainListView.SelectedItems.Count > 0)
                {
                    mainListView.Items.Remove(mainListView.SelectedItems[mainListView.SelectedItems.Count - 1]);
                }

                runToolStripButton.Enabled = (mainListView.Items.Count > 0);
            }
            else if (e.ClickedItem == runToolStripButton)
            {
                if (VariableHelper.DeleteSourceFiles)
                {
                    DialogResult promptResult = MessageBox.Show(
                        String.Format("The source files will be deleted from disk after decoding.{0}{0}Are you sure you want to proceed?", Environment.NewLine),
                        Application.ProductName,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2);

                    if (promptResult == DialogResult.No)
                    {
                        return;
                    }
                }

                List<ListViewItem> deletedFileItems = new List<ListViewItem>();

                foreach (ListViewItem item in mainListView.Items)
                {
                    if (!File.Exists(FormHelper.GetAudioFileNameFromListViewItem(item)))
                    {
                        deletedFileItems.Add(item);
                    }
                }

                if (deletedFileItems.Count > 0)
                {
                    DialogResult promptResult = MessageBox.Show(
                        String.Format("One or more files may not exist anymore since they have been added.{0}They will be removed from the list if proceed.{0}{0}Are you sure you want to proceed?", Environment.NewLine),
                        Application.ProductName,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (promptResult == DialogResult.No)
                    {
                        return;
                    }
                }

                foreach (ListViewItem item in deletedFileItems)
                {
                    mainListView.Items.Remove(item);
                }

                deletedFileItems.Clear();

                using (ProgressForm progressForm = new ProgressForm(mainListView))
                {
                    progressForm.ShowDialog(this);
                }
            }
            else if (e.ClickedItem == configToolStripButton)
            {
                using (ConfigForm configForm = new ConfigForm())
                {
                    configForm.ShowDialog(this);
                }

                addFileToolStripButton.Enabled = (VariableHelper.AudioDecoders.Count > 0);
                addFolderToolStripButton.Enabled = (VariableHelper.AudioDecoders.Count > 0);
            }
            else if (e.ClickedItem == aboutToolStripButton)
            {
                using (AboutBox aboutBox = new AboutBox())
                {
                    aboutBox.ShowDialog(this);
                }
            }
        }

        private void mainListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void mainListView_DragDrop(object sender, DragEventArgs e)
        {
            String[] fileNames = e.Data.GetData(DataFormats.FileDrop) as String[];

            if (fileNames != null && fileNames.Length > 0)
            {
                foreach (String name in fileNames)
                {
                    if ((File.GetAttributes(name) & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        FormHelper.AddAudioFilesToListView(mainListView, FileHelper.GetAudioFilesFromFolder(name));
                    }
                }

                FormHelper.AddAudioFilesToListView(mainListView, fileNames);

                runToolStripButton.Enabled = (mainListView.Items.Count > 0);
            }
        }

        private void mainListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeToolStripButton.Enabled = (mainListView.SelectedItems.Count > 0);
        }

        private void mainListViewContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            openSourceFolderToolStripMenuItem.Enabled = (mainListView.SelectedItems.Count > 0);
            openDestinationFolderToolStripMenuItem.Enabled = (mainListView.SelectedItems.Count > 0);

            changeDestinationFolderToolStripMenuItem.Enabled = (mainListView.SelectedItems.Count > 0);

            selectAllToolStripMenuItem.Enabled = (mainListView.SelectedItems.Count != mainListView.Items.Count);
            deselectAllToolStripMenuItem.Enabled = (mainListView.Items.Count > 0) && (mainListView.SelectedItems.Count == mainListView.Items.Count);

            removeToolStripMenuItem.Enabled = (mainListView.SelectedItems.Count > 0);
            clearToolStripMenuItem.Enabled = (mainListView.Items.Count > 0);
        }

        private void mainListViewContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            mainListViewContextMenuStrip.Hide();

            if (e.ClickedItem == openSourceFolderToolStripMenuItem || e.ClickedItem == openDestinationFolderToolStripMenuItem)
            {
                Int32 columnIndex = 0;

                if (e.ClickedItem == openSourceFolderToolStripMenuItem)
                {
                    columnIndex = 3;
                }
                else if (e.ClickedItem == openDestinationFolderToolStripMenuItem)
                {
                    columnIndex = 4;
                }

                foreach (ListViewItem item in mainListView.SelectedItems)
                {
                    Process.Start(item.SubItems[columnIndex].Text);
                }
            }
            else if (e.ClickedItem == changeDestinationFolderToolStripMenuItem)
            {
                using (FolderBrowserDialog dlg = new FolderBrowserDialog())
                {
                    dlg.Description = "Select a destination folder";

                    if (mainListView.SelectedItems.Count == 1)
                    {
                        dlg.SelectedPath = mainListView.SelectedItems[0].SubItems[4].Text;
                    }

                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        foreach (ListViewItem item in mainListView.SelectedItems)
                        {
                            item.SubItems[4].Text = dlg.SelectedPath;
                        }
                    }
                }
            }
            else if (e.ClickedItem == selectAllToolStripMenuItem)
            {
                foreach (ListViewItem item in mainListView.Items)
                {
                    item.Selected = true;
                }
            }
            else if (e.ClickedItem == deselectAllToolStripMenuItem)
            {
                foreach (ListViewItem item in mainListView.Items)
                {
                    item.Selected = false;
                }
            }
            else if (e.ClickedItem == removeToolStripMenuItem)
            {
                removeToolStripButton.PerformClick();
            }
            else if (e.ClickedItem == clearToolStripMenuItem)
            {
                mainListView.Items.Clear();

                removeToolStripButton.Enabled = false;
                runToolStripButton.Enabled = false;
            }
        }
    }
}
