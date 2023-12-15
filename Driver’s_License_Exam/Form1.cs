using System;

namespace Driver_s_License_Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Read the selected text file
                string filePath = openFileDialog.FileName;
                string content = File.ReadAllText(filePath);
                content = content.ToLower();
                char[] charArray = content.ToCharArray();
                char[] correctArray = { 'b', 'd', 'a', 'a', 'c', 'a', 'b', 'a', 'c', 'd', 'b', 'c', 'd', 'a', 'd', 'c', 'c', 'b', 'd', 'a' };
                int errors = 0;
                String incorrect_answers = "";
                for (int i = 0; i < correctArray.Length; i++)
                {
                    if (charArray[i] != correctArray[i])
                    {
                        errors++;
                        if (incorrect_answers.Length > 0)
                        {
                            incorrect_answers = incorrect_answers + ", ";
                        }
                        incorrect_answers = incorrect_answers + (i + 1).ToString();

                    } 
                }
                label1.Text = "Total number of correctly answered questions: " + (charArray.Length - errors).ToString();
                label2.Text = "Total number of incorrectly answered questions: " + errors.ToString();
                label4.Text = incorrect_answers;
                label5.Visible = true;
                if (charArray.Length != 20)
                {
                    label1.Text = "Total number of correctly answered questions: 0";
                    label2.Text = "Total number of incorrectly answered questions: 0";
                    label5.ForeColor = Color.Red;
                    label5.Text = "Invalid test file. Must be 20 questions.";

                }
                else if (errors <= 5)
                {
                    label4.Visible = true;
                    label5.ForeColor = Color.Green;
                    label5.Text = "Congratulations! You passed the exam!";
                }
                else
                {
                    label4.Visible = true;
                    label5.ForeColor = Color.Red;
                    label5.Text = "Sorry! You did not pass the exam.";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}