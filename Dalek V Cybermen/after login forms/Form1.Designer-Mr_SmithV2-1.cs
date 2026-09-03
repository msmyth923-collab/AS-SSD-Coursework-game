namespace Dalek_V_Cybermen
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
            this.ammolbl = new System.Windows.Forms.Label();
            this.killScorelbl = new System.Windows.Forms.Label();
            this.healthlbl = new System.Windows.Forms.Label();
            this.healthProBar = new System.Windows.Forms.ProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerPB = new System.Windows.Forms.PictureBox();
            this.udeadlbl = new System.Windows.Forms.Label();
            this.healthnumLBL = new System.Windows.Forms.Label();
            this.mainMbtn = new System.Windows.Forms.Button();
            this.pauselbl = new System.Windows.Forms.Label();
            this.liveLBLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ammolbl
            // 
            this.ammolbl.AutoSize = true;
            this.ammolbl.BackColor = System.Drawing.Color.Transparent;
            this.ammolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammolbl.ForeColor = System.Drawing.Color.White;
            this.ammolbl.Location = new System.Drawing.Point(11, 6);
            this.ammolbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ammolbl.Name = "ammolbl";
            this.ammolbl.Size = new System.Drawing.Size(144, 31);
            this.ammolbl.TabIndex = 0;
            this.ammolbl.Text = "Ammo: 10";
            // 
            // killScorelbl
            // 
            this.killScorelbl.AutoSize = true;
            this.killScorelbl.BackColor = System.Drawing.Color.Transparent;
            this.killScorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killScorelbl.ForeColor = System.Drawing.Color.White;
            this.killScorelbl.Location = new System.Drawing.Point(335, 6);
            this.killScorelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.killScorelbl.Name = "killScorelbl";
            this.killScorelbl.Size = new System.Drawing.Size(102, 31);
            this.killScorelbl.TabIndex = 1;
            this.killScorelbl.Text = "Kills: 0";
            // 
            // healthlbl
            // 
            this.healthlbl.AutoSize = true;
            this.healthlbl.BackColor = System.Drawing.Color.Transparent;
            this.healthlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthlbl.ForeColor = System.Drawing.Color.White;
            this.healthlbl.Location = new System.Drawing.Point(955, 6);
            this.healthlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.healthlbl.Name = "healthlbl";
            this.healthlbl.Size = new System.Drawing.Size(132, 42);
            this.healthlbl.TabIndex = 2;
            this.healthlbl.Text = "Health";
            // 
            // healthProBar
            // 
            this.healthProBar.Location = new System.Drawing.Point(1081, 9);
            this.healthProBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.healthProBar.Name = "healthProBar";
            this.healthProBar.Size = new System.Drawing.Size(180, 39);
            this.healthProBar.TabIndex = 3;
            this.healthProBar.Value = 100;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // playerPB
            // 
            this.playerPB.BackColor = System.Drawing.Color.Transparent;
            this.playerPB.Image = global::Dalek_V_Cybermen.Properties.Resources.Cup;
            this.playerPB.Location = new System.Drawing.Point(614, 470);
            this.playerPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playerPB.Name = "playerPB";
            this.playerPB.Size = new System.Drawing.Size(107, 150);
            this.playerPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPB.TabIndex = 4;
            this.playerPB.TabStop = false;
            // 
            // udeadlbl
            // 
            this.udeadlbl.AutoSize = true;
            this.udeadlbl.BackColor = System.Drawing.Color.Transparent;
            this.udeadlbl.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udeadlbl.ForeColor = System.Drawing.Color.White;
            this.udeadlbl.Location = new System.Drawing.Point(563, 361);
            this.udeadlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.udeadlbl.Name = "udeadlbl";
            this.udeadlbl.Size = new System.Drawing.Size(222, 61);
            this.udeadlbl.TabIndex = 5;
            this.udeadlbl.Text = "You Died";
            this.udeadlbl.Visible = false;
            // 
            // healthnumLBL
            // 
            this.healthnumLBL.AutoSize = true;
            this.healthnumLBL.BackColor = System.Drawing.Color.Transparent;
            this.healthnumLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthnumLBL.ForeColor = System.Drawing.Color.White;
            this.healthnumLBL.Location = new System.Drawing.Point(843, 9);
            this.healthnumLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.healthnumLBL.Name = "healthnumLBL";
            this.healthnumLBL.Size = new System.Drawing.Size(118, 42);
            this.healthnumLBL.TabIndex = 7;
            this.healthnumLBL.Text = "100%";
            // 
            // mainMbtn
            // 
            this.mainMbtn.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMbtn.Location = new System.Drawing.Point(574, 230);
            this.mainMbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainMbtn.Name = "mainMbtn";
            this.mainMbtn.Size = new System.Drawing.Size(188, 110);
            this.mainMbtn.TabIndex = 12;
            this.mainMbtn.Text = "Return to\r\nMain Menu";
            this.mainMbtn.UseVisualStyleBackColor = true;
            this.mainMbtn.Visible = false;
            this.mainMbtn.Click += new System.EventHandler(this.mainMbtn_Click);
            // 
            // pauselbl
            // 
            this.pauselbl.AutoSize = true;
            this.pauselbl.BackColor = System.Drawing.Color.Transparent;
            this.pauselbl.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauselbl.ForeColor = System.Drawing.Color.White;
            this.pauselbl.Location = new System.Drawing.Point(522, 154);
            this.pauselbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pauselbl.Name = "pauselbl";
            this.pauselbl.Size = new System.Drawing.Size(290, 61);
            this.pauselbl.TabIndex = 11;
            this.pauselbl.Text = "Pause Menu";
            this.pauselbl.Visible = false;
            // 
            // liveLBLB
            // 
            this.liveLBLB.AutoSize = true;
            this.liveLBLB.BackColor = System.Drawing.Color.Transparent;
            this.liveLBLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveLBLB.ForeColor = System.Drawing.Color.White;
            this.liveLBLB.Location = new System.Drawing.Point(220, 9);
            this.liveLBLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.liveLBLB.Name = "liveLBLB";
            this.liveLBLB.Size = new System.Drawing.Size(101, 31);
            this.liveLBLB.TabIndex = 13;
            this.liveLBLB.Text = "Live: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Dalek_V_Cybermen.Properties.Resources.city_cool;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 695);
            this.Controls.Add(this.liveLBLB);
            this.Controls.Add(this.mainMbtn);
            this.Controls.Add(this.pauselbl);
            this.Controls.Add(this.healthnumLBL);
            this.Controls.Add(this.udeadlbl);
            this.Controls.Add(this.playerPB);
            this.Controls.Add(this.healthProBar);
            this.Controls.Add(this.healthlbl);
            this.Controls.Add(this.killScorelbl);
            this.Controls.Add(this.ammolbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.playerPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ammolbl;
        private System.Windows.Forms.Label killScorelbl;
        private System.Windows.Forms.Label healthlbl;
        private System.Windows.Forms.ProgressBar healthProBar;
        private System.Windows.Forms.PictureBox playerPB;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label udeadlbl;
        private System.Windows.Forms.Label healthnumLBL;
        private System.Windows.Forms.Button mainMbtn;
        private System.Windows.Forms.Label pauselbl;
        private System.Windows.Forms.Label liveLBLB;
    }
}

