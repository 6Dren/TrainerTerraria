namespace TerrariaTrainer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbGodMode = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.status = new System.Windows.Forms.Label();
            this.checkStatus = new System.Windows.Forms.Timer(this.components);
            this.lbPid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbGodMode
            // 
            this.cbGodMode.AutoSize = true;
            this.cbGodMode.BackColor = System.Drawing.Color.Transparent;
            this.cbGodMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGodMode.Font = new System.Drawing.Font("Andy Std", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGodMode.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbGodMode.Location = new System.Drawing.Point(12, 45);
            this.cbGodMode.Name = "cbGodMode";
            this.cbGodMode.Size = new System.Drawing.Size(99, 30);
            this.cbGodMode.TabIndex = 1;
            this.cbGodMode.Text = "Lock life";
            this.cbGodMode.UseVisualStyleBackColor = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Andy Std", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Silver;
            this.status.Location = new System.Drawing.Point(8, 9);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(71, 20);
            this.status.TabIndex = 2;
            this.status.Text = "Status: off";
            // 
            // checkStatus
            // 
            this.checkStatus.Interval = 500;
            this.checkStatus.Tick += new System.EventHandler(this.checkStatus_Tick);
            // 
            // lbPid
            // 
            this.lbPid.AutoSize = true;
            this.lbPid.BackColor = System.Drawing.Color.Transparent;
            this.lbPid.Font = new System.Drawing.Font("Andy Std", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPid.ForeColor = System.Drawing.Color.White;
            this.lbPid.Location = new System.Drawing.Point(425, 10);
            this.lbPid.Name = "lbPid";
            this.lbPid.Size = new System.Drawing.Size(43, 18);
            this.lbPid.TabIndex = 3;
            this.lbPid.Text = "PID: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 297);
            this.Controls.Add(this.lbPid);
            this.Controls.Add(this.status);
            this.Controls.Add(this.cbGodMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Trainer terraria (v1.4.0.5)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.CheckBox cbGodMode;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Label status;
        private System.Windows.Forms.Timer checkStatus;
        public System.Windows.Forms.Label lbPid;
    }
}

