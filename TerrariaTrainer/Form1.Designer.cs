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
            cbGodMode = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbStatus = new System.Windows.Forms.Label();
            this.checkStatus = new System.Windows.Forms.Timer(this.components);
            this.lbPid = new System.Windows.Forms.Label();
            this.cbUnlimitedMana = new System.Windows.Forms.CheckBox();
            this.btScan = new System.Windows.Forms.PictureBox();
            this.lbScan = new System.Windows.Forms.Label();
            cbUntouch = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.btScan)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGodMode
            // 
            cbGodMode.AutoSize = true;
            cbGodMode.BackColor = System.Drawing.Color.Transparent;
            cbGodMode.Cursor = System.Windows.Forms.Cursors.Hand;
            cbGodMode.Enabled = false;
            cbGodMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cbGodMode.ForeColor = System.Drawing.Color.Silver;
            cbGodMode.Location = new System.Drawing.Point(12, 45);
            cbGodMode.Name = "cbGodMode";
            cbGodMode.Size = new System.Drawing.Size(132, 29);
            cbGodMode.TabIndex = 1;
            cbGodMode.Text = "GodMode";
            cbGodMode.UseVisualStyleBackColor = false;
            cbGodMode.CheckedChanged += new System.EventHandler(this.cbGodMode_CheckedChanged);
            cbGodMode.Click += new System.EventHandler(this.clickCB);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Silver;
            this.lbStatus.Location = new System.Drawing.Point(8, 9);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(94, 20);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Status: off";
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
            this.lbPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPid.ForeColor = System.Drawing.Color.White;
            this.lbPid.Location = new System.Drawing.Point(498, 10);
            this.lbPid.Name = "lbPid";
            this.lbPid.Size = new System.Drawing.Size(54, 18);
            this.lbPid.TabIndex = 3;
            this.lbPid.Text = "PID: 0";
            // 
            // cbUnlimitedMana
            // 
            this.cbUnlimitedMana.AutoSize = true;
            this.cbUnlimitedMana.BackColor = System.Drawing.Color.Transparent;
            this.cbUnlimitedMana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUnlimitedMana.Enabled = false;
            this.cbUnlimitedMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnlimitedMana.ForeColor = System.Drawing.Color.Silver;
            this.cbUnlimitedMana.Location = new System.Drawing.Point(12, 81);
            this.cbUnlimitedMana.Name = "cbUnlimitedMana";
            this.cbUnlimitedMana.Size = new System.Drawing.Size(201, 29);
            this.cbUnlimitedMana.TabIndex = 4;
            this.cbUnlimitedMana.Text = "Unlimeted Mana";
            this.cbUnlimitedMana.UseVisualStyleBackColor = false;
            // 
            // btScan
            // 
            this.btScan.BackColor = System.Drawing.Color.Transparent;
            this.btScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btScan.Image = ((System.Drawing.Image)(resources.GetObject("btScan.Image")));
            this.btScan.Location = new System.Drawing.Point(457, -1);
            this.btScan.Name = "btScan";
            this.btScan.Size = new System.Drawing.Size(23, 27);
            this.btScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btScan.TabIndex = 5;
            this.btScan.TabStop = false;
            this.btScan.Click += new System.EventHandler(this.clickScan);
            // 
            // lbScan
            // 
            this.lbScan.AutoSize = true;
            this.lbScan.BackColor = System.Drawing.Color.Transparent;
            this.lbScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScan.ForeColor = System.Drawing.Color.Maroon;
            this.lbScan.Location = new System.Drawing.Point(451, 27);
            this.lbScan.Name = "lbScan";
            this.lbScan.Size = new System.Drawing.Size(36, 13);
            this.lbScan.TabIndex = 6;
            this.lbScan.Text = "Scan";
            this.lbScan.Click += new System.EventHandler(this.clickScan);
            // 
            // cbUntouch
            // 
            cbUntouch.AutoSize = true;
            cbUntouch.BackColor = System.Drawing.Color.Transparent;
            cbUntouch.Enabled = false;
            cbUntouch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cbUntouch.ForeColor = System.Drawing.Color.Silver;
            cbUntouch.Location = new System.Drawing.Point(147, 51);
            cbUntouch.Name = "cbUntouch";
            cbUntouch.Size = new System.Drawing.Size(98, 17);
            cbUntouch.TabIndex = 7;
            cbUntouch.Text = "Untouchable";
            cbUntouch.UseVisualStyleBackColor = false;
            cbUntouch.Visible = false;
            cbUntouch.Click += new System.EventHandler(this.clickCB);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 297);
            this.Controls.Add(cbUntouch);
            this.Controls.Add(this.lbScan);
            this.Controls.Add(this.btScan);
            this.Controls.Add(this.cbUnlimitedMana);
            this.Controls.Add(this.lbPid);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(cbGodMode);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Trainer terraria (v1.4.1.1)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btScan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer checkStatus;
        public System.Windows.Forms.Label lbPid;
        public System.Windows.Forms.Label lbStatus;
        public System.Windows.Forms.CheckBox cbUnlimitedMana;

        public static System.Windows.Forms.Label lbStt; // label Status
        public static bool cbGm; //checkbox Godmode
        public static System.Windows.Forms.CheckBox cbUM; //checkbox UnlimitedMana
        private System.Windows.Forms.PictureBox btScan;
        private System.Windows.Forms.Label lbScan;
        public static System.Windows.Forms.CheckBox cbGodMode;
        public static System.Windows.Forms.CheckBox cbUntouch;
    }
}

