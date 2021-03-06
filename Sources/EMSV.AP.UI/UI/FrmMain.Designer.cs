﻿namespace EMSV.UI
{
    sealed partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.smenuAddNewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.smenuStartMonitorServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.smenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smenuSettions = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инглишToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.smenuLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.smenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.dgvProcessList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restartsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPriorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.argumentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hideOnStartDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.autorestartDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmProcess = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runningDemonizedProcessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessList)).BeginInit();
            this.cmProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runningDemonizedProcessBindingSource)).BeginInit();
            this.tabLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1096, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.BackColor = System.Drawing.SystemColors.Control;
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smenuAddNewItem,
            this.toolStripSeparator2,
            this.smenuStartMonitorServer,
            this.toolStripSeparator1,
            this.smenuExit});
            this.menuFile.Image = global::EMSV.AP.Properties.Resources.page_header_footer;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(53, 20);
            this.menuFile.Text = "File";
            // 
            // smenuAddNewItem
            // 
            this.smenuAddNewItem.Enabled = false;
            this.smenuAddNewItem.Image = global::EMSV.AP.Properties.Resources.rainbow_star;
            this.smenuAddNewItem.Name = "smenuAddNewItem";
            this.smenuAddNewItem.Size = new System.Drawing.Size(170, 22);
            this.smenuAddNewItem.Text = "Add new item";
            this.smenuAddNewItem.Click += new System.EventHandler(this.smenuAddNewItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // smenuStartMonitorServer
            // 
            this.smenuStartMonitorServer.Image = global::EMSV.AP.Properties.Resources.house_connect;
            this.smenuStartMonitorServer.Name = "smenuStartMonitorServer";
            this.smenuStartMonitorServer.Size = new System.Drawing.Size(170, 22);
            this.smenuStartMonitorServer.Text = "Connect to  server";
            this.smenuStartMonitorServer.Click += new System.EventHandler(this.smenuStartMonitorServer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // smenuExit
            // 
            this.smenuExit.Image = global::EMSV.AP.Properties.Resources.bullet_cross;
            this.smenuExit.Name = "smenuExit";
            this.smenuExit.Size = new System.Drawing.Size(170, 22);
            this.smenuExit.Text = "Exit";
            this.smenuExit.Click += new System.EventHandler(this.smenuExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.smenuSettions,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator4,
            this.languageToolStripMenuItem});
            this.menuEdit.Image = global::EMSV.AP.Properties.Resources.border_draw;
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(55, 20);
            this.menuEdit.Text = "Edit";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Enabled = false;
            this.refreshToolStripMenuItem.Image = global::EMSV.AP.Properties.Resources.reload;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // smenuSettions
            // 
            this.smenuSettions.Enabled = false;
            this.smenuSettions.Image = global::EMSV.AP.Properties.Resources.cog_start;
            this.smenuSettions.Name = "smenuSettions";
            this.smenuSettions.Size = new System.Drawing.Size(168, 22);
            this.smenuSettions.Text = "Server settings";
            this.smenuSettions.Click += new System.EventHandler(this.smenuSettions_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Enabled = false;
            this.changePasswordToolStripMenuItem.Image = global::EMSV.AP.Properties.Resources.key_start;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(165, 6);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инглишToolStripMenuItem,
            this.russianToolStripMenuItem});
            this.languageToolStripMenuItem.Image = global::EMSV.AP.Properties.Resources.text_complete;
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // инглишToolStripMenuItem
            // 
            this.инглишToolStripMenuItem.Image = global::EMSV.AP.Properties.Resources.united_kingdom;
            this.инглишToolStripMenuItem.Name = "инглишToolStripMenuItem";
            this.инглишToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.инглишToolStripMenuItem.Text = "English";
            this.инглишToolStripMenuItem.Click += new System.EventHandler(this.АнглийскийToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.Image = global::EMSV.AP.Properties.Resources.russia;
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.russianToolStripMenuItem.Text = "Russian";
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.russianToolStripMenuItem_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smenuLicense,
            this.toolStripSeparator3,
            this.smenuAbout});
            this.menuHelp.Image = global::EMSV.AP.Properties.Resources.shield_rainbow;
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(60, 20);
            this.menuHelp.Text = "Help";
            // 
            // smenuLicense
            // 
            this.smenuLicense.Image = global::EMSV.AP.Properties.Resources.rainbow_star;
            this.smenuLicense.Name = "smenuLicense";
            this.smenuLicense.Size = new System.Drawing.Size(152, 22);
            this.smenuLicense.Text = "License";
            this.smenuLicense.Click += new System.EventHandler(this.smenuLicense_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // smenuAbout
            // 
            this.smenuAbout.Image = global::EMSV.AP.Properties.Resources.user_gray_cool;
            this.smenuAbout.Name = "smenuAbout";
            this.smenuAbout.Size = new System.Drawing.Size(152, 22);
            this.smenuAbout.Text = "About";
            this.smenuAbout.Click += new System.EventHandler(this.smenuAbout_Click);
            // 
            // _notifyIcon
            // 
            this._notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("_notifyIcon.Icon")));
            this._notifyIcon.Visible = true;
            this._notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this._notifyIcon_MouseClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusServer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1096, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Tag = "Disconnected";
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusServer
            // 
            this.statusServer.Name = "statusServer";
            this.statusServer.Size = new System.Drawing.Size(79, 17);
            this.statusServer.Text = "Disconnected";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabItems);
            this.tabControl.Controls.Add(this.tabLogs);
            this.tabControl.Enabled = false;
            this.tabControl.ImageList = this.imageListMain;
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1072, 483);
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabItems
            // 
            this.tabItems.Controls.Add(this.dgvProcessList);
            this.tabItems.ImageKey = "database_yellow.png";
            this.tabItems.Location = new System.Drawing.Point(4, 23);
            this.tabItems.Name = "tabItems";
            this.tabItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabItems.Size = new System.Drawing.Size(1064, 456);
            this.tabItems.TabIndex = 0;
            this.tabItems.Text = "Items";
            this.tabItems.UseVisualStyleBackColor = true;
            // 
            // dgvProcessList
            // 
            this.dgvProcessList.AllowUserToAddRows = false;
            this.dgvProcessList.AllowUserToDeleteRows = false;
            this.dgvProcessList.AutoGenerateColumns = false;
            this.dgvProcessList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcessList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.restartsDataGridViewTextBoxColumn,
            this.currentPriorityDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn,
            this.argumentsDataGridViewTextBoxColumn,
            this.hideOnStartDataGridViewCheckBoxColumn,
            this.autorestartDataGridViewCheckBoxColumn,
            this.priorityDataGridViewTextBoxColumn});
            this.dgvProcessList.ContextMenuStrip = this.cmProcess;
            this.dgvProcessList.DataSource = this.runningDemonizedProcessBindingSource;
            this.dgvProcessList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcessList.Location = new System.Drawing.Point(3, 3);
            this.dgvProcessList.Name = "dgvProcessList";
            this.dgvProcessList.ReadOnly = true;
            this.dgvProcessList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcessList.Size = new System.Drawing.Size(1058, 450);
            this.dgvProcessList.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // restartsDataGridViewTextBoxColumn
            // 
            this.restartsDataGridViewTextBoxColumn.DataPropertyName = "Restarts";
            this.restartsDataGridViewTextBoxColumn.HeaderText = "Restarts";
            this.restartsDataGridViewTextBoxColumn.Name = "restartsDataGridViewTextBoxColumn";
            this.restartsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentPriorityDataGridViewTextBoxColumn
            // 
            this.currentPriorityDataGridViewTextBoxColumn.DataPropertyName = "CurrentPriority";
            this.currentPriorityDataGridViewTextBoxColumn.HeaderText = "CurrentPriority";
            this.currentPriorityDataGridViewTextBoxColumn.Name = "currentPriorityDataGridViewTextBoxColumn";
            this.currentPriorityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // argumentsDataGridViewTextBoxColumn
            // 
            this.argumentsDataGridViewTextBoxColumn.DataPropertyName = "Arguments";
            this.argumentsDataGridViewTextBoxColumn.HeaderText = "Arguments";
            this.argumentsDataGridViewTextBoxColumn.Name = "argumentsDataGridViewTextBoxColumn";
            this.argumentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hideOnStartDataGridViewCheckBoxColumn
            // 
            this.hideOnStartDataGridViewCheckBoxColumn.DataPropertyName = "HideOnStart";
            this.hideOnStartDataGridViewCheckBoxColumn.HeaderText = "HideOnStart";
            this.hideOnStartDataGridViewCheckBoxColumn.Name = "hideOnStartDataGridViewCheckBoxColumn";
            this.hideOnStartDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // autorestartDataGridViewCheckBoxColumn
            // 
            this.autorestartDataGridViewCheckBoxColumn.DataPropertyName = "Autorestart";
            this.autorestartDataGridViewCheckBoxColumn.HeaderText = "Autorestart";
            this.autorestartDataGridViewCheckBoxColumn.Name = "autorestartDataGridViewCheckBoxColumn";
            this.autorestartDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmProcess
            // 
            this.cmProcess.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripSeparator5,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator6,
            this.windowToolStripMenuItem});
            this.cmProcess.Name = "cmProcess";
            this.cmProcess.Size = new System.Drawing.Size(119, 148);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Image = global::EMSV.AP.Properties.Resources.play_green;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Image = global::EMSV.AP.Properties.Resources.reload;
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = global::EMSV.AP.Properties.Resources.stop_red;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(115, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::EMSV.AP.Properties.Resources.border_draw;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::EMSV.AP.Properties.Resources.bullet_cross;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(115, 6);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem});
            this.windowToolStripMenuItem.Image = global::EMSV.AP.Properties.Resources.application_osx_lightning;
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = global::EMSV.AP.Properties.Resources.application_osx_add;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Image = global::EMSV.AP.Properties.Resources.application_osx_delete;
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // runningDemonizedProcessBindingSource
            // 
            this.runningDemonizedProcessBindingSource.DataSource = typeof(EMSV.Api.DataTypes.RunningDemonizedProcess);
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.txtLogs);
            this.tabLogs.ImageKey = "page_header_footer.png";
            this.tabLogs.Location = new System.Drawing.Point(4, 23);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(1064, 456);
            this.tabLogs.TabIndex = 1;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // txtLogs
            // 
            this.txtLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogs.Location = new System.Drawing.Point(6, 6);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(1052, 444);
            this.txtLogs.TabIndex = 0;
            // 
            // imageListMain
            // 
            this.imageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMain.ImageStream")));
            this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMain.Images.SetKeyName(0, "database_yellow.png");
            this.imageListMain.Images.SetKeyName(1, "arrow_switch_bluegreen.png");
            this.imageListMain.Images.SetKeyName(2, "page_header_footer.png");
            this.imageListMain.Images.SetKeyName(3, "rainbow_star.png");
            this.imageListMain.Images.SetKeyName(4, "text_complete.png");
            this.imageListMain.Images.SetKeyName(5, "arrow_switch_bluegreen.png");
            this.imageListMain.Images.SetKeyName(6, "bullet_cross.png");
            this.imageListMain.Images.SetKeyName(7, "font_color.png");
            this.imageListMain.Images.SetKeyName(8, "house_connect.png");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 535);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(480, 240);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "name + ver";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyUp);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessList)).EndInit();
            this.cmProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.runningDemonizedProcessBindingSource)).EndInit();
            this.tabLogs.ResumeLayout(false);
            this.tabLogs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem smenuExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem smenuSettions;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem smenuAbout;
        private System.Windows.Forms.NotifyIcon _notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem smenuStartMonitorServer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem smenuAddNewItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabItems;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem smenuLicense;
        private System.Windows.Forms.DataGridView dgvProcessList;
        private System.Windows.Forms.BindingSource runningDemonizedProcessBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentPriorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn argumentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hideOnStartDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autorestartDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cmProcess;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инглишToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusServer;
        private System.Windows.Forms.ImageList imageListMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}

