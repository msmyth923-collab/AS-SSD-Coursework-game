namespace Dalek_V_Cybermen.After_Game_Forms
{
    partial class Lose
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
            this.losePB = new System.Windows.Forms.PictureBox();
            this.loadingBarProBar = new System.Windows.Forms.ProgressBar();
            this.loadingBarTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.losePB)).BeginInit();
            this.SuspendLayout();
            // 
            // losePB
            // 
            this.losePB.Image = global::Dalek_V_Cybermen.Properties.Resources.doctor_who_defeat;
            this.losePB.Location = new System.Drawing.Point(-2, -1);
            this.losePB.Name = "losePB";
            this.losePB.Size = new System.Drawing.Size(1657, 1094);
            this.losePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.losePB.TabIndex = 0;
            this.losePB.TabStop = false;
            // 
            // loadingBarProBar
            // 
            this.loadingBarProBar.Location = new System.Drawing.Point(11, 1032);
            this.loadingBarProBar.Margin = new System.Windows.Forms.Padding(2);
            this.loadingBarProBar.Name = "loadingBarProBar";
            this.loadingBarProBar.Size = new System.Drawing.Size(1625, 45);
            this.loadingBarProBar.TabIndex = 7;
            // 
            // loadingBarTimer
            // 
            this.loadingBarTimer.Enabled = true;
            this.loadingBarTimer.Tick += new System.EventHandler(this.loadingBarTimer_Tick);
            // 
            // Lose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1647, 1088);
            this.Controls.Add(this.losePB);
            this.Controls.Add(this.loadingBarProBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lose";
            this.Text = "Lose";
            this.Load += new System.EventHandler(this.Lose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.losePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox losePB;
        private System.Windows.Forms.ProgressBar loadingBarProBar;
        private System.Windows.Forms.Timer loadingBarTimer;
    }
}