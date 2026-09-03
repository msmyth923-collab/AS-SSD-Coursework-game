namespace Dalek_V_Cybermen
{
    partial class TheGameQuiz
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
            this.questionTimer = new System.Windows.Forms.Timer(this.components);
            this.questionLBL = new System.Windows.Forms.Label();
            this.timerLBL = new System.Windows.Forms.Label();
            this.answer1BTN = new System.Windows.Forms.Button();
            this.answer2BTN = new System.Windows.Forms.Button();
            this.answer3BTN = new System.Windows.Forms.Button();
            this.answer4BTN = new System.Windows.Forms.Button();
            this.mathsAnswerBTN = new System.Windows.Forms.Button();
            this.mathsAnswerTB = new System.Windows.Forms.TextBox();
            this.subjectPB = new System.Windows.Forms.PictureBox();
            this.timeTimelbl = new System.Windows.Forms.Label();
            this.instructionsLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subjectPB)).BeginInit();
            this.SuspendLayout();
            // 
            // questionTimer
            // 
            this.questionTimer.Tick += new System.EventHandler(this.questionTimer_Tick);
            // 
            // questionLBL
            // 
            this.questionLBL.AutoSize = true;
            this.questionLBL.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLBL.Location = new System.Drawing.Point(109, 24);
            this.questionLBL.Name = "questionLBL";
            this.questionLBL.Size = new System.Drawing.Size(138, 37);
            this.questionLBL.TabIndex = 1;
            this.questionLBL.Text = "Question";
            // 
            // timerLBL
            // 
            this.timerLBL.AutoSize = true;
            this.timerLBL.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLBL.Location = new System.Drawing.Point(1089, 21);
            this.timerLBL.Name = "timerLBL";
            this.timerLBL.Size = new System.Drawing.Size(55, 40);
            this.timerLBL.TabIndex = 2;
            this.timerLBL.Text = "00";
            // 
            // answer1BTN
            // 
            this.answer1BTN.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer1BTN.Location = new System.Drawing.Point(107, 75);
            this.answer1BTN.Name = "answer1BTN";
            this.answer1BTN.Size = new System.Drawing.Size(231, 110);
            this.answer1BTN.TabIndex = 3;
            this.answer1BTN.Text = "button1";
            this.answer1BTN.UseVisualStyleBackColor = true;
            this.answer1BTN.Click += new System.EventHandler(this.ClickButtonEvent);
            // 
            // answer2BTN
            // 
            this.answer2BTN.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer2BTN.Location = new System.Drawing.Point(107, 191);
            this.answer2BTN.Name = "answer2BTN";
            this.answer2BTN.Size = new System.Drawing.Size(231, 110);
            this.answer2BTN.TabIndex = 4;
            this.answer2BTN.Text = "button2";
            this.answer2BTN.UseVisualStyleBackColor = true;
            this.answer2BTN.Click += new System.EventHandler(this.ClickButtonEvent);
            // 
            // answer3BTN
            // 
            this.answer3BTN.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer3BTN.Location = new System.Drawing.Point(913, 68);
            this.answer3BTN.Name = "answer3BTN";
            this.answer3BTN.Size = new System.Drawing.Size(231, 110);
            this.answer3BTN.TabIndex = 5;
            this.answer3BTN.Text = "button3";
            this.answer3BTN.UseVisualStyleBackColor = true;
            this.answer3BTN.Click += new System.EventHandler(this.ClickButtonEvent);
            // 
            // answer4BTN
            // 
            this.answer4BTN.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer4BTN.Location = new System.Drawing.Point(913, 184);
            this.answer4BTN.Name = "answer4BTN";
            this.answer4BTN.Size = new System.Drawing.Size(231, 110);
            this.answer4BTN.TabIndex = 6;
            this.answer4BTN.Text = "button4";
            this.answer4BTN.UseVisualStyleBackColor = true;
            this.answer4BTN.Click += new System.EventHandler(this.ClickButtonEvent);
            // 
            // mathsAnswerBTN
            // 
            this.mathsAnswerBTN.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathsAnswerBTN.Location = new System.Drawing.Point(515, 461);
            this.mathsAnswerBTN.Name = "mathsAnswerBTN";
            this.mathsAnswerBTN.Size = new System.Drawing.Size(231, 110);
            this.mathsAnswerBTN.TabIndex = 7;
            this.mathsAnswerBTN.Text = "Submit";
            this.mathsAnswerBTN.UseVisualStyleBackColor = true;
            this.mathsAnswerBTN.Click += new System.EventHandler(this.mathsAnswerBTN_Click);
            // 
            // mathsAnswerTB
            // 
            this.mathsAnswerTB.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathsAnswerTB.Location = new System.Drawing.Point(515, 423);
            this.mathsAnswerTB.Name = "mathsAnswerTB";
            this.mathsAnswerTB.Size = new System.Drawing.Size(231, 32);
            this.mathsAnswerTB.TabIndex = 8;
            // 
            // subjectPB
            // 
            this.subjectPB.Image = global::Dalek_V_Cybermen.Properties.Resources.Maths;
            this.subjectPB.Location = new System.Drawing.Point(344, 75);
            this.subjectPB.Name = "subjectPB";
            this.subjectPB.Size = new System.Drawing.Size(563, 342);
            this.subjectPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.subjectPB.TabIndex = 9;
            this.subjectPB.TabStop = false;
            // 
            // timeTimelbl
            // 
            this.timeTimelbl.AutoSize = true;
            this.timeTimelbl.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTimelbl.Location = new System.Drawing.Point(979, 21);
            this.timeTimelbl.Name = "timeTimelbl";
            this.timeTimelbl.Size = new System.Drawing.Size(104, 40);
            this.timeTimelbl.TabIndex = 10;
            this.timeTimelbl.Text = "Time:";
            // 
            // instructionsLBL
            // 
            this.instructionsLBL.AutoSize = true;
            this.instructionsLBL.BackColor = System.Drawing.Color.Transparent;
            this.instructionsLBL.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLBL.Location = new System.Drawing.Point(55, 574);
            this.instructionsLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructionsLBL.Name = "instructionsLBL";
            this.instructionsLBL.Size = new System.Drawing.Size(652, 38);
            this.instructionsLBL.TabIndex = 18;
            this.instructionsLBL.Text = "please select 1 of the 4 buttons as an answer";
            // 
            // TheGameQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1220, 628);
            this.Controls.Add(this.instructionsLBL);
            this.Controls.Add(this.timeTimelbl);
            this.Controls.Add(this.subjectPB);
            this.Controls.Add(this.mathsAnswerTB);
            this.Controls.Add(this.mathsAnswerBTN);
            this.Controls.Add(this.answer4BTN);
            this.Controls.Add(this.answer3BTN);
            this.Controls.Add(this.answer2BTN);
            this.Controls.Add(this.answer1BTN);
            this.Controls.Add(this.timerLBL);
            this.Controls.Add(this.questionLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TheGameQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheGameQuiz";
            ((System.ComponentModel.ISupportInitialize)(this.subjectPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer questionTimer;
        private System.Windows.Forms.Label questionLBL;
        private System.Windows.Forms.Label timerLBL;
        private System.Windows.Forms.Button answer1BTN;
        private System.Windows.Forms.Button answer2BTN;
        private System.Windows.Forms.Button answer3BTN;
        private System.Windows.Forms.Button answer4BTN;
        private System.Windows.Forms.Button mathsAnswerBTN;
        private System.Windows.Forms.TextBox mathsAnswerTB;
        private System.Windows.Forms.PictureBox subjectPB;
        private System.Windows.Forms.Label timeTimelbl;
        private System.Windows.Forms.Label instructionsLBL;
    }
}