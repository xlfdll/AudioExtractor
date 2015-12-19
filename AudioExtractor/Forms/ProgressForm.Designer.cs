namespace AudioExtractor
{
    partial class ProgressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.processingCountLabel = new System.Windows.Forms.Label();
            this.processingNameLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            resources.ApplyResources(this.mainTableLayoutPanel, "mainTableLayoutPanel");
            this.mainTableLayoutPanel.Controls.Add(this.mainProgressBar, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.processingCountLabel, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.processingNameLabel, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.cancelButton, 0, 4);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            // 
            // mainProgressBar
            // 
            resources.ApplyResources(this.mainProgressBar, "mainProgressBar");
            this.mainProgressBar.Name = "mainProgressBar";
            // 
            // processingCountLabel
            // 
            resources.ApplyResources(this.processingCountLabel, "processingCountLabel");
            this.processingCountLabel.Name = "processingCountLabel";
            this.processingCountLabel.Tag = "Decoding... {0} / {1}";
            // 
            // processingNameLabel
            // 
            this.processingNameLabel.AutoEllipsis = true;
            resources.ApplyResources(this.processingNameLabel, "processingNameLabel");
            this.processingNameLabel.Name = "processingNameLabel";
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // mainBackgroundWorker
            // 
            this.mainBackgroundWorker.WorkerReportsProgress = true;
            this.mainBackgroundWorker.WorkerSupportsCancellation = true;
            this.mainBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.mainBackgroundWorker_DoWork);
            this.mainBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.mainBackgroundWorker_ProgressChanged);
            this.mainBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.mainBackgroundWorker_RunWorkerCompleted);
            // 
            // ProgressForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ProgressForm_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.ProgressBar mainProgressBar;
        private System.Windows.Forms.Label processingCountLabel;
        private System.Windows.Forms.Label processingNameLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.ComponentModel.BackgroundWorker mainBackgroundWorker;
    }
}