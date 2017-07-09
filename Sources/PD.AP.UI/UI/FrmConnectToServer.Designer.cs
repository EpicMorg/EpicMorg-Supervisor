namespace EMSV.UI
{
    sealed partial class FrmStartHm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStartHm));
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblPl = new System.Windows.Forms.Label();
            this.lblSl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(236, 125);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Start";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.lblPl);
            this.groupBox1.Controls.Add(this.lblSl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(7, 33);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(286, 20);
            this.txtServer.TabIndex = 4;
            this.txtServer.Text = "http://192.168.0.106:31337";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(6, 71);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '卐';
            this.txtKey.Size = new System.Drawing.Size(287, 20);
            this.txtKey.TabIndex = 3;
            this.txtKey.Text = "12345";
            // 
            // lblPl
            // 
            this.lblPl.AutoSize = true;
            this.lblPl.Location = new System.Drawing.Point(6, 55);
            this.lblPl.Name = "lblPl";
            this.lblPl.Size = new System.Drawing.Size(65, 13);
            this.lblPl.TabIndex = 1;
            this.lblPl.Text = "Passphrase:";
            // 
            // lblSl
            // 
            this.lblSl.AutoSize = true;
            this.lblSl.Location = new System.Drawing.Point(6, 16);
            this.lblSl.Name = "lblSl";
            this.lblSl.Size = new System.Drawing.Size(81, 13);
            this.lblSl.TabIndex = 1;
            this.lblSl.Text = "Server address:";
            // 
            // FrmStartHm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 160);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStartHm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "name + ver";
            this.Load += new System.EventHandler(this.FrmStartHm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblPl;
        private System.Windows.Forms.Label lblSl;
        private System.Windows.Forms.TextBox txtServer;
    }
}