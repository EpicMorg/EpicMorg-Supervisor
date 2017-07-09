namespace EMSV.UI
{
    sealed partial class frmConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnect));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.ipAddressText = new IPAddressControlLib.IPAddressControl();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(6, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ipAddressText);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSl);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection info:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(174, 32);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(75, 20);
            this.txtServer.TabIndex = 4;
            this.txtServer.Text = "31337";
            // 
            // ipAddressText
            // 
            this.ipAddressText.AllowInternalTab = false;
            this.ipAddressText.AutoHeight = true;
            this.ipAddressText.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressText.Location = new System.Drawing.Point(6, 32);
            this.ipAddressText.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipAddressText.Name = "ipAddressText";
            this.ipAddressText.ReadOnly = false;
            this.ipAddressText.Size = new System.Drawing.Size(162, 20);
            this.ipAddressText.TabIndex = 9;
            this.ipAddressText.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port:";
            // 
            // lblSl
            // 
            this.lblSl.AutoSize = true;
            this.lblSl.Location = new System.Drawing.Point(6, 16);
            this.lblSl.Name = "lblSl";
            this.lblSl.Size = new System.Drawing.Size(20, 13);
            this.lblSl.TabIndex = 7;
            this.lblSl.Text = "IP:";
            // 
            // frmConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 119);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConnect";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "name + ver";
            this.Load += new System.EventHandler(this.frmConnect_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtServer;
        public IPAddressControlLib.IPAddressControl ipAddressText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSl;
    }
}