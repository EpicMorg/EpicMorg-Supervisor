namespace EMSV.CL.UI.UI
{
    partial class FrmMain
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
                _notifyIcon.Dispose();
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
            this.tabItems = new System.Windows.Forms.TabPage();
            this.dgvProcessList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDemonizedProcessBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.smenuStartMonitorServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.английскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.smenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.smenuLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.smenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.cmProcess = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmUnlock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.unlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDemonizedProcessBaseBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.cmProcess.SuspendLayout();
            this.cmUnlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabItems
            // 
            this.tabItems.Controls.Add(this.dgvProcessList);
            this.tabItems.ImageKey = "database_yellow.png";
            this.tabItems.Location = new System.Drawing.Point(4, 23);
            this.tabItems.Name = "tabItems";
            this.tabItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabItems.Size = new System.Drawing.Size(864, 436);
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
            this.nameDataGridViewTextBoxColumn});
            this.dgvProcessList.DataSource = this.iDemonizedProcessBaseBindingSource;
            this.dgvProcessList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcessList.Location = new System.Drawing.Point(3, 3);
            this.dgvProcessList.Name = "dgvProcessList";
            this.dgvProcessList.ReadOnly = true;
            this.dgvProcessList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcessList.Size = new System.Drawing.Size(858, 430);
            this.dgvProcessList.TabIndex = 0;
            this.dgvProcessList.DataSourceChanged += new System.EventHandler(this.dgvProcessList_DataSourceChanged_1);
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
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDemonizedProcessBaseBindingSource
            // 
            this.iDemonizedProcessBaseBindingSource.DataSource = typeof(EMSV.Api.DataTypes.IDemonizedProcessBase);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabItems);
            this.tabControl.ImageList = this.imageListMain;
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.MinimumSize = new System.Drawing.Size(480, 240);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(872, 463);
            this.tabControl.TabIndex = 6;
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(896, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip";
            // 
            // _notifyIcon
            // 
            this._notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("_notifyIcon.Icon")));
            this._notifyIcon.Visible = true;
            this._notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this._notifyIcon_MouseClick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(896, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuFile
            // 
            this.menuFile.BackColor = System.Drawing.SystemColors.Control;
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smenuStartMonitorServer,
            this.toolStripSeparator1,
            this.languageToolStripMenuItem,
            this.toolStripSeparator2,
            this.smenuExit});
            this.menuFile.Image = global::EMSV.CL.UI.Properties.Resources.page_header_footer;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(64, 20);
            this.menuFile.Text = "Файл";
            // 
            // smenuStartMonitorServer
            // 
            this.smenuStartMonitorServer.Image = global::EMSV.CL.UI.Properties.Resources.world_connect;
            this.smenuStartMonitorServer.Name = "smenuStartMonitorServer";
            this.smenuStartMonitorServer.Size = new System.Drawing.Size(156, 22);
            this.smenuStartMonitorServer.Text = "Подключиться";
            this.smenuStartMonitorServer.Click += new System.EventHandler(this.smenuStartMonitorServer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.английскийToolStripMenuItem,
            this.russianToolStripMenuItem});
            this.languageToolStripMenuItem.Image = global::EMSV.CL.UI.Properties.Resources.text_complete;
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.languageToolStripMenuItem.Text = "Язык";
            // 
            // английскийToolStripMenuItem
            // 
            this.английскийToolStripMenuItem.Image = global::EMSV.CL.UI.Properties.Resources.united_kingdom;
            this.английскийToolStripMenuItem.Name = "английскийToolStripMenuItem";
            this.английскийToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.английскийToolStripMenuItem.Text = "Английский";
            this.английскийToolStripMenuItem.Click += new System.EventHandler(this.английскийToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.Image = global::EMSV.CL.UI.Properties.Resources.russia;
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.russianToolStripMenuItem.Text = "Русский";
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.russianToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // smenuExit
            // 
            this.smenuExit.Image = global::EMSV.CL.UI.Properties.Resources.bullet_cross;
            this.smenuExit.Name = "smenuExit";
            this.smenuExit.Size = new System.Drawing.Size(156, 22);
            this.smenuExit.Text = "Выход";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smenuLicense,
            this.toolStripSeparator3,
            this.smenuAbout});
            this.menuHelp.Image = global::EMSV.CL.UI.Properties.Resources.shield_rainbow;
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(60, 20);
            this.menuHelp.Text = "Help";
            // 
            // smenuLicense
            // 
            this.smenuLicense.Image = global::EMSV.CL.UI.Properties.Resources.rainbow_star;
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
            this.smenuAbout.Image = global::EMSV.CL.UI.Properties.Resources.user_gray_cool;
            this.smenuAbout.Name = "smenuAbout";
            this.smenuAbout.Size = new System.Drawing.Size(152, 22);
            this.smenuAbout.Text = "About";
            this.smenuAbout.Click += new System.EventHandler(this.smenuAbout_Click);
            // 
            // cmProcess
            // 
            this.cmProcess.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripSeparator4,
            this.infoToolStripMenuItem});
            this.cmProcess.Name = "cmProcess";
            this.cmProcess.Size = new System.Drawing.Size(111, 98);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Image = global::EMSV.CL.UI.Properties.Resources.play_green;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Image = global::EMSV.CL.UI.Properties.Resources.reload;
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = global::EMSV.CL.UI.Properties.Resources.stop_red;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(107, 6);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = global::EMSV.CL.UI.Properties.Resources.eyes;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // cmUnlock
            // 
            this.cmUnlock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unlockToolStripMenuItem});
            this.cmUnlock.Name = "cmUnlock";
            this.cmUnlock.Size = new System.Drawing.Size(112, 26);
            // 
            // unlockToolStripMenuItem
            // 
            this.unlockToolStripMenuItem.Image = global::EMSV.CL.UI.Properties.Resources.lock_key;
            this.unlockToolStripMenuItem.Name = "unlockToolStripMenuItem";
            this.unlockToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.unlockToolStripMenuItem.Text = "Unlock";
            this.unlockToolStripMenuItem.Click += new System.EventHandler(this.unlockToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 515);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 240);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "name + vers";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FormForTray_Resize);
            this.tabItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDemonizedProcessBaseBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.cmProcess.ResumeLayout(false);
            this.cmUnlock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabItems;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.NotifyIcon _notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem smenuAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem smenuLicense;
        private System.Windows.Forms.ToolStripMenuItem smenuExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem smenuStartMonitorServer;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.BindingSource iDemonizedProcessBaseBindingSource;
        private System.Windows.Forms.ContextMenuStrip cmProcess;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmUnlock;
        private System.Windows.Forms.ToolStripMenuItem unlockToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvProcessList;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem английскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ImageList imageListMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

