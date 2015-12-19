using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using AudioExtractor.Helpers;
using AudioExtractor.Structures;

namespace AudioExtractor
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            switch (VariableHelper.DefaultOutputDestination)
            {
                case AudioOutputDestination.SameAsSource:
                    sameAsSourceRadioButton.Checked = true;
                    specifiedFolderRadioButton_CheckedChanged(sender, e);
                    break;
                case AudioOutputDestination.SpecifiedLocation:
                    specifiedFolderRadioButton.Checked = true;
                    specifiedFolderTextBox.Text = VariableHelper.SpecifiedOutputFolder;
                    break;
                default:
                    break;
            }

            includeSubfoldersCheckBox.Checked = VariableHelper.IncludeSubfolders;
            deleteSourceFilesCheckBox.Checked = VariableHelper.DeleteSourceFiles;

            audioDecoderLocationTextBox.Text = Path.GetFullPath(VariableHelper.AudioDecodersLocation);

            foreach (KeyValuePair<String, AudioDecoder> pair in VariableHelper.AudioDecoders)
            {
                audioDecoderDataGridView.Rows.Add(pair.Value.Name, pair.Value.Extension, pair.Value.Command, pair.Value.Argument);
            }
        }

        private void specifiedFolderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            specifiedFolderTextBox.Enabled = specifiedFolderRadioButton.Checked;
            browseSpecifiedFolderButton.Enabled = specifiedFolderRadioButton.Checked;

            specifiedFolderTextBox.Text = specifiedFolderRadioButton.Checked ? VariableHelper.SpecifiedOutputFolder : String.Empty;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (sender == browseSpecifiedFolderButton)
                {
                    dlg.Description = "Select a folder to be the default output location";

                    if (!String.IsNullOrEmpty(specifiedFolderTextBox.Text))
                    {
                        dlg.SelectedPath = specifiedFolderTextBox.Text;
                    }
                }
                else if (sender == browseAudioDecoderLocationButton)
                {
                    dlg.Description = "Select a folder contains audio decoders";
                    dlg.SelectedPath = audioDecoderLocationTextBox.Text;
                }

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    if (sender == browseSpecifiedFolderButton)
                    {
                        specifiedFolderTextBox.Text = dlg.SelectedPath;
                    }
                    else if (sender == browseAudioDecoderLocationButton)
                    {
                        audioDecoderLocationTextBox.Text = dlg.SelectedPath;
                    }
                }
            }
        }

        private void audioDecoderDataGridViewContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            deleteSelectedRowsToolStripMenuItem.Enabled = (audioDecoderDataGridView.SelectedRows.Count > 0);
        }

        private void audioDecoderDataGridViewContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            while (audioDecoderDataGridView.SelectedRows.Count > 0)
            {
                audioDecoderDataGridView.Rows.Remove(audioDecoderDataGridView.SelectedRows[audioDecoderDataGridView.SelectedRows.Count - 1]);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in audioDecoderDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    try
                    {
                        if (!File.Exists(Path.Combine(VariableHelper.AudioDecodersLocation, row.Cells[2].Value.ToString())))
                        {
                            MessageBox.Show(String.Format("The following audio decoder does not exist:{0}{0}{1} ({2}){0}{3}{0}{0}Please make sure the program file is in the following path{0}{0}{4}",
                                Environment.NewLine,
                                row.Cells[0].Value.ToString(),
                                row.Cells[1].Value.ToString(),
                                row.Cells[2].Value.ToString(),
                                Path.GetFullPath(VariableHelper.AudioDecodersLocation)),
                                Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(String.Format("The settings of the audio decoder '{1}' are invalid!{0}Please make sure the decoder information is correct!", Environment.NewLine, row.Cells[0].Value.ToString()), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                }
            }

            if (sameAsSourceRadioButton.Checked)
            {
                VariableHelper.DefaultOutputDestination = AudioOutputDestination.SameAsSource;
            }
            else if (specifiedFolderRadioButton.Checked)
            {
                VariableHelper.DefaultOutputDestination = AudioOutputDestination.SpecifiedLocation;
                VariableHelper.SpecifiedOutputFolder = specifiedFolderTextBox.Text;
            }

            VariableHelper.IncludeSubfolders = includeSubfoldersCheckBox.Checked;
            VariableHelper.DeleteSourceFiles = deleteSourceFilesCheckBox.Checked;

            VariableHelper.AudioDecodersLocation = audioDecoderLocationTextBox.Text.Contains(Application.StartupPath) ? audioDecoderLocationTextBox.Text.Replace(String.Concat(Application.StartupPath, @"\"), String.Empty) : audioDecoderLocationTextBox.Text;

            VariableHelper.AudioDecoders.Clear();

            foreach (DataGridViewRow row in audioDecoderDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    VariableHelper.AudioDecoders.Add(row.Cells[1].Value.ToString(), new AudioDecoder(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString()));
                }
            }

            ConfigHelper.SaveConfiguration(VariableHelper.ConfigFileName);

            this.Close();
        }
    }
}
