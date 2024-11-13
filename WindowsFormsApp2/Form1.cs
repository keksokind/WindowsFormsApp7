using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public readonly char[] correctAnswers = {
            'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D',
            'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'B'
        };

        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Driver's License Exam Application!");
        }

        private void btnGradeExam_Click(object sender, EventArgs e)
        {
            string filePath = @"answers.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found: " + filePath);
                return;
            }

            string[] studentAnswers;
            try
            {
                studentAnswers = File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading the file: " + ex.Message);
                return;
            }
            if (studentAnswers.Length != correctAnswers.Length)
            {
                MessageBox.Show("The file does not contain the correct number of answers.");
                return;
            }

            int correctCount = 0;
            List<int> incorrectQuestions = new List<int>();

            for (int i = 0; i < correctAnswers.Length; i++)
            {
                if (studentAnswers[i][0] == correctAnswers[i])
                {
                    correctCount++;
                }
                else
                {
                    incorrectQuestions.Add(i + 1);
                }
            }

            int incorrectCount = correctAnswers.Length - correctCount;
            bool passed = correctCount >= 15;

            labelResult.Text = passed ? "Result: Passed" : "Result: Failed";
            labelCorrect.Text = $"Correct Answers: {correctCount}";
            labelIncorrect.Text = $"Incorrect Answers: {incorrectCount}";
            labelIncorrectQuestions.Text = "Incorrect Questions: " + string.Join(", ", incorrectQuestions);
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void labelCorrect_Click(object sender, EventArgs e)
        {

        }
    }
}

