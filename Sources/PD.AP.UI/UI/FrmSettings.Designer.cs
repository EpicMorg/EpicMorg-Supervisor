namespace process_demonizator.UI
{
    sealed partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.gbxOptions = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numMaxRestarts = new System.Windows.Forms.NumericUpDown();
            this.lblMaxRestarts = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxRestarts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxOptions
            // 
            this.gbxOptions.Controls.Add(this.textBox1);
            this.gbxOptions.Controls.Add(this.label1);
            this.gbxOptions.Controls.Add(this.numMaxRestarts);
            this.gbxOptions.Controls.Add(this.lblMaxRestarts);
            this.gbxOptions.Location = new System.Drawing.Point(12, 12);
            this.gbxOptions.Name = "gbxOptions";
            this.gbxOptions.Size = new System.Drawing.Size(356, 76);
            this.gbxOptions.TabIndex = 1;
            this.gbxOptions.TabStop = false;
            this.gbxOptions.Text = "Check options:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log Path";
            // 
            // numMaxRestarts
            // 
            this.numMaxRestarts.Location = new System.Drawing.Point(148, 19);
            this.numMaxRestarts.Name = "numMaxRestarts";
            this.numMaxRestarts.Size = new System.Drawing.Size(202, 20);
            this.numMaxRestarts.TabIndex = 1;
            // 
            // lblMaxRestarts
            // 
            this.lblMaxRestarts.AutoSize = true;
            this.lblMaxRestarts.Location = new System.Drawing.Point(6, 21);
            this.lblMaxRestarts.Name = "lblMaxRestarts";
            this.lblMaxRestarts.Size = new System.Drawing.Size(128, 13);
            this.lblMaxRestarts.TabIndex = 0;
            this.lblMaxRestarts.Text = "Max restarts per. process:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(293, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmSettings
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 135);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbxOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "name settings";
            this.gbxOptions.ResumeLayout(false);
            this.gbxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxRestarts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxOptions;
        private System.Windows.Forms.NumericUpDown numMaxRestarts;
        private System.Windows.Forms.Label lblMaxRestarts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}