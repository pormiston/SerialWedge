namespace Wedgies
{
    partial class frmWedge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWedge));
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.chkOnOff = new System.Windows.Forms.CheckBox();
            this.bgwInterceptWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(42, 36);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(121, 21);
            this.cboPort.TabIndex = 0;
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Location = new System.Drawing.Point(42, 83);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cboBaudRate.TabIndex = 1;
            // 
            // chkOnOff
            // 
            this.chkOnOff.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOnOff.AutoSize = true;
            this.chkOnOff.Location = new System.Drawing.Point(80, 144);
            this.chkOnOff.Name = "chkOnOff";
            this.chkOnOff.Size = new System.Drawing.Size(50, 23);
            this.chkOnOff.TabIndex = 2;
            this.chkOnOff.Text = "On/Off";
            this.chkOnOff.UseVisualStyleBackColor = true;
            // 
            // frmWedge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 215);
            this.Controls.Add(this.chkOnOff);
            this.Controls.Add(this.cboBaudRate);
            this.Controls.Add(this.cboPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWedge";
            this.Text = "Wedge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.CheckBox chkOnOff;
        private System.ComponentModel.BackgroundWorker bgwInterceptWorker;
    }
}

