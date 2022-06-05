
namespace NFTGenerator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imlFolders = new System.Windows.Forms.ImageList(this.components);
            this.pgProjLay = new System.Windows.Forms.PropertyGrid();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddFolder = new System.Windows.Forms.ToolStripButton();
            this.btnAddFile = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUp = new System.Windows.Forms.ToolStripButton();
            this.btnDown = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RarityTable = new System.Windows.Forms.TabPage();
            this.rarityTreeListView = new BrightIdeasSoftware.TreeListView();
            this.TraitName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.RarityPercentage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TraitId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.NumberOfOccurences = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnReloadRarityTable = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtTotalItems = new System.Windows.Forms.ToolStripTextBox();
            this.Generate = new System.Windows.Forms.TabPage();
            this.outputListView = new BrightIdeasSoftware.ObjectListView();
            this.tokenID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.rarityScore = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.uniqueId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.hash = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.metaAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnGenerate = new System.Windows.Forms.ToolStripButton();
            this.btnGenerateCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblGenProgress = new System.Windows.Forms.ToolStripLabel();
            this.btnProjectSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtStartTokenID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUpdateMeta = new System.Windows.Forms.ToolStripButton();
            this.Preview = new System.Windows.Forms.TabPage();
            this.previewObjectListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.realm = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPicOriginal = new System.Windows.Forms.ToolStripButton();
            this.folderBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.prg1 = new System.Windows.Forms.ToolStripProgressBar();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgAddFile = new System.Windows.Forms.OpenFileDialog();
            this.timerGen = new System.Windows.Forms.Timer(this.components);
            this.dlgLoadJSON = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveJSON = new System.Windows.Forms.SaveFileDialog();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.imageRenderer1 = new BrightIdeasSoftware.ImageRenderer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.RarityTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rarityTreeListView)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.Generate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputListView)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.Preview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewObjectListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1423, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewProject,
            this.mnuOpenProject,
            this.mnuSaveProject,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuNewProject
            // 
            this.mnuNewProject.Image = global::NFTGenerator.Properties.Resources._new;
            this.mnuNewProject.Name = "mnuNewProject";
            this.mnuNewProject.Size = new System.Drawing.Size(195, 22);
            this.mnuNewProject.Text = "&New Project...";
            this.mnuNewProject.Click += new System.EventHandler(this.mnuNewProject_Click);
            // 
            // mnuOpenProject
            // 
            this.mnuOpenProject.Image = global::NFTGenerator.Properties.Resources.open;
            this.mnuOpenProject.Name = "mnuOpenProject";
            this.mnuOpenProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpenProject.Size = new System.Drawing.Size(195, 22);
            this.mnuOpenProject.Text = "&Open Project...";
            this.mnuOpenProject.Click += new System.EventHandler(this.mnuOpenProject_Click);
            // 
            // mnuSaveProject
            // 
            this.mnuSaveProject.Image = global::NFTGenerator.Properties.Resources.save;
            this.mnuSaveProject.Name = "mnuSaveProject";
            this.mnuSaveProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSaveProject.Size = new System.Drawing.Size(195, 22);
            this.mnuSaveProject.Text = "&Save Project...";
            this.mnuSaveProject.Click += new System.EventHandler(this.mnuSaveProject_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(195, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProjectSettings});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "&Project";
            // 
            // mnuProjectSettings
            // 
            this.mnuProjectSettings.Image = global::NFTGenerator.Properties.Resources.settings;
            this.mnuProjectSettings.Name = "mnuProjectSettings";
            this.mnuProjectSettings.Size = new System.Drawing.Size(165, 22);
            this.mnuProjectSettings.Text = "Project &Settings...";
            this.mnuProjectSettings.Click += new System.EventHandler(this.mnuProjectSettings_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.pgProjLay);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1423, 687);
            this.splitContainer1.SplitterDistance = 347;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imlFolders;
            this.treeView1.Location = new System.Drawing.Point(0, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 1;
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(347, 344);
            this.treeView1.TabIndex = 1;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeView1.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView1_DragOver);
            // 
            // imlFolders
            // 
            this.imlFolders.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFolders.ImageStream")));
            this.imlFolders.TransparentColor = System.Drawing.Color.Transparent;
            this.imlFolders.Images.SetKeyName(0, "Folder-icon.png");
            this.imlFolders.Images.SetKeyName(1, "Folder-Open-icon.png");
            this.imlFolders.Images.SetKeyName(2, "Layer-Backward-icon.png");
            // 
            // pgProjLay
            // 
            this.pgProjLay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgProjLay.Location = new System.Drawing.Point(0, 369);
            this.pgProjLay.Name = "pgProjLay";
            this.pgProjLay.Size = new System.Drawing.Size(347, 318);
            this.pgProjLay.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddFolder,
            this.btnAddFile,
            this.btnRemoveFolder,
            this.toolStripSeparator2,
            this.btnUp,
            this.btnDown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(347, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddFolder.Image = global::NFTGenerator.Properties.Resources.add_folder;
            this.btnAddFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(23, 22);
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddFile.Enabled = false;
            this.btnAddFile.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFile.Image")));
            this.btnAddFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(23, 22);
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnRemoveFolder
            // 
            this.btnRemoveFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveFolder.Enabled = false;
            this.btnRemoveFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveFolder.Image")));
            this.btnRemoveFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveFolder.Name = "btnRemoveFolder";
            this.btnRemoveFolder.Size = new System.Drawing.Size(23, 22);
            this.btnRemoveFolder.Text = "Remove Item";
            this.btnRemoveFolder.Click += new System.EventHandler(this.btnRemoveFolder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnUp
            // 
            this.btnUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUp.Enabled = false;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(23, 22);
            this.btnUp.Text = "Move Up";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDown.Enabled = false;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(23, 22);
            this.btnDown.Text = "Move Down";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RarityTable);
            this.tabControl1.Controls.Add(this.Generate);
            this.tabControl1.Controls.Add(this.Preview);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1072, 687);
            this.tabControl1.TabIndex = 0;
            // 
            // RarityTable
            // 
            this.RarityTable.Controls.Add(this.rarityTreeListView);
            this.RarityTable.Controls.Add(this.toolStrip2);
            this.RarityTable.Location = new System.Drawing.Point(4, 22);
            this.RarityTable.Name = "RarityTable";
            this.RarityTable.Padding = new System.Windows.Forms.Padding(3);
            this.RarityTable.Size = new System.Drawing.Size(1064, 661);
            this.RarityTable.TabIndex = 1;
            this.RarityTable.Text = "Rarity Table";
            this.RarityTable.UseVisualStyleBackColor = true;
            // 
            // rarityTreeListView
            // 
            this.rarityTreeListView.AllColumns.Add(this.TraitName);
            this.rarityTreeListView.AllColumns.Add(this.RarityPercentage);
            this.rarityTreeListView.AllColumns.Add(this.TraitId);
            this.rarityTreeListView.AllColumns.Add(this.NumberOfOccurences);
            this.rarityTreeListView.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rarityTreeListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.rarityTreeListView.CellEditUseWholeCell = false;
            this.rarityTreeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TraitName,
            this.RarityPercentage,
            this.TraitId,
            this.NumberOfOccurences});
            this.rarityTreeListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.rarityTreeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rarityTreeListView.FullRowSelect = true;
            this.rarityTreeListView.GridLines = true;
            this.rarityTreeListView.HideSelection = false;
            this.rarityTreeListView.Location = new System.Drawing.Point(3, 28);
            this.rarityTreeListView.Name = "rarityTreeListView";
            this.rarityTreeListView.ShowGroups = false;
            this.rarityTreeListView.Size = new System.Drawing.Size(1058, 630);
            this.rarityTreeListView.TabIndex = 2;
            this.rarityTreeListView.UseCompatibleStateImageBehavior = false;
            this.rarityTreeListView.View = System.Windows.Forms.View.Details;
            this.rarityTreeListView.VirtualMode = true;
            this.rarityTreeListView.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.rarityTreeListView_CellEditFinishing);
            // 
            // TraitName
            // 
            this.TraitName.AspectName = "Name";
            this.TraitName.IsEditable = false;
            this.TraitName.Text = "Name";
            this.TraitName.Width = 400;
            // 
            // RarityPercentage
            // 
            this.RarityPercentage.AspectName = "RarityPercentage";
            this.RarityPercentage.IsEditable = false;
            this.RarityPercentage.Text = "Rarity %";
            this.RarityPercentage.Width = 80;
            // 
            // TraitId
            // 
            this.TraitId.AspectName = "Id";
            this.TraitId.IsEditable = false;
            this.TraitId.Text = "ID";
            this.TraitId.Width = 120;
            // 
            // NumberOfOccurences
            // 
            this.NumberOfOccurences.AspectName = "NumberOfOccurences";
            this.NumberOfOccurences.Text = "# of occurences";
            this.NumberOfOccurences.Width = 100;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReloadRarityTable,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.txtTotalItems});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1058, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnReloadRarityTable
            // 
            this.btnReloadRarityTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReloadRarityTable.Image = global::NFTGenerator.Properties.Resources.refresh;
            this.btnReloadRarityTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReloadRarityTable.Name = "btnReloadRarityTable";
            this.btnReloadRarityTable.Size = new System.Drawing.Size(23, 22);
            this.btnReloadRarityTable.Text = "toolStripButton3";
            this.btnReloadRarityTable.Click += new System.EventHandler(this.btnReloadRarityTable_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel1.Text = "Total Tokens:";
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.Size = new System.Drawing.Size(75, 25);
            this.txtTotalItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalItems_KeyPress);
            this.txtTotalItems.TextChanged += new System.EventHandler(this.txtTotalItems_TextChanged);
            // 
            // Generate
            // 
            this.Generate.Controls.Add(this.outputListView);
            this.Generate.Controls.Add(this.toolStrip3);
            this.Generate.Location = new System.Drawing.Point(4, 22);
            this.Generate.Name = "Generate";
            this.Generate.Padding = new System.Windows.Forms.Padding(3);
            this.Generate.Size = new System.Drawing.Size(1064, 661);
            this.Generate.TabIndex = 3;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            // 
            // outputListView
            // 
            this.outputListView.AllColumns.Add(this.tokenID);
            this.outputListView.AllColumns.Add(this.rarityScore);
            this.outputListView.AllColumns.Add(this.uniqueId);
            this.outputListView.AllColumns.Add(this.hash);
            this.outputListView.AllColumns.Add(this.metaAddress);
            this.outputListView.CellEditUseWholeCell = false;
            this.outputListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tokenID,
            this.rarityScore,
            this.uniqueId,
            this.hash,
            this.metaAddress});
            this.outputListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.outputListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputListView.FullRowSelect = true;
            this.outputListView.GridLines = true;
            this.outputListView.HideSelection = false;
            this.outputListView.Location = new System.Drawing.Point(3, 28);
            this.outputListView.Name = "outputListView";
            this.outputListView.ShowGroups = false;
            this.outputListView.Size = new System.Drawing.Size(1058, 630);
            this.outputListView.TabIndex = 3;
            this.outputListView.UseCompatibleStateImageBehavior = false;
            this.outputListView.View = System.Windows.Forms.View.Details;
            // 
            // tokenID
            // 
            this.tokenID.AspectName = "TokenID";
            this.tokenID.Groupable = false;
            this.tokenID.Text = "Token ID";
            this.tokenID.Width = 70;
            // 
            // rarityScore
            // 
            this.rarityScore.AspectName = "RarityScore";
            this.rarityScore.Groupable = false;
            this.rarityScore.Text = "Rarity score";
            this.rarityScore.Width = 148;
            // 
            // uniqueId
            // 
            this.uniqueId.AspectName = "UniqueID";
            this.uniqueId.Text = "Trait composition";
            this.uniqueId.Width = 412;
            // 
            // hash
            // 
            this.hash.AspectName = "Hash";
            this.hash.Groupable = false;
            this.hash.Text = "Hash";
            this.hash.Width = 459;
            // 
            // metaAddress
            // 
            this.metaAddress.AspectName = "MetaAddress";
            this.metaAddress.Text = "Meta Address";
            this.metaAddress.Width = 400;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGenerate,
            this.btnGenerateCancel,
            this.toolStripSeparator1,
            this.lblGenProgress,
            this.btnProjectSettings,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.txtStartTokenID,
            this.toolStripSeparator5,
            this.toolStripButtonUpdateMeta});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1058, 25);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Image = global::NFTGenerator.Properties.Resources.play;
            this.btnGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(74, 22);
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnGenerateCancel
            // 
            this.btnGenerateCancel.Enabled = false;
            this.btnGenerateCancel.Image = global::NFTGenerator.Properties.Resources.stop;
            this.btnGenerateCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerateCancel.Name = "btnGenerateCancel";
            this.btnGenerateCancel.Size = new System.Drawing.Size(93, 22);
            this.btnGenerateCancel.Text = "Cancel build";
            this.btnGenerateCancel.Click += new System.EventHandler(this.btnGenerateCancel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblGenProgress
            // 
            this.lblGenProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblGenProgress.Name = "lblGenProgress";
            this.lblGenProgress.Size = new System.Drawing.Size(0, 22);
            // 
            // btnProjectSettings
            // 
            this.btnProjectSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProjectSettings.Image = global::NFTGenerator.Properties.Resources.settings;
            this.btnProjectSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProjectSettings.Name = "btnProjectSettings";
            this.btnProjectSettings.Size = new System.Drawing.Size(23, 22);
            this.btnProjectSettings.Text = "Project Settings";
            this.btnProjectSettings.Click += new System.EventHandler(this.mnuProjectSettings_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(81, 22);
            this.toolStripLabel2.Text = "Start token ID:";
            // 
            // txtStartTokenID
            // 
            this.txtStartTokenID.Name = "txtStartTokenID";
            this.txtStartTokenID.Size = new System.Drawing.Size(50, 25);
            this.txtStartTokenID.Text = "1";
            this.txtStartTokenID.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonUpdateMeta
            // 
            this.toolStripButtonUpdateMeta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUpdateMeta.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateMeta.Image")));
            this.toolStripButtonUpdateMeta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateMeta.Name = "toolStripButtonUpdateMeta";
            this.toolStripButtonUpdateMeta.Size = new System.Drawing.Size(105, 22);
            this.toolStripButtonUpdateMeta.Text = "Update meta data";
            this.toolStripButtonUpdateMeta.Click += new System.EventHandler(this.toolStripButtonUpdateMeta_Click);
            // 
            // Preview
            // 
            this.Preview.Controls.Add(this.previewObjectListView);
            this.Preview.Controls.Add(this.pictureBox1);
            this.Preview.Location = new System.Drawing.Point(4, 22);
            this.Preview.Name = "Preview";
            this.Preview.Padding = new System.Windows.Forms.Padding(3);
            this.Preview.Size = new System.Drawing.Size(1064, 661);
            this.Preview.TabIndex = 0;
            this.Preview.Text = "Preview";
            this.Preview.UseVisualStyleBackColor = true;
            // 
            // previewObjectListView
            // 
            this.previewObjectListView.AllColumns.Add(this.olvColumn1);
            this.previewObjectListView.AllColumns.Add(this.olvColumn2);
            this.previewObjectListView.AllColumns.Add(this.realm);
            this.previewObjectListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.previewObjectListView.CellEditUseWholeCell = false;
            this.previewObjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.realm});
            this.previewObjectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.previewObjectListView.FullRowSelect = true;
            this.previewObjectListView.GridLines = true;
            this.previewObjectListView.HideSelection = false;
            this.previewObjectListView.Location = new System.Drawing.Point(3, 3);
            this.previewObjectListView.Margin = new System.Windows.Forms.Padding(0);
            this.previewObjectListView.Name = "previewObjectListView";
            this.previewObjectListView.ShowGroups = false;
            this.previewObjectListView.Size = new System.Drawing.Size(331, 655);
            this.previewObjectListView.TabIndex = 6;
            this.previewObjectListView.UseCompatibleStateImageBehavior = false;
            this.previewObjectListView.View = System.Windows.Forms.View.Details;
            this.previewObjectListView.SelectedIndexChanged += new System.EventHandler(this.previewObjectListView_SelectedIndexChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "TokenID";
            this.olvColumn1.Groupable = false;
            this.olvColumn1.Text = "Token ID";
            this.olvColumn1.Width = 70;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "RarityScore";
            this.olvColumn2.Groupable = false;
            this.olvColumn2.Text = "Rarity score";
            this.olvColumn2.Width = 100;
            // 
            // realm
            // 
            this.realm.AspectName = "Realm";
            this.realm.Text = "Realm";
            this.realm.Width = 120;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(337, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(724, 655);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolStrip4
            // 
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(100, 25);
            this.toolStrip4.TabIndex = 0;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(23, 23);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 6);
            // 
            // btnPicOriginal
            // 
            this.btnPicOriginal.Name = "btnPicOriginal";
            this.btnPicOriginal.Size = new System.Drawing.Size(23, 23);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusInfo,
            this.prg1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1423, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusInfo
            // 
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(1408, 17);
            this.statusInfo.Spring = true;
            this.statusInfo.Text = "...";
            this.statusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prg1
            // 
            this.prg1.Name = "prg1";
            this.prg1.Size = new System.Drawing.Size(180, 16);
            this.prg1.ToolTipText = "Generating items...";
            this.prg1.Visible = false;
            // 
            // dlgSave
            // 
            this.dlgSave.Filter = "NFT Collection (*.nftc)|*.nftc|All Files (*.*)|*.*";
            this.dlgSave.Title = "Save Project";
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "NFT Collection (*.nftc)|*.nftc|All Files (*.*)|*.*";
            this.dlgOpen.Title = "Open Project";
            // 
            // dlgAddFile
            // 
            this.dlgAddFile.FileName = "Add Layer";
            this.dlgAddFile.Filter = "Portable Network Graphics (*.png)|*.png|All Files (*.*)|*.*";
            // 
            // timerGen
            // 
            this.timerGen.Interval = 200;
            this.timerGen.Tick += new System.EventHandler(this.timerGen_Tick);
            // 
            // dlgLoadJSON
            // 
            this.dlgLoadJSON.Filter = "JSON (*.json)|*.json|All Files (*.*)|*.*";
            this.dlgLoadJSON.Title = "Load JSON";
            // 
            // dlgSaveJSON
            // 
            this.dlgSaveJSON.Filter = "JSON (*.json)|*.json|All Files (*.*)|*.*";
            this.dlgSaveJSON.Title = "Save JSON";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(84, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(856, 25);
            this.miniToolStrip.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 733);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NFT Image Generator";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.RarityTable.ResumeLayout(false);
            this.RarityTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rarityTreeListView)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.Generate.ResumeLayout(false);
            this.Generate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputListView)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.Preview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewObjectListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddFolder;
        private System.Windows.Forms.ToolStripButton btnRemoveFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowse;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusInfo;
        private System.Windows.Forms.ImageList imlFolders;
        private System.Windows.Forms.ToolStripButton btnUp;
        private System.Windows.Forms.ToolStripButton btnDown;
        private System.Windows.Forms.ToolStripMenuItem mnuNewProject;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveProject;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenProject;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid pgProjLay;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.ToolStripButton btnAddFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog dlgAddFile;
        private System.Windows.Forms.Timer timerGen;
        private System.Windows.Forms.ToolStripProgressBar prg1;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectSettings;
        private System.Windows.Forms.OpenFileDialog dlgLoadJSON;
        private System.Windows.Forms.SaveFileDialog dlgSaveJSON;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Preview;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton btnZoomIn;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnPicOriginal;
        private System.Windows.Forms.TabPage RarityTable;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnReloadRarityTable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtTotalItems;
        private System.Windows.Forms.TabPage Generate;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnGenerate;
        private System.Windows.Forms.ToolStripButton btnGenerateCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblGenProgress;
        private System.Windows.Forms.ToolStripButton btnProjectSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtStartTokenID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ImageList imageList;
        private BrightIdeasSoftware.TreeListView rarityTreeListView;
        private BrightIdeasSoftware.OLVColumn TraitName;
        private BrightIdeasSoftware.OLVColumn RarityPercentage;
        private BrightIdeasSoftware.OLVColumn NumberOfOccurences;
        private BrightIdeasSoftware.ImageRenderer imageRenderer1;
        private BrightIdeasSoftware.OLVColumn TraitId;
        private BrightIdeasSoftware.ObjectListView outputListView;
        private BrightIdeasSoftware.OLVColumn tokenID;
        private BrightIdeasSoftware.OLVColumn rarityScore;
        private BrightIdeasSoftware.OLVColumn uniqueId;
        private BrightIdeasSoftware.OLVColumn hash;
        private BrightIdeasSoftware.OLVColumn metaAddress;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateMeta;
        private BrightIdeasSoftware.ObjectListView previewObjectListView;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn realm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}