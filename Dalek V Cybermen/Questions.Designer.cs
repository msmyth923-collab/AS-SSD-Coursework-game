namespace Dalek_V_Cybermen
{
    partial class Questions
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
            this.questionLBL = new System.Windows.Forms.Label();
            this.answer1BTN = new System.Windows.Forms.Button();
            this.answer2BTN = new System.Windows.Forms.Button();
            this.answer3BTN = new System.Windows.Forms.Button();
            this.answer4BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLBL
            // 
            this.questionLBL.AutoSize = true;
            this.questionLBL.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLBL.Location = new System.Drawing.Point(66, 38);
            this.questionLBL.Name = "questionLBL";
            this.questionLBL.Size = new System.Drawing.Size(267, 36);
            this.questionLBL.TabIndex = 0;
            this.questionLBL.Text = "Question goes here";
            // 
            // answer1BTN
            // 
            this.answer1BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer1BTN.Location = new System.Drawing.Point(72, 186);
            this.answer1BTN.Name = "answer1BTN";
            this.answer1BTN.Size = new System.Drawing.Size(157, 73);
            this.answer1BTN.TabIndex = 1;
            this.answer1BTN.Text = "1";
            this.answer1BTN.UseVisualStyleBackColor = true;
            this.answer1BTN.Click += new System.EventHandler(this.CheckAnsEvent);
            // 
            // answer2BTN
            // 
            this.answer2BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer2BTN.Location = new System.Drawing.Point(348, 186);
            this.answer2BTN.Name = "answer2BTN";
            this.answer2BTN.Size = new System.Drawing.Size(157, 73);
            this.answer2BTN.TabIndex = 2;
            this.answer2BTN.Text = "2";
            this.answer2BTN.UseVisualStyleBackColor = true;
            this.answer2BTN.Click += new System.EventHandler(this.CheckAnsEvent);
            // 
            // answer3BTN
            // 
            this.answer3BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer3BTN.Location = new System.Drawing.Point(72, 368);
            this.answer3BTN.Name = "answer3BTN";
            this.answer3BTN.Size = new System.Drawing.Size(157, 73);
            this.answer3BTN.TabIndex = 3;
            this.answer3BTN.Text = "3";
            this.answer3BTN.UseVisualStyleBackColor = true;
            this.answer3BTN.Click += new System.EventHandler(this.CheckAnsEvent);
            // 
            // answer4BTN
            // 
            this.answer4BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer4BTN.Location = new System.Drawing.Point(348, 368);
            this.answer4BTN.Name = "answer4BTN";
            this.answer4BTN.Size = new System.Drawing.Size(157, 73);
            this.answer4BTN.TabIndex = 4;
            this.answer4BTN.Text = "4";
            this.answer4BTN.UseVisualStyleBackColor = true;
            this.answer4BTN.Click += new System.EventHandler(this.CheckAnsEvent);
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 523);
            this.Controls.Add(this.answer4BTN);
            this.Controls.Add(this.answer3BTN);
            this.Controls.Add(this.answer2BTN);
            this.Controls.Add(this.answer1BTN);
            this.Controls.Add(this.questionLBL);
            this.Name = "Questions";
            this.Text = "Questions";
            this.Click += new System.EventHandler(this.CheckAnsEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLBL;
        private System.Windows.Forms.Button answer1BTN;
        private System.Windows.Forms.Button answer2BTN;
        private System.Windows.Forms.Button answer3BTN;
        private System.Windows.Forms.Button answer4BTN;
    }
}