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
            this.mmBtn = new System.Windows.Forms.Button();
            this.healthnumLBL = new System.Windows.Forms.Label();
            this.optionsbtn = new System.Windows.Forms.Button();
            this.mainMbtn = new System.Windows.Forms.Button();
            this.pauselbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ammolbl
            // 
            this.ammolbl.AutoSize = true;
            this.ammolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammolbl.ForeColor = System.Drawing.Color.White;
            this.ammolbl.Location = new System.Drawing.Point(13, 13);
            this.ammolbl.Name = "ammolbl";
            this.ammolbl.Size = new System.Drawing.Size(114, 29);
            this.ammolbl.TabIndex = 0;
            this.ammolbl.Text = "Ammo: 0";
            // 
            // killScorelbl
            // 
            this.killScorelbl.AutoSize = true;
            this.killScorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killScorelbl.ForeColor = System.Drawing.Color.White;
            this.killScorelbl.Location = new System.Drawing.Point(307, 13);
            this.killScorelbl.Name = "killScorelbl";
            this.killScorelbl.Size = new System.Drawing.Size(92, 29);
            this.killScorelbl.TabIndex = 1;
            this.killScorelbl.Text = "Kills: 0";
            // 
            // healthlbl
            // 
            this.healthlbl.AutoSize = true;
            this.healthlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthlbl.ForeColor = System.Drawing.Color.White;
            this.healthlbl.Location = new System.Drawing.Point(645, 13);
            this.healthlbl.Name = "healthlbl";
            this.healthlbl.Size = new System.Drawing.Size(88, 29);
            this.healthlbl.TabIndex = 2;
            this.healthlbl.Text = "Health";
            // 
            // healthProBar
            // 
            this.healthProBar.Location = new System.Drawing.Point(739, 12);
            this.healthProBar.Name = "healthProBar";
            this.healthProBar.Size = new System.Drawing.Size(171, 29);
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
            this.playerPB.Image = global::Dalek_V_Cybermen.Properties.Resources.Cup;
            this.playerPB.Location = new System.Drawing.Point(402, 511);
            this.playerPB.Name = "playerPB";
            this.playerPB.Size = new System.Drawing.Size(71, 100);
            this.playerPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerPB.TabIndex = 4;
            this.playerPB.TabStop = false;
            // 
            // udeadlbl
            // 
            this.udeadlbl.AutoSize = true;
            this.udeadlbl.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udeadlbl.ForeColor = System.Drawing.Color.White;
            this.udeadlbl.Location = new System.Drawing.Point(299, 283);
            this.udeadlbl.Name = "udeadlbl";
            this.udeadlbl.Size = new System.Drawing.Size(276, 76);
            this.udeadlbl.TabIndex = 5;
            this.udeadlbl.Text = "You Died";
            this.udeadlbl.Visible = false;
            // 
            // mmBtn
            // 
            this.mmBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmBtn.Location = new System.Drawing.Point(18, 594);
            this.mmBtn.Name = "mmBtn";
            this.mmBtn.Size = new System.Drawing.Size(141, 47);
            this.mmBtn.TabIndex = 6;
            this.mmBtn.Text = "Main Menu";
            this.mmBtn.UseVisualStyleBackColor = true;
            this.mmBtn.Visible = false;
            // 
            // healthnumLBL
            // 
            this.healthnumLBL.AutoSize = true;
            this.healthnumLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthnumLBL.ForeColor = System.Drawing.Color.White;
            this.healthnumLBL.Location = new System.Drawing.Point(548, 12);
            this.healthnumLBL.Name = "healthnumLBL";
            this.healthnumLBL.Size = new System.Drawing.Size(91, 32);
            this.healthnumLBL.TabIndex = 7;
            this.healthnumLBL.Text = "100%";
            // 
            // optionsbtn
            // 
            this.optionsbtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsbtn.Location = new System.Drawing.Point(345, 343);
            this.optionsbtn.Name = "optionsbtn";
            this.optionsbtn.Size = new System.Drawing.Size(184, 82);
            this.optionsbtn.TabIndex = 13;
            this.optionsbtn.Text = "Options";
            this.optionsbtn.UseVisualStyleBackColor = true;
            this.optionsbtn.Visible = false;
            // 
            // mainMbtn
            // 
            this.mainMbtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMbtn.Location = new System.Drawing.Point(345, 167);
            this.mainMbtn.Name = "mainMbtn";
            this.mainMbtn.Size = new System.Drawing.Size(184, 82);
            this.mainMbtn.TabIndex = 12;
            this.mainMbtn.Text = "Return to\r\nMain Menu";
            this.mainMbtn.UseVisualStyleBackColor = true;
            this.mainMbtn.Visible = false;
            // 
            // pauselbl
            // 
            this.pauselbl.AutoSize = true;
            this.pauselbl.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauselbl.ForeColor = System.Drawing.Color.White;
            this.pauselbl.Location = new System.Drawing.Point(268, 88);
            this.pauselbl.Name = "pauselbl";
            this.pauselbl.Size = new System.Drawing.Size(358, 76);
            this.pauselbl.TabIndex = 11;
            this.pauselbl.Text = "Pause Menu";
            this.pauselbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(922, 653);
            this.Controls.Add(this.optionsbtn);
            this.Controls.Add(this.mainMbtn);
            this.Controls.Add(this.pauselbl);
            this.Controls.Add(this.healthnumLBL);
            this.Controls.Add(this.mmBtn);
            this.Controls.Add(this.udeadlbl);
            this.Controls.Add(this.playerPB);
            this.Controls.Add(this.healthProBar);
            this.Controls.Add(this.healthlbl);
            this.Controls.Add(this.killScorelbl);
            this.Controls.Add(this.ammolbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button mmBtn;
        private System.Windows.Forms.Label healthnumLBL;
        private System.Windows.Forms.Button optionsbtn;
        private System.Windows.Forms.Button mainMbtn;
        private System.Windows.Forms.Label pauselbl;
    }
}

