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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questions));
            this.questionLBL = new System.Windows.Forms.Label();
            this.answer1BTN = new System.Windows.Forms.Button();
            this.answer2BTN = new System.Windows.Forms.Button();
            this.answer3BTN = new System.Windows.Forms.Button();
            this.answer4BTN = new System.Windows.Forms.Button();
            this.subjectPB = new System.Windows.Forms.PictureBox();
            this.mathsAnswerBTN = new System.Windows.Forms.Button();
            this.mathsAnswerTB = new System.Windows.Forms.TextBox();
            this.questionTimer = new System.Windows.Forms.Timer(this.components);
            this.timerLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subjectPB)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLBL
            // 
            this.questionLBL.AutoSize = true;
            this.questionLBL.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLBL.Location = new System.Drawing.Point(12, 66);
            this.questionLBL.Name = "questionLBL";
            this.questionLBL.Size = new System.Drawing.Size(410, 54);
            this.questionLBL.TabIndex = 0;
            this.questionLBL.Text = "Question goes here";
            // 
            // answer1BTN
            // 
            this.answer1BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer1BTN.Location = new System.Drawing.Point(72, 186);
            this.answer1BTN.Name = "answer1BTN";
            this.answer1BTN.Size = new System.Drawing.Size(292, 138);
            this.answer1BTN.TabIndex = 1;
            this.answer1BTN.Text = "1";
            this.answer1BTN.UseVisualStyleBackColor = true;
            this.answer1BTN.Click += new System.EventHandler(this.AnswerButtonEvent);
            // 
            // answer2BTN
            // 
            this.answer2BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer2BTN.Location = new System.Drawing.Point(1029, 186);
            this.answer2BTN.Name = "answer2BTN";
            this.answer2BTN.Size = new System.Drawing.Size(292, 138);
            this.answer2BTN.TabIndex = 2;
            this.answer2BTN.Text = "2";
            this.answer2BTN.UseVisualStyleBackColor = true;
            this.answer2BTN.Click += new System.EventHandler(this.AnswerButtonEvent);
            // 
            // answer3BTN
            // 
            this.answer3BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer3BTN.Location = new System.Drawing.Point(72, 368);
            this.answer3BTN.Name = "answer3BTN";
            this.answer3BTN.Size = new System.Drawing.Size(292, 138);
            this.answer3BTN.TabIndex = 3;
            this.answer3BTN.Text = "3";
            this.answer3BTN.UseVisualStyleBackColor = true;
            this.answer3BTN.Click += new System.EventHandler(this.AnswerButtonEvent);
            // 
            // answer4BTN
            // 
            this.answer4BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer4BTN.Location = new System.Drawing.Point(1029, 368);
            this.answer4BTN.Name = "answer4BTN";
            this.answer4BTN.Size = new System.Drawing.Size(292, 138);
            this.answer4BTN.TabIndex = 4;
            this.answer4BTN.Text = "4";
            this.answer4BTN.UseVisualStyleBackColor = true;
            this.answer4BTN.Click += new System.EventHandler(this.AnswerButtonEvent);
            // 
            // subjectPB
            // 
            this.subjectPB.Image = ((System.Drawing.Image)(resources.GetObject("subjectPB.Image")));
            this.subjectPB.Location = new System.Drawing.Point(444, 186);
            this.subjectPB.Name = "subjectPB";
            this.subjectPB.Size = new System.Drawing.Size(535, 320);
            this.subjectPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.subjectPB.TabIndex = 5;
            this.subjectPB.TabStop = false;
            this.subjectPB.Visible = false;
            // 
            // mathsAnswerBTN
            // 
            this.mathsAnswerBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathsAnswerBTN.Location = new System.Drawing.Point(567, 690);
            this.mathsAnswerBTN.Name = "mathsAnswerBTN";
            this.mathsAnswerBTN.Size = new System.Drawing.Size(292, 138);
            this.mathsAnswerBTN.TabIndex = 6;
            this.mathsAnswerBTN.Text = "Submit answer";
            this.mathsAnswerBTN.UseVisualStyleBackColor = true;
            this.mathsAnswerBTN.Click += new System.EventHandler(this.mathsAnswerBTN_Click);
            // 
            // mathsAnswerTB
            // 
            this.mathsAnswerTB.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathsAnswerTB.Location = new System.Drawing.Point(567, 638);
            this.mathsAnswerTB.Name = "mathsAnswerTB";
            this.mathsAnswerTB.Size = new System.Drawing.Size(292, 46);
            this.mathsAnswerTB.TabIndex = 7;
            // 
            // questionTimer
            // 
            this.questionTimer.Interval = 1000;
            this.questionTimer.Tick += new System.EventHandler(this.questionTimer_Tick);
            // 
            // timerLBL
            // 
            this.timerLBL.AutoSize = true;
            this.timerLBL.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLBL.Location = new System.Drawing.Point(956, 9);
            this.timerLBL.Name = "timerLBL";
            this.timerLBL.Size = new System.Drawing.Size(140, 54);
            this.timerLBL.TabIndex = 8;
            this.timerLBL.Text = "Timer";
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 840);
            this.Controls.Add(this.timerLBL);
            this.Controls.Add(this.mathsAnswerTB);
            this.Controls.Add(this.mathsAnswerBTN);
            this.Controls.Add(this.subjectPB);
            this.Controls.Add(this.answer4BTN);
            this.Controls.Add(this.answer3BTN);
            this.Controls.Add(this.answer2BTN);
            this.Controls.Add(this.answer1BTN);
            this.Controls.Add(this.questionLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Questions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions";
            ((System.ComponentModel.ISupportInitialize)(this.subjectPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLBL;
        private System.Windows.Forms.Button answer1BTN;
        private System.Windows.Forms.Button answer2BTN;
        private System.Windows.Forms.Button answer3BTN;
        private System.Windows.Forms.Button answer4BTN;
        private System.Windows.Forms.PictureBox subjectPB;
        private System.Windows.Forms.Button mathsAnswerBTN;
        private System.Windows.Forms.TextBox mathsAnswerTB;
        private System.Windows.Forms.Timer questionTimer;
        private System.Windows.Forms.Label timerLBL;
    }
}