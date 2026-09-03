namespace Dalek_V_Cybermen.Before_Game_forms
{
    partial class Welcome_Form
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
            this.playerImagePB = new System.Windows.Forms.PictureBox();
            this.enemyImagePB = new System.Windows.Forms.PictureBox();
            this.beginBTN = new System.Windows.Forms.Button();
            this.loadingBarProBar = new System.Windows.Forms.ProgressBar();
            this.loadingBarTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loadingLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerImagePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyImagePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // playerImagePB
            // 
            this.playerImagePB.BackColor = System.Drawing.Color.Transparent;
            this.playerImagePB.Image = global::Dalek_V_Cybermen.Properties.Resources.cyberman;
            this.playerImagePB.Location = new System.Drawing.Point(11, 298);
            this.playerImagePB.Margin = new System.Windows.Forms.Padding(2);
            this.playerImagePB.Name = "playerImagePB";
            this.playerImagePB.Size = new System.Drawing.Size(224, 339);
            this.playerImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerImagePB.TabIndex = 2;
            this.playerImagePB.TabStop = false;
            // 
            // enemyImagePB
            // 
            this.enemyImagePB.BackColor = System.Drawing.Color.Transparent;
            this.enemyImagePB.Image = global::Dalek_V_Cybermen.Properties.Resources.Dalek;
            this.enemyImagePB.Location = new System.Drawing.Point(820, 298);
            this.enemyImagePB.Margin = new System.Windows.Forms.Padding(2);
            this.enemyImagePB.Name = "enemyImagePB";
            this.enemyImagePB.Size = new System.Drawing.Size(189, 269);
            this.enemyImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyImagePB.TabIndex = 3;
            this.enemyImagePB.TabStop = false;
            // 
            // beginBTN
            // 
            this.beginBTN.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginBTN.Location = new System.Drawing.Point(472, 431);
            this.beginBTN.Margin = new System.Windows.Forms.Padding(2);
            this.beginBTN.Name = "beginBTN";
            this.beginBTN.Size = new System.Drawing.Size(75, 41);
            this.beginBTN.TabIndex = 4;
            this.beginBTN.Text = "Begin";
            this.beginBTN.UseVisualStyleBackColor = true;
            this.beginBTN.Click += new System.EventHandler(this.beginBTN_Click);
            this.beginBTN.MouseEnter += new System.EventHandler(this.beginBTN_MouseEnter);
            this.beginBTN.MouseLeave += new System.EventHandler(this.beginBTN_MouseL);
            // 
            // loadingBarProBar
            // 
            this.loadingBarProBar.Location = new System.Drawing.Point(239, 498);
            this.loadingBarProBar.Margin = new System.Windows.Forms.Padding(2);
            this.loadingBarProBar.Name = "loadingBarProBar";
            this.loadingBarProBar.Size = new System.Drawing.Size(577, 57);
            this.loadingBarProBar.TabIndex = 5;
            this.loadingBarProBar.Visible = false;
            // 
            // loadingBarTimer
            // 
            this.loadingBarTimer.Enabled = true;
            this.loadingBarTimer.Tick += new System.EventHandler(this.loadingBarTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Dalek_V_Cybermen.Properties.Resources.welcome;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(997, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Dalek_V_Cybermen.Properties.Resources.beghin;
            this.pictureBox2.Location = new System.Drawing.Point(11, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(997, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // loadingLBL
            // 
            this.loadingLBL.AutoSize = true;
            this.loadingLBL.BackColor = System.Drawing.Color.Transparent;
            this.loadingLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLBL.ForeColor = System.Drawing.Color.Lime;
            this.loadingLBL.Location = new System.Drawing.Point(442, 432);
            this.loadingLBL.Name = "loadingLBL";
            this.loadingLBL.Size = new System.Drawing.Size(144, 31);
            this.loadingLBL.TabIndex = 8;
            this.loadingLBL.Text = "Loading...";
            this.loadingLBL.Visible = false;
            // 
            // Welcome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Dalek_V_Cybermen.Properties.Resources.awwdawdsdawd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 578);
            this.Controls.Add(this.beginBTN);
            this.Controls.Add(this.loadingLBL);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loadingBarProBar);
            this.Controls.Add(this.playerImagePB);
            this.Controls.Add(this.enemyImagePB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Welcome_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Form";
            this.Load += new System.EventHandler(this.Welcome_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerImagePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyImagePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox playerImagePB;
        private System.Windows.Forms.PictureBox enemyImagePB;
        private System.Windows.Forms.Button beginBTN;
        private System.Windows.Forms.ProgressBar loadingBarProBar;
        private System.Windows.Forms.Timer loadingBarTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label loadingLBL;
    }
}