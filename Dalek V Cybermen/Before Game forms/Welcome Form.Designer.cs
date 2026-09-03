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
            this.welcomeLBL = new System.Windows.Forms.Label();
            this.instructionsLBL = new System.Windows.Forms.Label();
            this.playerImagePB = new System.Windows.Forms.PictureBox();
            this.enemyImagePB = new System.Windows.Forms.PictureBox();
            this.beginBTN = new System.Windows.Forms.Button();
            this.loadingBarProBar = new System.Windows.Forms.ProgressBar();
            this.loadingBarTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playerImagePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLBL
            // 
            this.welcomeLBL.AutoSize = true;
            this.welcomeLBL.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLBL.Location = new System.Drawing.Point(102, 9);
            this.welcomeLBL.Name = "welcomeLBL";
            this.welcomeLBL.Size = new System.Drawing.Size(572, 36);
            this.welcomeLBL.TabIndex = 0;
            this.welcomeLBL.Text = "Welcome! to the Dalek vs Cyberman game!";
            // 
            // instructionsLBL
            // 
            this.instructionsLBL.AutoSize = true;
            this.instructionsLBL.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLBL.Location = new System.Drawing.Point(161, 45);
            this.instructionsLBL.Name = "instructionsLBL";
            this.instructionsLBL.Size = new System.Drawing.Size(423, 28);
            this.instructionsLBL.TabIndex = 1;
            this.instructionsLBL.Text = "To begin press the \"Begin\" button now";
            // 
            // playerImagePB
            // 
            this.playerImagePB.Image = global::Dalek_V_Cybermen.Properties.Resources.cyberman;
            this.playerImagePB.Location = new System.Drawing.Point(12, 88);
            this.playerImagePB.Name = "playerImagePB";
            this.playerImagePB.Size = new System.Drawing.Size(298, 417);
            this.playerImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerImagePB.TabIndex = 2;
            this.playerImagePB.TabStop = false;
            // 
            // enemyImagePB
            // 
            this.enemyImagePB.Image = global::Dalek_V_Cybermen.Properties.Resources.Dalek;
            this.enemyImagePB.Location = new System.Drawing.Point(536, 88);
            this.enemyImagePB.Name = "enemyImagePB";
            this.enemyImagePB.Size = new System.Drawing.Size(252, 336);
            this.enemyImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyImagePB.TabIndex = 3;
            this.enemyImagePB.TabStop = false;
            // 
            // beginBTN
            // 
            this.beginBTN.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginBTN.Location = new System.Drawing.Point(366, 251);
            this.beginBTN.Name = "beginBTN";
            this.beginBTN.Size = new System.Drawing.Size(97, 42);
            this.beginBTN.TabIndex = 4;
            this.beginBTN.Text = "Begin";
            this.beginBTN.UseVisualStyleBackColor = true;
            this.beginBTN.Click += new System.EventHandler(this.beginBTN_Click);
            // 
            // loadingBarProBar
            // 
            this.loadingBarProBar.Location = new System.Drawing.Point(288, 251);
            this.loadingBarProBar.Name = "loadingBarProBar";
            this.loadingBarProBar.Size = new System.Drawing.Size(315, 42);
            this.loadingBarProBar.TabIndex = 5;
            this.loadingBarProBar.Visible = false;
            // 
            // loadingBarTimer
            // 
            this.loadingBarTimer.Enabled = true;
            this.loadingBarTimer.Tick += new System.EventHandler(this.loadingBarTimer_Tick);
            // 
            // Welcome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.beginBTN);
            this.Controls.Add(this.instructionsLBL);
            this.Controls.Add(this.welcomeLBL);
            this.Controls.Add(this.loadingBarProBar);
            this.Controls.Add(this.playerImagePB);
            this.Controls.Add(this.enemyImagePB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome_Form";
            this.Text = "Welcome Form";
            ((System.ComponentModel.ISupportInitialize)(this.playerImagePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyImagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLBL;
        private System.Windows.Forms.Label instructionsLBL;
        private System.Windows.Forms.PictureBox playerImagePB;
        private System.Windows.Forms.PictureBox enemyImagePB;
        private System.Windows.Forms.Button beginBTN;
        private System.Windows.Forms.ProgressBar loadingBarProBar;
        private System.Windows.Forms.Timer loadingBarTimer;
    }
}