namespace Dalek_V_Cybermen.After_Game_Forms
{
    partial class Win
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
            this.winPB = new System.Windows.Forms.PictureBox();
            this.loadingBarProBar = new System.Windows.Forms.ProgressBar();
            this.loadingBarTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.winPB)).BeginInit();
            this.SuspendLayout();
            // 
            // winPB
            // 
            this.winPB.Image = global::Dalek_V_Cybermen.Properties.Resources.doctor_who_victory;
            this.winPB.Location = new System.Drawing.Point(-6, -5);
            this.winPB.Name = "winPB";
            this.winPB.Size = new System.Drawing.Size(1288, 679);
            this.winPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.winPB.TabIndex = 0;
            this.winPB.TabStop = false;
            // 
            // loadingBarProBar
            // 
            this.loadingBarProBar.Location = new System.Drawing.Point(11, 629);
            this.loadingBarProBar.Margin = new System.Windows.Forms.Padding(2);
            this.loadingBarProBar.Name = "loadingBarProBar";
            this.loadingBarProBar.Size = new System.Drawing.Size(1418, 45);
            this.loadingBarProBar.TabIndex = 6;
            // 
            // loadingBarTimer
            // 
            this.loadingBarTimer.Enabled = true;
            this.loadingBarTimer.Tick += new System.EventHandler(this.loadingBarTimer_Tick);
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 672);
            this.Controls.Add(this.winPB);
            this.Controls.Add(this.loadingBarProBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win";
            this.Load += new System.EventHandler(this.Win_Load);
            ((System.ComponentModel.ISupportInitialize)(this.winPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox winPB;
        private System.Windows.Forms.ProgressBar loadingBarProBar;
        private System.Windows.Forms.Timer loadingBarTimer;
    }
}