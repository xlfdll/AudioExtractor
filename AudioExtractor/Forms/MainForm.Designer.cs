namespace AudioExtractor
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.mainListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extensionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.formatColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sourceFolderColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destinationFolderColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainListViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSourceFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDestinationFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.changeDestinationFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFolderToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.firstToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.addFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addFolderToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.removeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.runToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.decodeToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.configToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.configToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lastToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mainToolStripContainer.ContentPanel.SuspendLayout();
            this.mainToolStripContainer.TopToolStripPanel.SuspendLayout();
            this.mainToolStripContainer.SuspendLayout();
            this.mainListViewContextMenuStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolStripContainer
            // 
            // 
            // mainToolStripContainer.ContentPanel
            // 
            this.mainToolStripContainer.ContentPanel.Controls.Add(this.mainListView);
            resources.ApplyResources(this.mainToolStripContainer.ContentPanel, "mainToolStripContainer.ContentPanel");
            resources.ApplyResources(this.mainToolStripContainer, "mainToolStripContainer");
            this.mainToolStripContainer.Name = "mainToolStripContainer";
            // 
            // mainToolStripContainer.TopToolStripPanel
            // 
            this.mainToolStripContainer.TopToolStripPanel.Controls.Add(this.mainToolStrip);
            // 
            // mainListView
            // 
            this.mainListView.AllowColumnReorder = true;
            this.mainListView.AllowDrop = true;
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.extensionColumnHeader,
            this.formatColumnHeader,
            this.sourceFolderColumnHeader,
            this.destinationFolderColumnHeader});
            this.mainListView.ContextMenuStrip = this.mainListViewContextMenuStrip;
            resources.ApplyResources(this.mainListView, "mainListView");
            this.mainListView.FullRowSelect = true;
            this.mainListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mainListView.HideSelection = false;
            this.mainListView.LargeImageList = this.mainImageList;
            this.mainListView.Name = "mainListView";
            this.mainListView.SmallImageList = this.mainImageList;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.View = System.Windows.Forms.View.Details;
            this.mainListView.SelectedIndexChanged += new System.EventHandler(this.mainListView_SelectedIndexChanged);
            this.mainListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainListView_DragDrop);
            this.mainListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainListView_DragEnter);
            // 
            // nameColumnHeader
            // 
            resources.ApplyResources(this.nameColumnHeader, "nameColumnHeader");
            // 
            // extensionColumnHeader
            // 
            resources.ApplyResources(this.extensionColumnHeader, "extensionColumnHeader");
            // 
            // formatColumnHeader
            // 
            resources.ApplyResources(this.formatColumnHeader, "formatColumnHeader");
            // 
            // sourceFolderColumnHeader
            // 
            resources.ApplyResources(this.sourceFolderColumnHeader, "sourceFolderColumnHeader");
            // 
            // destinationFolderColumnHeader
            // 
            resources.ApplyResources(this.destinationFolderColumnHeader, "destinationFolderColumnHeader");
            // 
            // mainListViewContextMenuStrip
            // 
            this.mainListViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSourceFolderToolStripMenuItem,
            this.openDestinationFolderToolStripMenuItem,
            this.openFolderToolStripSeparator,
            this.changeDestinationFolderToolStripMenuItem,
            this.changeFolderToolStripSeparator,
            this.selectAllToolStripMenuItem,
            this.deselectAllToolStripMenuItem,
            this.selectToolStripSeparator,
            this.removeToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.mainListViewContextMenuStrip.Name = "mainListViewContextMenuStrip";
            resources.ApplyResources(this.mainListViewContextMenuStrip, "mainListViewContextMenuStrip");
            this.mainListViewContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.mainListViewContextMenuStrip_Opening);
            this.mainListViewContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainListViewContextMenuStrip_ItemClicked);
            // 
            // openSourceFolderToolStripMenuItem
            // 
            this.openSourceFolderToolStripMenuItem.Name = "openSourceFolderToolStripMenuItem";
            resources.ApplyResources(this.openSourceFolderToolStripMenuItem, "openSourceFolderToolStripMenuItem");
            // 
            // openDestinationFolderToolStripMenuItem
            // 
            this.openDestinationFolderToolStripMenuItem.Name = "openDestinationFolderToolStripMenuItem";
            resources.ApplyResources(this.openDestinationFolderToolStripMenuItem, "openDestinationFolderToolStripMenuItem");
            // 
            // openFolderToolStripSeparator
            // 
            this.openFolderToolStripSeparator.Name = "openFolderToolStripSeparator";
            resources.ApplyResources(this.openFolderToolStripSeparator, "openFolderToolStripSeparator");
            // 
            // changeDestinationFolderToolStripMenuItem
            // 
            this.changeDestinationFolderToolStripMenuItem.Image = global::AudioExtractor.Properties.Resources.Change;
            this.changeDestinationFolderToolStripMenuItem.Name = "changeDestinationFolderToolStripMenuItem";
            resources.ApplyResources(this.changeDestinationFolderToolStripMenuItem, "changeDestinationFolderToolStripMenuItem");
            // 
            // changeFolderToolStripSeparator
            // 
            this.changeFolderToolStripSeparator.Name = "changeFolderToolStripSeparator";
            resources.ApplyResources(this.changeFolderToolStripSeparator, "changeFolderToolStripSeparator");
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            resources.ApplyResources(this.selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
            // 
            // deselectAllToolStripMenuItem
            // 
            this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            resources.ApplyResources(this.deselectAllToolStripMenuItem, "deselectAllToolStripMenuItem");
            // 
            // selectToolStripSeparator
            // 
            this.selectToolStripSeparator.Name = "selectToolStripSeparator";
            resources.ApplyResources(this.selectToolStripSeparator, "selectToolStripSeparator");
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = global::AudioExtractor.Properties.Resources.Remove;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            resources.ApplyResources(this.removeToolStripMenuItem, "removeToolStripMenuItem");
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            // 
            // mainImageList
            // 
            this.mainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            resources.ApplyResources(this.mainImageList, "mainImageList");
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // mainToolStrip
            // 
            resources.ApplyResources(this.mainToolStrip, "mainToolStrip");
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstToolStripSeparator,
            this.addFileToolStripButton,
            this.addFolderToolStripButton,
            this.addToolStripSeparator,
            this.removeToolStripButton,
            this.removeToolStripSeparator,
            this.runToolStripButton,
            this.decodeToolStripSeparator,
            this.configToolStripButton,
            this.configToolStripSeparator,
            this.aboutToolStripButton,
            this.lastToolStripSeparator});
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Stretch = true;
            this.mainToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainToolStrip_ItemClicked);
            // 
            // firstToolStripSeparator
            // 
            this.firstToolStripSeparator.Name = "firstToolStripSeparator";
            resources.ApplyResources(this.firstToolStripSeparator, "firstToolStripSeparator");
            // 
            // addFileToolStripButton
            // 
            this.addFileToolStripButton.Image = global::AudioExtractor.Properties.Resources.Music;
            resources.ApplyResources(this.addFileToolStripButton, "addFileToolStripButton");
            this.addFileToolStripButton.Name = "addFileToolStripButton";
            // 
            // addFolderToolStripButton
            // 
            this.addFolderToolStripButton.Image = global::AudioExtractor.Properties.Resources.Search;
            resources.ApplyResources(this.addFolderToolStripButton, "addFolderToolStripButton");
            this.addFolderToolStripButton.Name = "addFolderToolStripButton";
            // 
            // addToolStripSeparator
            // 
            this.addToolStripSeparator.Name = "addToolStripSeparator";
            resources.ApplyResources(this.addToolStripSeparator, "addToolStripSeparator");
            // 
            // removeToolStripButton
            // 
            resources.ApplyResources(this.removeToolStripButton, "removeToolStripButton");
            this.removeToolStripButton.Image = global::AudioExtractor.Properties.Resources.Remove;
            this.removeToolStripButton.Name = "removeToolStripButton";
            // 
            // removeToolStripSeparator
            // 
            this.removeToolStripSeparator.Name = "removeToolStripSeparator";
            resources.ApplyResources(this.removeToolStripSeparator, "removeToolStripSeparator");
            // 
            // runToolStripButton
            // 
            resources.ApplyResources(this.runToolStripButton, "runToolStripButton");
            this.runToolStripButton.Image = global::AudioExtractor.Properties.Resources.Run;
            this.runToolStripButton.Name = "runToolStripButton";
            // 
            // decodeToolStripSeparator
            // 
            this.decodeToolStripSeparator.Name = "decodeToolStripSeparator";
            resources.ApplyResources(this.decodeToolStripSeparator, "decodeToolStripSeparator");
            // 
            // configToolStripButton
            // 
            this.configToolStripButton.Image = global::AudioExtractor.Properties.Resources.Options;
            resources.ApplyResources(this.configToolStripButton, "configToolStripButton");
            this.configToolStripButton.Name = "configToolStripButton";
            // 
            // configToolStripSeparator
            // 
            this.configToolStripSeparator.Name = "configToolStripSeparator";
            resources.ApplyResources(this.configToolStripSeparator, "configToolStripSeparator");
            // 
            // aboutToolStripButton
            // 
            this.aboutToolStripButton.Image = global::AudioExtractor.Properties.Resources.About;
            resources.ApplyResources(this.aboutToolStripButton, "aboutToolStripButton");
            this.aboutToolStripButton.Name = "aboutToolStripButton";
            // 
            // lastToolStripSeparator
            // 
            this.lastToolStripSeparator.Name = "lastToolStripSeparator";
            resources.ApplyResources(this.lastToolStripSeparator, "lastToolStripSeparator");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainToolStripContainer);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.mainToolStripContainer.ContentPanel.ResumeLayout(false);
            this.mainToolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.mainToolStripContainer.TopToolStripPanel.PerformLayout();
            this.mainToolStripContainer.ResumeLayout(false);
            this.mainToolStripContainer.PerformLayout();
            this.mainListViewContextMenuStrip.ResumeLayout(false);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripContainer mainToolStripContainer;
        private System.Windows.Forms.ToolStripSeparator firstToolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator addToolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator removeToolStripSeparator;
        private System.Windows.Forms.ToolStripButton runToolStripButton;
        private System.Windows.Forms.ToolStripSeparator decodeToolStripSeparator;
        private System.Windows.Forms.ToolStripButton configToolStripButton;
        private System.Windows.Forms.ToolStripSeparator configToolStripSeparator;
        private System.Windows.Forms.ToolStripButton aboutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator lastToolStripSeparator;
        private System.Windows.Forms.ListView mainListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader extensionColumnHeader;
        private System.Windows.Forms.ColumnHeader formatColumnHeader;
        private System.Windows.Forms.ColumnHeader sourceFolderColumnHeader;
        private System.Windows.Forms.ColumnHeader destinationFolderColumnHeader;
        private System.Windows.Forms.ToolStripButton addFileToolStripButton;
        private System.Windows.Forms.ToolStripButton addFolderToolStripButton;
        private System.Windows.Forms.ContextMenuStrip mainListViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem changeDestinationFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator changeFolderToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator selectToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSourceFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDestinationFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator openFolderToolStripSeparator;
        private System.Windows.Forms.ImageList mainImageList;
        private System.Windows.Forms.ToolStripButton removeToolStripButton;
    }
}

