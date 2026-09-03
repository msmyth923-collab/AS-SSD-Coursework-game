namespace Dalek_V_Cybermen.Before_Game_forms
{
    partial class Login_Form
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
            this.welcomeLBL = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.usernameLBL = new System.Windows.Forms.Label();
            this.passwordLBL = new System.Windows.Forms.Label();
            this.registorLBL = new System.Windows.Forms.Label();
            this.loginBTN = new System.Windows.Forms.Button();
            this.registorBTN = new System.Windows.Forms.Button();
            this.helpBTN = new System.Windows.Forms.Button();
            this.helpLBL = new System.Windows.Forms.Label();
            this.showPassBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLBL
            // 
            this.welcomeLBL.AutoSize = true;
            this.welcomeLBL.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLBL.Location = new System.Drawing.Point(198, 9);
            this.welcomeLBL.Name = "welcomeLBL";
            this.welcomeLBL.Size = new System.Drawing.Size(373, 36);
            this.welcomeLBL.TabIndex = 0;
            this.welcomeLBL.Text = "Welcome to the Login Form";
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.Location = new System.Drawing.Point(334, 101);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(185, 31);
            this.usernameTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(334, 138);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(185, 31);
            this.passwordTB.TabIndex = 2;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // usernameLBL
            // 
            this.usernameLBL.AutoSize = true;
            this.usernameLBL.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLBL.Location = new System.Drawing.Point(199, 101);
            this.usernameLBL.Name = "usernameLBL";
            this.usernameLBL.Size = new System.Drawing.Size(120, 28);
            this.usernameLBL.TabIndex = 3;
            this.usernameLBL.Text = "Username";
            // 
            // passwordLBL
            // 
            this.passwordLBL.AutoSize = true;
            this.passwordLBL.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLBL.Location = new System.Drawing.Point(207, 139);
            this.passwordLBL.Name = "passwordLBL";
            this.passwordLBL.Size = new System.Drawing.Size(112, 28);
            this.passwordLBL.TabIndex = 4;
            this.passwordLBL.Text = "Password";
            // 
            // registorLBL
            // 
            this.registorLBL.AutoSize = true;
            this.registorLBL.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registorLBL.Location = new System.Drawing.Point(9, 247);
            this.registorLBL.Name = "registorLBL";
            this.registorLBL.Size = new System.Drawing.Size(277, 52);
            this.registorLBL.TabIndex = 5;
            this.registorLBL.Text = "no account? \r\nclick on the \"Register\" button";
            // 
            // loginBTN
            // 
            this.loginBTN.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.Location = new System.Drawing.Point(345, 202);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(108, 40);
            this.loginBTN.TabIndex = 6;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // registorBTN
            // 
            this.registorBTN.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registorBTN.Location = new System.Drawing.Point(14, 313);
            this.registorBTN.Name = "registorBTN";
            this.registorBTN.Size = new System.Drawing.Size(122, 38);
            this.registorBTN.TabIndex = 7;
            this.registorBTN.Text = "Registor";
            this.registorBTN.UseVisualStyleBackColor = true;
            this.registorBTN.Click += new System.EventHandler(this.registorBTN_Click);
            // 
            // helpBTN
            // 
            this.helpBTN.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBTN.Location = new System.Drawing.Point(664, 313);
            this.helpBTN.Name = "helpBTN";
            this.helpBTN.Size = new System.Drawing.Size(122, 38);
            this.helpBTN.TabIndex = 8;
            this.helpBTN.Text = "Help";
            this.helpBTN.UseVisualStyleBackColor = true;
            this.helpBTN.Click += new System.EventHandler(this.helpBTN_Click);
            // 
            // helpLBL
            // 
            this.helpLBL.AutoSize = true;
            this.helpLBL.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLBL.Location = new System.Drawing.Point(541, 247);
            this.helpLBL.Name = "helpLBL";
            this.helpLBL.Size = new System.Drawing.Size(245, 52);
            this.helpLBL.TabIndex = 9;
            this.helpLBL.Text = "                      Need help?\r\nclick on the \"Help\" button";
            // 
            // showPassBTN
            // 
            this.showPassBTN.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassBTN.Location = new System.Drawing.Point(525, 139);
            this.showPassBTN.Name = "showPassBTN";
            this.showPassBTN.Size = new System.Drawing.Size(114, 61);
            this.showPassBTN.TabIndex = 10;
            this.showPassBTN.Text = "show Password";
            this.showPassBTN.UseVisualStyleBackColor = true;
            this.showPassBTN.Click += new System.EventHandler(this.showPassBTN_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.showPassBTN);
            this.Controls.Add(this.helpLBL);
            this.Controls.Add(this.helpBTN);
            this.Controls.Add(this.registorBTN);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.registorLBL);
            this.Controls.Add(this.passwordLBL);
            this.Controls.Add(this.usernameLBL);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.welcomeLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLBL;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label usernameLBL;
        private System.Windows.Forms.Label passwordLBL;
        private System.Windows.Forms.Label registorLBL;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.Button registorBTN;
        private System.Windows.Forms.Button helpBTN;
        private System.Windows.Forms.Label helpLBL;
        private System.Windows.Forms.Button showPassBTN;
    }
}