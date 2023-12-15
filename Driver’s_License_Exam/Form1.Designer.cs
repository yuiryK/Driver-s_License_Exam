namespace Driver_s_License_Exam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(22, 26);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Upload test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 82);
            label1.Name = "label1";
            label1.Size = new Size(391, 25);
            label1.TabIndex = 1;
            label1.Text = "Total number of correctly answered questions: 0";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 125);
            label2.Name = "label2";
            label2.Size = new Size(405, 25);
            label2.TabIndex = 2;
            label2.Text = "Total number of incorrectly answered questions: 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 170);
            label3.Name = "label3";
            label3.Size = new Size(389, 25);
            label3.TabIndex = 3;
            label3.Text = "Numbers of the incorrectly answered questions:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 214);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 4;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 239);
            label5.Name = "label5";
            label5.Size = new Size(105, 41);
            label5.TabIndex = 5;
            label5.Text = "Result:";
            label5.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(23, 306);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 385);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Driver's Licens Exam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}