namespace EMSV.CL.UI.UI
{
    partial class frmProcessInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcessInfo));
            this.lblIdl = new System.Windows.Forms.Label();
            this.lblNl = new System.Windows.Forms.Label();
            this.lblFl = new System.Windows.Forms.Label();
            this.lblAl = new System.Windows.Forms.Label();
            this.lblSl = new System.Windows.Forms.Label();
            this.lblDPl = new System.Windows.Forms.Label();
            this.lblCPl = new System.Windows.Forms.Label();
            this.lblRl = new System.Windows.Forms.Label();
            this.lblARl = new System.Windows.Forms.Label();
            this.lblHOSl = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.checkAutoRestart = new System.Windows.Forms.CheckBox();
            this.checkHide = new System.Windows.Forms.CheckBox();
            this.txtRestarts = new System.Windows.Forms.TextBox();
            this.txtCurrentPriority = new System.Windows.Forms.TextBox();
            this.txtDefaultPriority = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdl
            // 
            this.lblIdl.AutoSize = true;
            this.lblIdl.Location = new System.Drawing.Point(6, 22);
            this.lblIdl.Name = "lblIdl";
            this.lblIdl.Size = new System.Drawing.Size(18, 13);
            this.lblIdl.TabIndex = 0;
            this.lblIdl.Text = "ID";
            // 
            // lblNl
            // 
            this.lblNl.AutoSize = true;
            this.lblNl.Location = new System.Drawing.Point(6, 48);
            this.lblNl.Name = "lblNl";
            this.lblNl.Size = new System.Drawing.Size(35, 13);
            this.lblNl.TabIndex = 1;
            this.lblNl.Text = "Name";
            // 
            // lblFl
            // 
            this.lblFl.AutoSize = true;
            this.lblFl.Location = new System.Drawing.Point(6, 74);
            this.lblFl.Name = "lblFl";
            this.lblFl.Size = new System.Drawing.Size(23, 13);
            this.lblFl.TabIndex = 2;
            this.lblFl.Text = "File";
            // 
            // lblAl
            // 
            this.lblAl.AutoSize = true;
            this.lblAl.Location = new System.Drawing.Point(6, 100);
            this.lblAl.Name = "lblAl";
            this.lblAl.Size = new System.Drawing.Size(57, 13);
            this.lblAl.TabIndex = 3;
            this.lblAl.Text = "Arguments";
            // 
            // lblSl
            // 
            this.lblSl.AutoSize = true;
            this.lblSl.Location = new System.Drawing.Point(6, 126);
            this.lblSl.Name = "lblSl";
            this.lblSl.Size = new System.Drawing.Size(37, 13);
            this.lblSl.TabIndex = 4;
            this.lblSl.Text = "Status";
            // 
            // lblDPl
            // 
            this.lblDPl.AutoSize = true;
            this.lblDPl.Location = new System.Drawing.Point(6, 152);
            this.lblDPl.Name = "lblDPl";
            this.lblDPl.Size = new System.Drawing.Size(75, 13);
            this.lblDPl.TabIndex = 5;
            this.lblDPl.Text = "Default Priority";
            // 
            // lblCPl
            // 
            this.lblCPl.AutoSize = true;
            this.lblCPl.Location = new System.Drawing.Point(6, 178);
            this.lblCPl.Name = "lblCPl";
            this.lblCPl.Size = new System.Drawing.Size(75, 13);
            this.lblCPl.TabIndex = 6;
            this.lblCPl.Text = "Current Priority";
            // 
            // lblRl
            // 
            this.lblRl.AutoSize = true;
            this.lblRl.Location = new System.Drawing.Point(6, 204);
            this.lblRl.Name = "lblRl";
            this.lblRl.Size = new System.Drawing.Size(46, 13);
            this.lblRl.TabIndex = 14;
            this.lblRl.Text = "Restarts";
            // 
            // lblARl
            // 
            this.lblARl.AutoSize = true;
            this.lblARl.Location = new System.Drawing.Point(6, 228);
            this.lblARl.Name = "lblARl";
            this.lblARl.Size = new System.Drawing.Size(63, 13);
            this.lblARl.TabIndex = 15;
            this.lblARl.Text = "AutoRestart";
            // 
            // lblHOSl
            // 
            this.lblHOSl.AutoSize = true;
            this.lblHOSl.Location = new System.Drawing.Point(6, 251);
            this.lblHOSl.Name = "lblHOSl";
            this.lblHOSl.Size = new System.Drawing.Size(67, 13);
            this.lblHOSl.TabIndex = 16;
            this.lblHOSl.Text = "Hide on start";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.checkAutoRestart);
            this.groupBox.Controls.Add(this.checkHide);
            this.groupBox.Controls.Add(this.txtRestarts);
            this.groupBox.Controls.Add(this.txtCurrentPriority);
            this.groupBox.Controls.Add(this.txtDefaultPriority);
            this.groupBox.Controls.Add(this.txtStatus);
            this.groupBox.Controls.Add(this.txtArguments);
            this.groupBox.Controls.Add(this.txtFile);
            this.groupBox.Controls.Add(this.txtName);
            this.groupBox.Controls.Add(this.txtId);
            this.groupBox.Controls.Add(this.lblIdl);
            this.groupBox.Controls.Add(this.lblNl);
            this.groupBox.Controls.Add(this.lblFl);
            this.groupBox.Controls.Add(this.lblHOSl);
            this.groupBox.Controls.Add(this.lblAl);
            this.groupBox.Controls.Add(this.lblARl);
            this.groupBox.Controls.Add(this.lblSl);
            this.groupBox.Controls.Add(this.lblRl);
            this.groupBox.Controls.Add(this.lblDPl);
            this.groupBox.Controls.Add(this.lblCPl);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(302, 282);
            this.groupBox.TabIndex = 20;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Info:";
            // 
            // checkAutoRestart
            // 
            this.checkAutoRestart.AutoSize = true;
            this.checkAutoRestart.Enabled = false;
            this.checkAutoRestart.Location = new System.Drawing.Point(104, 227);
            this.checkAutoRestart.Name = "checkAutoRestart";
            this.checkAutoRestart.Size = new System.Drawing.Size(51, 17);
            this.checkAutoRestart.TabIndex = 21;
            this.checkAutoRestart.Text = "False";
            this.checkAutoRestart.UseVisualStyleBackColor = true;
            this.checkAutoRestart.TextChanged += new System.EventHandler(this.checkAutoRestart_TextChanged);
            // 
            // checkHide
            // 
            this.checkHide.AutoSize = true;
            this.checkHide.Enabled = false;
            this.checkHide.Location = new System.Drawing.Point(104, 250);
            this.checkHide.Name = "checkHide";
            this.checkHide.Size = new System.Drawing.Size(51, 17);
            this.checkHide.TabIndex = 21;
            this.checkHide.Text = "False";
            this.checkHide.UseVisualStyleBackColor = true;
            this.checkHide.TextChanged += new System.EventHandler(this.CheckHide_TextChanged);
            // 
            // txtRestarts
            // 
            this.txtRestarts.Location = new System.Drawing.Point(104, 201);
            this.txtRestarts.Name = "txtRestarts";
            this.txtRestarts.ReadOnly = true;
            this.txtRestarts.Size = new System.Drawing.Size(192, 20);
            this.txtRestarts.TabIndex = 20;
            // 
            // txtCurrentPriority
            // 
            this.txtCurrentPriority.Location = new System.Drawing.Point(104, 175);
            this.txtCurrentPriority.Name = "txtCurrentPriority";
            this.txtCurrentPriority.ReadOnly = true;
            this.txtCurrentPriority.Size = new System.Drawing.Size(192, 20);
            this.txtCurrentPriority.TabIndex = 20;
            // 
            // txtDefaultPriority
            // 
            this.txtDefaultPriority.Location = new System.Drawing.Point(104, 149);
            this.txtDefaultPriority.Name = "txtDefaultPriority";
            this.txtDefaultPriority.ReadOnly = true;
            this.txtDefaultPriority.Size = new System.Drawing.Size(192, 20);
            this.txtDefaultPriority.TabIndex = 20;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(104, 123);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(192, 20);
            this.txtStatus.TabIndex = 20;
            // 
            // txtArguments
            // 
            this.txtArguments.Location = new System.Drawing.Point(104, 97);
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.ReadOnly = true;
            this.txtArguments.Size = new System.Drawing.Size(192, 20);
            this.txtArguments.TabIndex = 20;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(104, 71);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(192, 20);
            this.txtFile.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 45);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(192, 20);
            this.txtName.TabIndex = 20;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(104, 19);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(192, 20);
            this.txtId.TabIndex = 20;
            // 
            // frmProcessInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 306);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcessInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item info:";
            this.Load += new System.EventHandler(this.FrmProcessInfo_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIdl;
        private System.Windows.Forms.Label lblNl;
        private System.Windows.Forms.Label lblFl;
        private System.Windows.Forms.Label lblAl;
        private System.Windows.Forms.Label lblSl;
        private System.Windows.Forms.Label lblDPl;
        private System.Windows.Forms.Label lblCPl;
        private System.Windows.Forms.Label lblRl;
        private System.Windows.Forms.Label lblARl;
        private System.Windows.Forms.Label lblHOSl;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtRestarts;
        private System.Windows.Forms.TextBox txtCurrentPriority;
        private System.Windows.Forms.TextBox txtDefaultPriority;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtArguments;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox checkHide;
        private System.Windows.Forms.CheckBox checkAutoRestart;
    }
}