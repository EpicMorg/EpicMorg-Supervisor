namespace EMSV.UI
{
    sealed partial class FrmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdd));
            this.bgxNull2 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtArgs = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblArgs = new System.Windows.Forms.Label();
            this.lblPathToExe = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.bgxNull1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.cmPriority = new System.Windows.Forms.ComboBox();
            this.chckHideOnStart = new System.Windows.Forms.CheckBox();
            this.chckReanimateProcess = new System.Windows.Forms.CheckBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.ofdPath = new System.Windows.Forms.OpenFileDialog();
            this.bgxNull2.SuspendLayout();
            this.bgxNull1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgxNull2
            // 
            this.bgxNull2.Controls.Add(this.btnBrowse);
            this.bgxNull2.Controls.Add(this.txtArgs);
            this.bgxNull2.Controls.Add(this.txtPath);
            this.bgxNull2.Controls.Add(this.lblArgs);
            this.bgxNull2.Controls.Add(this.lblPathToExe);
            this.bgxNull2.Location = new System.Drawing.Point(12, 118);
            this.bgxNull2.Name = "bgxNull2";
            this.bgxNull2.Size = new System.Drawing.Size(355, 161);
            this.bgxNull2.TabIndex = 0;
            this.bgxNull2.TabStop = false;
            this.bgxNull2.Text = "Properties:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(274, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtArgs
            // 
            this.txtArgs.Location = new System.Drawing.Point(6, 71);
            this.txtArgs.Multiline = true;
            this.txtArgs.Name = "txtArgs";
            this.txtArgs.Size = new System.Drawing.Size(343, 84);
            this.txtArgs.TabIndex = 0;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(6, 32);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(262, 20);
            this.txtPath.TabIndex = 0;
            // 
            // lblArgs
            // 
            this.lblArgs.AutoSize = true;
            this.lblArgs.Location = new System.Drawing.Point(6, 55);
            this.lblArgs.Name = "lblArgs";
            this.lblArgs.Size = new System.Drawing.Size(60, 13);
            this.lblArgs.TabIndex = 0;
            this.lblArgs.Text = "Agruments:";
            // 
            // lblPathToExe
            // 
            this.lblPathToExe.AutoSize = true;
            this.lblPathToExe.Location = new System.Drawing.Point(6, 16);
            this.lblPathToExe.Name = "lblPathToExe";
            this.lblPathToExe.Size = new System.Drawing.Size(99, 13);
            this.lblPathToExe.TabIndex = 0;
            this.lblPathToExe.Text = "Path to executable:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(292, 285);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // bgxNull1
            // 
            this.bgxNull1.Controls.Add(this.txtPassword);
            this.bgxNull1.Controls.Add(this.cmPriority);
            this.bgxNull1.Controls.Add(this.chckHideOnStart);
            this.bgxNull1.Controls.Add(this.chckReanimateProcess);
            this.bgxNull1.Controls.Add(this.lblPriority);
            this.bgxNull1.Controls.Add(this.lblPassword);
            this.bgxNull1.Controls.Add(this.lblItemName);
            this.bgxNull1.Controls.Add(this.txtItemName);
            this.bgxNull1.Location = new System.Drawing.Point(12, 12);
            this.bgxNull1.Name = "bgxNull1";
            this.bgxNull1.Size = new System.Drawing.Size(355, 100);
            this.bgxNull1.TabIndex = 1;
            this.bgxNull1.TabStop = false;
            this.bgxNull1.Text = "Options:";
            // 
            // txtPassword
            // 
            this.txtPassword.BeepOnError = true;
            this.txtPassword.Location = new System.Drawing.Point(6, 74);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(167, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // cmPriority
            // 
            this.cmPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmPriority.FormattingEnabled = true;
            this.cmPriority.Location = new System.Drawing.Point(179, 32);
            this.cmPriority.Name = "cmPriority";
            this.cmPriority.Size = new System.Drawing.Size(170, 21);
            this.cmPriority.TabIndex = 2;
            // 
            // chckHideOnStart
            // 
            this.chckHideOnStart.AutoSize = true;
            this.chckHideOnStart.Checked = true;
            this.chckHideOnStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckHideOnStart.Location = new System.Drawing.Point(179, 77);
            this.chckHideOnStart.Name = "chckHideOnStart";
            this.chckHideOnStart.Size = new System.Drawing.Size(133, 17);
            this.chckHideOnStart.TabIndex = 1;
            this.chckHideOnStart.Text = "Hide process (WinAPI)";
            this.chckHideOnStart.UseVisualStyleBackColor = true;
            // 
            // chckReanimateProcess
            // 
            this.chckReanimateProcess.AutoSize = true;
            this.chckReanimateProcess.Checked = true;
            this.chckReanimateProcess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckReanimateProcess.Location = new System.Drawing.Point(179, 59);
            this.chckReanimateProcess.Name = "chckReanimateProcess";
            this.chckReanimateProcess.Size = new System.Drawing.Size(156, 17);
            this.chckReanimateProcess.TabIndex = 1;
            this.chckReanimateProcess.Text = "Reanimate process if it died";
            this.chckReanimateProcess.UseVisualStyleBackColor = true;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(176, 16);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(81, 13);
            this.lblPriority.TabIndex = 0;
            this.lblPriority.Text = "Process priority:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 55);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Passphrase for HM:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(6, 16);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(59, 13);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(6, 32);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(167, 20);
            this.txtItemName.TabIndex = 0;
            // 
            // FrmAdd
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 320);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.bgxNull1);
            this.Controls.Add(this.bgxNull2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "name ver";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            this.bgxNull2.ResumeLayout(false);
            this.bgxNull2.PerformLayout();
            this.bgxNull1.ResumeLayout(false);
            this.bgxNull1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bgxNull2;
        private System.Windows.Forms.TextBox txtArgs;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblArgs;
        private System.Windows.Forms.Label lblPathToExe;
        private System.Windows.Forms.GroupBox bgxNull1;
        private System.Windows.Forms.ComboBox cmPriority;
        private System.Windows.Forms.CheckBox chckHideOnStart;
        private System.Windows.Forms.CheckBox chckReanimateProcess;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdPath;
    }
}