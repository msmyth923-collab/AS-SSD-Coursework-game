namespace Dalek_V_Cybermen
{
    partial class Main_Menu_Form
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
            this.logOutBTN = new System.Windows.Forms.Button();
            this.srtGameBTN = new System.Windows.Forms.Button();
            this.screBrdBTN = new System.Windows.Forms.Button();
            this.helpBTN = new System.Windows.Forms.Button();
            this.welcomeLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logOutBTN
            // 
            this.logOutBTN.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBTN.Location = new System.Drawing.Point(661, 140);
            this.logOutBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutBTN.Name = "logOutBTN";
            this.logOutBTN.Size = new System.Drawing.Size(227, 129);
            this.logOutBTN.TabIndex = 0;
            this.logOutBTN.Text = "Log Out";
            this.logOutBTN.UseVisualStyleBackColor = true;
            this.logOutBTN.Click += new System.EventHandler(this.logOutBTN_Click);
            // 
            // srtGameBTN
            // 
            this.srtGameBTN.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srtGameBTN.Location = new System.Drawing.Point(661, 407);
            this.srtGameBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.srtGameBTN.Name = "srtGameBTN";
            this.srtGameBTN.Size = new System.Drawing.Size(227, 129);
            this.srtGameBTN.TabIndex = 1;
            this.srtGameBTN.Text = "Game Tutorial";
            this.srtGameBTN.UseVisualStyleBackColor = true;
            this.srtGameBTN.Click += new System.EventHandler(this.srtGameBTN_Click);
            // 
            // screBrdBTN
            // 
            this.screBrdBTN.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screBrdBTN.Location = new System.Drawing.Point(661, 682);
            this.screBrdBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.screBrdBTN.Name = "screBrdBTN";
            this.screBrdBTN.Size = new System.Drawing.Size(227, 175);
            this.screBrdBTN.TabIndex = 2;
            this.screBrdBTN.Text = "Score board\r\n&&&\r\nLeaderboard";
            this.screBrdBTN.UseVisualStyleBackColor = true;
            this.screBrdBTN.Click += new System.EventHandler(this.screBrdBTN_Click);
            // 
            // helpBTN
            // 
            this.helpBTN.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBTN.Location = new System.Drawing.Point(15, 737);
            this.helpBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.helpBTN.Name = "helpBTN";
            this.helpBTN.Size = new System.Drawing.Size(245, 146);
            this.helpBTN.TabIndex = 3;
            this.helpBTN.Text = "Help";
            this.helpBTN.UseVisualStyleBackColor = true;
            this.helpBTN.Click += new System.EventHandler(this.helpBTN_Click);
            // 
            // welcomeLBL
            // 
            this.welcomeLBL.AutoSize = true;
            this.welcomeLBL.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLBL.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLBL.Location = new System.Drawing.Point(495, 22);
            this.welcomeLBL.Name = "welcomeLBL";
            this.welcomeLBL.Size = new System.Drawing.Size(526, 43);
            this.welcomeLBL.TabIndex = 4;
            this.welcomeLBL.Text = "Welcome user to the Main Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "please select one of the following buttons to continue";
            // 
            // Main_Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dalek_V_Cybermen.Properties.Resources.lnfkjaebfvjkhb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1573, 897);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeLBL);
            this.Controls.Add(this.helpBTN);
            this.Controls.Add(this.screBrdBTN);
            this.Controls.Add(this.srtGameBTN);
            this.Controls.Add(this.logOutBTN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main_Menu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Menu_Form";
            this.Load += new System.EventHandler(this.Main_Menu_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutBTN;
        private System.Windows.Forms.Button srtGameBTN;
        private System.Windows.Forms.Button screBrdBTN;
        private System.Windows.Forms.Button helpBTN;
        private System.Windows.Forms.Label welcomeLBL;
        private System.Windows.Forms.Label label1;
    }
}