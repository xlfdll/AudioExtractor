using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using AudioExtractor.Helpers;

namespace AudioExtractor
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        public ProgressForm(ListView listView)
            : this()
        {
            _listView = listView;
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            mainProgressBar.Maximum = _listView.Items.Count;

            ListViewItem[] items = new ListViewItem[_listView.Items.Count];

            _listView.Items.CopyTo(items, 0);

            mainBackgroundWorker.RunWorkerAsync(items);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancelButton.Enabled = false;

            mainBackgroundWorker.CancelAsync();

            processingCountLabel.Text = "Cancellation requested. Waiting for current task...";
        }

        private void mainBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Cannot access ListView.ListViewItemCollection, since the collection is created by main thread

            ListViewItem[] items = e.Argument as ListViewItem[];

            if (items != null)
            {
                for (Int32 i = 0; i < items.Length; i++)
                {
                    if (!mainBackgroundWorker.CancellationPending)
                    {
                        mainBackgroundWorker.ReportProgress(i + 1, items[i]); // Update label text

                        FormHelper.DecodeSpecifiedItem(items[i]);

                        mainBackgroundWorker.ReportProgress(i + 1, null); // Update progress bar
                    }
                    else
                    {
                        break;
                    }
                }

                e.Result = items;
                e.Cancel = mainBackgroundWorker.CancellationPending;
            }
        }

        private void mainBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ListViewItem item = e.UserState as ListViewItem;

            if (item != null)
            {
                processingCountLabel.Text = String.Format(processingCountLabel.Tag.ToString(), e.ProgressPercentage.ToString(), mainProgressBar.Maximum.ToString());
                processingNameLabel.Text = String.Concat(item.SubItems[0].Text, item.SubItems[1].Text);
            }
            else
            {
                mainProgressBar.Value = e.ProgressPercentage;
            }
        }

        private void mainBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                if (VariableHelper.DeleteSourceFiles)
                {
                    ListViewItem[] items = e.Result as ListViewItem[];

                    if (items != null)
                    {
                        for (Int32 i = 0; i < items.Length; i++)
                        {
                            String sourceFileName = FormHelper.GetAudioFileNameFromListViewItem(items[i]);

                            processingCountLabel.Text = String.Format("Deleting... {0} / {1}", i.ToString(), items.Length.ToString());
                            processingNameLabel.Text = Path.GetFileName(sourceFileName);

                            File.Delete(sourceFileName);

                            _listView.Items.Remove(items[i]);
                        }
                    }
                }
            }

            this.Hide();

            MessageBox.Show(!e.Cancelled ? "All operations successfully completed." : "Operations cancelled.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private ListView _listView;
    }
}
