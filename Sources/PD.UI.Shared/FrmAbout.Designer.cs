using PD.UI.Shared.Properties;

namespace process_demonizator.UI
{
    sealed partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtProgName = new System.Windows.Forms.Label();
            this.txtVer = new System.Windows.Forms.Label();
            this.txtProgCopy = new System.Windows.Forms.Label();
            this.lnkHP = new System.Windows.Forms.LinkLabel();
            this.lnkGH = new System.Windows.Forms.LinkLabel();
            this.lblLib = new System.Windows.Forms.LinkLabel();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = Resources.gksu_root_terminal;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(48, 48);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // txtProgName
            // 
            this.txtProgName.AutoSize = true;
            this.txtProgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProgName.Location = new System.Drawing.Point(66, 14);
            this.txtProgName.Name = "txtProgName";
            this.txtProgName.Size = new System.Drawing.Size(82, 16);
            this.txtProgName.TabIndex = 1;
            this.txtProgName.Text = "ProgName";
            // 
            // txtVer
            // 
            this.txtVer.AutoSize = true;
            this.txtVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtVer.Location = new System.Drawing.Point(237, 30);
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(51, 15);
            this.txtVer.TabIndex = 1;
            this.txtVer.Text = "ProgVer";
            // 
            // txtProgCopy
            // 
            this.txtProgCopy.AutoSize = true;
            this.txtProgCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProgCopy.Location = new System.Drawing.Point(66, 30);
            this.txtProgCopy.Name = "txtProgCopy";
            this.txtProgCopy.Size = new System.Drawing.Size(60, 15);
            this.txtProgCopy.TabIndex = 1;
            this.txtProgCopy.Text = "ProgCopy";
            // 
            // lnkHP
            // 
            this.lnkHP.AutoSize = true;
            this.lnkHP.Location = new System.Drawing.Point(9, 69);
            this.lnkHP.Name = "lnkHP";
            this.lnkHP.Size = new System.Drawing.Size(60, 13);
            this.lnkHP.TabIndex = 2;
            this.lnkHP.TabStop = true;
            this.lnkHP.Text = "HomePage";
            this.lnkHP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnkGH
            // 
            this.lnkGH.AutoSize = true;
            this.lnkGH.Location = new System.Drawing.Point(75, 69);
            this.lnkGH.Name = "lnkGH";
            this.lnkGH.Size = new System.Drawing.Size(40, 13);
            this.lnkGH.TabIndex = 2;
            this.lnkGH.TabStop = true;
            this.lnkGH.Text = "GitHub";
            this.lnkGH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lblLib
            // 
            this.lblLib.AutoSize = true;
            this.lblLib.Location = new System.Drawing.Point(121, 69);
            this.lblLib.Name = "lblLib";
            this.lblLib.Size = new System.Drawing.Size(94, 13);
            this.lblLib.TabIndex = 3;
            this.lblLib.TabStop = true;
            this.lblLib.Text = "ipaddresscontrollib";
            this.lblLib.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(240, 59);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 100);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblLib);
            this.Controls.Add(this.lnkGH);
            this.Controls.Add(this.lnkHP);
            this.Controls.Add(this.txtProgCopy);
            this.Controls.Add(this.txtVer);
            this.Controls.Add(this.txtProgName);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "name ver";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label txtProgName;
        private System.Windows.Forms.Label txtVer;
        private System.Windows.Forms.Label txtProgCopy;
        private System.Windows.Forms.LinkLabel lnkHP;
        private System.Windows.Forms.LinkLabel lnkGH;
        private System.Windows.Forms.LinkLabel lblLib;
        private System.Windows.Forms.Button btnOK;
    }
}