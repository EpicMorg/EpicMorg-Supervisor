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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.smenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.smenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.smenuLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.smenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.smenuStartMonitorServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.английскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cmProcess = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmUnlock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.unlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDemonizedProcessBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessList)).BeginInit();
            this.tabControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.cmProcess.SuspendLayout();
            this.cmUnlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iDemonizedProcessBaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabItems
            // 
            resources.ApplyResources(this.tabItems, "tabItems");
            this.tabItems.Controls.Add(this.dgvProcessList);
            this.tabItems.Name = "tabItems";
            this.tabItems.UseVisualStyleBackColor = true;
            // 
            // dgvProcessList
            // 
            resources.ApplyResources(this.dgvProcessList, "dgvProcessList");
            this.dgvProcessList.AllowUserToAddRows = false;
            this.dgvProcessList.AllowUserToDeleteRows = false;
            this.dgvProcessList.AutoGenerateColumns = false;
            this.dgvProcessList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcessList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgvProcessList.DataSource = this.iDemonizedProcessBaseBindingSource;
            this.dgvProcessList.Name = "dgvProcessList";
            this.dgvProcessList.ReadOnly = true;
            this.dgvProcessList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcessList.DataSourceChanged += new System.EventHandler(this.dgvProcessList_DataSourceChanged_1);
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabItems);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // _notifyIcon
            // 
            resources.ApplyResources(this._notifyIcon, "_notifyIcon");
            this._notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this._notifyIcon_MouseClick);
            // 
            // smenuAbout
            // 
            resources.ApplyResources(this.smenuAbout, "smenuAbout");
            this.smenuAbout.Name = "smenuAbout";
            this.smenuAbout.Click += new System.EventHandler(this.smenuAbout_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // smenuHelp
            // 
            resources.ApplyResources(this.smenuHelp, "smenuHelp");
            this.smenuHelp.Name = "smenuHelp";
            // 
            // menuHelp
            // 
            resources.ApplyResources(this.menuHelp, "menuHelp");
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smenuHelp,
            this.smenuLicense,
            this.toolStripSeparator3,
            this.smenuAbout});
            this.menuHelp.Name = "menuHelp";
            // 
            // smenuLicense
            // 
            resources.ApplyResources(this.smenuLicense, "smenuLicense");
            this.smenuLicense.Name = "smenuLicense";
            this.smenuLicense.Click += new System.EventHandler(this.smenuLicense_Click);
            // 
            // smenuExit
            // 
            resources.ApplyResources(this.smenuExit, "smenuExit");
            this.smenuExit.Name = "smenuExit";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // smenuStartMonitorServer
            // 
            resources.ApplyResources(this.smenuStartMonitorServer, "smenuStartMonitorServer");
            this.smenuStartMonitorServer.Name = "smenuStartMonitorServer";
            this.smenuStartMonitorServer.Click += new System.EventHandler(this.smenuStartMonitorServer_Click);
            // 
            // menuFile
            // 
            resources.ApplyResources(this.menuFile, "menuFile");
            this.menuFile.BackColor = System.Drawing.SystemColors.Control;
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smenuStartMonitorServer,
            this.toolStripSeparator1,
            this.smenuExit,
            this.languageToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.английскийToolStripMenuItem,
            this.russianToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // английскийToolStripMenuItem
            // 
            resources.ApplyResources(this.английскийToolStripMenuItem, "английскийToolStripMenuItem");
            this.английскийToolStripMenuItem.Name = "английскийToolStripMenuItem";
            this.английскийToolStripMenuItem.Click += new System.EventHandler(this.английскийToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem
            // 
            resources.ApplyResources(this.russianToolStripMenuItem, "russianToolStripMenuItem");
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.russianToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // cmProcess
            // 
            resources.ApplyResources(this.cmProcess, "cmProcess");
            this.cmProcess.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.cmProcess.Name = "cmProcess";
            // 
            // startToolStripMenuItem
            // 
            resources.ApplyResources(this.startToolStripMenuItem, "startToolStripMenuItem");
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            resources.ApplyResources(this.restartToolStripMenuItem, "restartToolStripMenuItem");
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            resources.ApplyResources(this.stopToolStripMenuItem, "stopToolStripMenuItem");
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // cmUnlock
            // 
            resources.ApplyResources(this.cmUnlock, "cmUnlock");
            this.cmUnlock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unlockToolStripMenuItem});
            this.cmUnlock.Name = "cmUnlock";
            // 
            // unlockToolStripMenuItem
            // 
            resources.ApplyResources(this.unlockToolStripMenuItem, "unlockToolStripMenuItem");
            this.unlockToolStripMenuItem.Name = "unlockToolStripMenuItem";
            this.unlockToolStripMenuItem.Click += new System.EventHandler(this.unlockToolStripMenuItem_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDemonizedProcessBaseBindingSource
            // 
            this.iDemonizedProcessBaseBindingSource.DataSource = typeof(EMSV.Api.DataTypes.IDemonizedProcessBase);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FormForTray_Resize);
            this.tabItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessList)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmProcess.ResumeLayout(false);
            this.cmUnlock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iDemonizedProcessBaseBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem smenuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem smenuLicense;
        private System.Windows.Forms.ToolStripMenuItem smenuExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem smenuStartMonitorServer;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
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
    }
}

