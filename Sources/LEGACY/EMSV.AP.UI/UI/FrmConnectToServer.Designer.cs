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
            this.ipAddressText = new IPAddressControlLib.IPAddressControl();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblPl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSl = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(6, 97);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(243, 30);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Connect";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.ipAddressText);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.lblPl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection info:";
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
            this.ipAddressText.TabIndex = 5;
            this.ipAddressText.Text = "127.0.0.1";
            this.ipAddressText.TextChanged += new System.EventHandler(this.ipAddressText_TextChanged);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(6, 71);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '*';
            this.txtKey.Size = new System.Drawing.Size(243, 20);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // lblSl
            // 
            this.lblSl.AutoSize = true;
            this.lblSl.Location = new System.Drawing.Point(6, 16);
            this.lblSl.Name = "lblSl";
            this.lblSl.Size = new System.Drawing.Size(20, 13);
            this.lblSl.TabIndex = 1;
            this.lblSl.Text = "IP:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(174, 32);
            this.txtServer.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(75, 20);
            this.txtServer.TabIndex = 7;
            this.txtServer.Value = new decimal(new int[] {
            31337,
            0,
            0,
            0});
            // 
            // FrmStartHm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 157);
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtServer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblPl;
        private System.Windows.Forms.Label lblSl;
        private System.Windows.Forms.Label label1;
        public IPAddressControlLib.IPAddressControl ipAddressText;
        private System.Windows.Forms.NumericUpDown txtServer;
    }
}