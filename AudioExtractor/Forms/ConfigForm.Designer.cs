namespace AudioExtractor
{
    partial class ConfigForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteSourceFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.includeSubfoldersCheckBox = new System.Windows.Forms.CheckBox();
            this.defaultOutputGroupBox = new System.Windows.Forms.GroupBox();
            this.browseSpecifiedFolderButton = new System.Windows.Forms.Button();
            this.specifiedFolderTextBox = new System.Windows.Forms.TextBox();
            this.specifiedFolderRadioButton = new System.Windows.Forms.RadioButton();
            this.sameAsSourceRadioButton = new System.Windows.Forms.RadioButton();
            this.audioDecoderGroupBox = new System.Windows.Forms.GroupBox();
            this.audioDecoderDataGridView = new System.Windows.Forms.DataGridView();
            this.FormatNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormatExtensionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormatCommandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormatCommandArgumentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audioDecoderDataGridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSelectedRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseAudioDecoderLocationButton = new System.Windows.Forms.Button();
            this.audioDecoderLocationTextBox = new System.Windows.Forms.TextBox();
            this.audioDecoderLocationLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.generalGroupBox.SuspendLayout();
            this.defaultOutputGroupBox.SuspendLayout();
            this.audioDecoderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audioDecoderDataGridView)).BeginInit();
            this.audioDecoderDataGridViewContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalGroupBox
            // 
            resources.ApplyResources(this.generalGroupBox, "generalGroupBox");
            this.generalGroupBox.Controls.Add(this.deleteSourceFilesCheckBox);
            this.generalGroupBox.Controls.Add(this.includeSubfoldersCheckBox);
            this.generalGroupBox.Controls.Add(this.defaultOutputGroupBox);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.TabStop = false;
            // 
            // deleteSourceFilesCheckBox
            // 
            resources.ApplyResources(this.deleteSourceFilesCheckBox, "deleteSourceFilesCheckBox");
            this.deleteSourceFilesCheckBox.Name = "deleteSourceFilesCheckBox";
            this.deleteSourceFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeSubfoldersCheckBox
            // 
            resources.ApplyResources(this.includeSubfoldersCheckBox, "includeSubfoldersCheckBox");
            this.includeSubfoldersCheckBox.Name = "includeSubfoldersCheckBox";
            this.includeSubfoldersCheckBox.UseVisualStyleBackColor = true;
            // 
            // defaultOutputGroupBox
            // 
            resources.ApplyResources(this.defaultOutputGroupBox, "defaultOutputGroupBox");
            this.defaultOutputGroupBox.Controls.Add(this.browseSpecifiedFolderButton);
            this.defaultOutputGroupBox.Controls.Add(this.specifiedFolderTextBox);
            this.defaultOutputGroupBox.Controls.Add(this.specifiedFolderRadioButton);
            this.defaultOutputGroupBox.Controls.Add(this.sameAsSourceRadioButton);
            this.defaultOutputGroupBox.Name = "defaultOutputGroupBox";
            this.defaultOutputGroupBox.TabStop = false;
            // 
            // browseSpecifiedFolderButton
            // 
            resources.ApplyResources(this.browseSpecifiedFolderButton, "browseSpecifiedFolderButton");
            this.browseSpecifiedFolderButton.Name = "browseSpecifiedFolderButton";
            this.browseSpecifiedFolderButton.UseVisualStyleBackColor = true;
            this.browseSpecifiedFolderButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // specifiedFolderTextBox
            // 
            resources.ApplyResources(this.specifiedFolderTextBox, "specifiedFolderTextBox");
            this.specifiedFolderTextBox.Name = "specifiedFolderTextBox";
            // 
            // specifiedFolderRadioButton
            // 
            resources.ApplyResources(this.specifiedFolderRadioButton, "specifiedFolderRadioButton");
            this.specifiedFolderRadioButton.Name = "specifiedFolderRadioButton";
            this.specifiedFolderRadioButton.UseVisualStyleBackColor = true;
            this.specifiedFolderRadioButton.CheckedChanged += new System.EventHandler(this.specifiedFolderRadioButton_CheckedChanged);
            // 
            // sameAsSourceRadioButton
            // 
            resources.ApplyResources(this.sameAsSourceRadioButton, "sameAsSourceRadioButton");
            this.sameAsSourceRadioButton.Name = "sameAsSourceRadioButton";
            this.sameAsSourceRadioButton.UseVisualStyleBackColor = true;
            // 
            // audioDecoderGroupBox
            // 
            resources.ApplyResources(this.audioDecoderGroupBox, "audioDecoderGroupBox");
            this.audioDecoderGroupBox.Controls.Add(this.audioDecoderDataGridView);
            this.audioDecoderGroupBox.Controls.Add(this.browseAudioDecoderLocationButton);
            this.audioDecoderGroupBox.Controls.Add(this.audioDecoderLocationTextBox);
            this.audioDecoderGroupBox.Controls.Add(this.audioDecoderLocationLabel);
            this.audioDecoderGroupBox.Name = "audioDecoderGroupBox";
            this.audioDecoderGroupBox.TabStop = false;
            // 
            // audioDecoderDataGridView
            // 
            resources.ApplyResources(this.audioDecoderDataGridView, "audioDecoderDataGridView");
            this.audioDecoderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.audioDecoderDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.audioDecoderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.audioDecoderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FormatNameColumn,
            this.FormatExtensionColumn,
            this.FormatCommandColumn,
            this.FormatCommandArgumentColumn});
            this.audioDecoderDataGridView.ContextMenuStrip = this.audioDecoderDataGridViewContextMenuStrip;
            this.audioDecoderDataGridView.Name = "audioDecoderDataGridView";
            this.audioDecoderDataGridView.RowTemplate.Height = 23;
            // 
            // FormatNameColumn
            // 
            resources.ApplyResources(this.FormatNameColumn, "FormatNameColumn");
            this.FormatNameColumn.Name = "FormatNameColumn";
            // 
            // FormatExtensionColumn
            // 
            resources.ApplyResources(this.FormatExtensionColumn, "FormatExtensionColumn");
            this.FormatExtensionColumn.Name = "FormatExtensionColumn";
            // 
            // FormatCommandColumn
            // 
            resources.ApplyResources(this.FormatCommandColumn, "FormatCommandColumn");
            this.FormatCommandColumn.Name = "FormatCommandColumn";
            // 
            // FormatCommandArgumentColumn
            // 
            resources.ApplyResources(this.FormatCommandArgumentColumn, "FormatCommandArgumentColumn");
            this.FormatCommandArgumentColumn.Name = "FormatCommandArgumentColumn";
            // 
            // audioDecoderDataGridViewContextMenuStrip
            // 
            this.audioDecoderDataGridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedRowsToolStripMenuItem});
            this.audioDecoderDataGridViewContextMenuStrip.Name = "audioDecoderDataGridViewContextMenuStrip";
            resources.ApplyResources(this.audioDecoderDataGridViewContextMenuStrip, "audioDecoderDataGridViewContextMenuStrip");
            this.audioDecoderDataGridViewContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.audioDecoderDataGridViewContextMenuStrip_Opening);
            this.audioDecoderDataGridViewContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.audioDecoderDataGridViewContextMenuStrip_ItemClicked);
            // 
            // deleteSelectedRowsToolStripMenuItem
            // 
            this.deleteSelectedRowsToolStripMenuItem.Image = global::AudioExtractor.Properties.Resources.Remove;
            this.deleteSelectedRowsToolStripMenuItem.Name = "deleteSelectedRowsToolStripMenuItem";
            resources.ApplyResources(this.deleteSelectedRowsToolStripMenuItem, "deleteSelectedRowsToolStripMenuItem");
            // 
            // browseAudioDecoderLocationButton
            // 
            resources.ApplyResources(this.browseAudioDecoderLocationButton, "browseAudioDecoderLocationButton");
            this.browseAudioDecoderLocationButton.Name = "browseAudioDecoderLocationButton";
            this.browseAudioDecoderLocationButton.UseVisualStyleBackColor = true;
            this.browseAudioDecoderLocationButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // audioDecoderLocationTextBox
            // 
            resources.ApplyResources(this.audioDecoderLocationTextBox, "audioDecoderLocationTextBox");
            this.audioDecoderLocationTextBox.Name = "audioDecoderLocationTextBox";
            // 
            // audioDecoderLocationLabel
            // 
            resources.ApplyResources(this.audioDecoderLocationLabel, "audioDecoderLocationLabel");
            this.audioDecoderLocationLabel.Name = "audioDecoderLocationLabel";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ConfigForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.generalGroupBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.audioDecoderGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            this.defaultOutputGroupBox.ResumeLayout(false);
            this.defaultOutputGroupBox.PerformLayout();
            this.audioDecoderGroupBox.ResumeLayout(false);
            this.audioDecoderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audioDecoderDataGridView)).EndInit();
            this.audioDecoderDataGridViewContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.CheckBox includeSubfoldersCheckBox;
        private System.Windows.Forms.GroupBox defaultOutputGroupBox;
        private System.Windows.Forms.Button browseSpecifiedFolderButton;
        private System.Windows.Forms.TextBox specifiedFolderTextBox;
        private System.Windows.Forms.RadioButton specifiedFolderRadioButton;
        private System.Windows.Forms.RadioButton sameAsSourceRadioButton;
        private System.Windows.Forms.CheckBox deleteSourceFilesCheckBox;
        private System.Windows.Forms.GroupBox audioDecoderGroupBox;
        private System.Windows.Forms.Label audioDecoderLocationLabel;
        private System.Windows.Forms.Button browseAudioDecoderLocationButton;
        private System.Windows.Forms.TextBox audioDecoderLocationTextBox;
        private System.Windows.Forms.DataGridView audioDecoderDataGridView;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ContextMenuStrip audioDecoderDataGridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedRowsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormatNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormatExtensionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormatCommandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormatCommandArgumentColumn;
    }
}