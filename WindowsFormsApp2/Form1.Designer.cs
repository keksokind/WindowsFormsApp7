namespace WindowsFormsApp2
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
            this.labelResult = new System.Windows.Forms.Label();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.labelIncorrect = new System.Windows.Forms.Label();
            this.labelIncorrectQuestions = new System.Windows.Forms.Label();
            this.btnGradeExam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(28, 27);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(45, 16);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Result";
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // labelCorrect
            // 
            this.labelCorrect.AutoSize = true;
            this.labelCorrect.Location = new System.Drawing.Point(28, 99);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(50, 16);
            this.labelCorrect.TabIndex = 1;
            this.labelCorrect.Text = "Correct";
            this.labelCorrect.Click += new System.EventHandler(this.labelCorrect_Click);
            // 
            // labelIncorrect
            // 
            this.labelIncorrect.AutoSize = true;
            this.labelIncorrect.Location = new System.Drawing.Point(28, 190);
            this.labelIncorrect.Name = "labelIncorrect";
            this.labelIncorrect.Size = new System.Drawing.Size(58, 16);
            this.labelIncorrect.TabIndex = 2;
            this.labelIncorrect.Text = "Incorrect";
            // 
            // labelIncorrectQuestions
            // 
            this.labelIncorrectQuestions.AutoSize = true;
            this.labelIncorrectQuestions.Location = new System.Drawing.Point(28, 277);
            this.labelIncorrectQuestions.Name = "labelIncorrectQuestions";
            this.labelIncorrectQuestions.Size = new System.Drawing.Size(121, 16);
            this.labelIncorrectQuestions.TabIndex = 3;
            this.labelIncorrectQuestions.Text = "Incorrect Questions";
            // 
            // btnGradeExam
            // 
            this.btnGradeExam.Location = new System.Drawing.Point(31, 344);
            this.btnGradeExam.Name = "btnGradeExam";
            this.btnGradeExam.Size = new System.Drawing.Size(75, 23);
            this.btnGradeExam.TabIndex = 4;
            this.btnGradeExam.Text = "GradeExam";
            this.btnGradeExam.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGradeExam);
            this.Controls.Add(this.labelIncorrectQuestions);
            this.Controls.Add(this.labelIncorrect);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.labelResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelCorrect;
        private System.Windows.Forms.Label labelIncorrect;
        private System.Windows.Forms.Label labelIncorrectQuestions;
        private System.Windows.Forms.Button btnGradeExam;
    }
}

