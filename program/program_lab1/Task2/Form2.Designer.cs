namespace program_lab1.Task2
{
    partial class Form2
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
            Exit_button_Form2 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            N_textBox = new TextBox();
            M_textBox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Exit_button_Form2
            // 
            Exit_button_Form2.Location = new Point(899, 409);
            Exit_button_Form2.Name = "Exit_button_Form2";
            Exit_button_Form2.Size = new Size(94, 29);
            Exit_button_Form2.TabIndex = 0;
            Exit_button_Form2.Text = "Exit";
            Exit_button_Form2.UseVisualStyleBackColor = true;
            Exit_button_Form2.Click += Exit_button_Form2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(342, 229);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(389, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 2;
            label1.Text = "N = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 65);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 3;
            label2.Text = "M = ";
            // 
            // textBox1
            // 
            N_textBox.Location = new Point(435, 12);
            N_textBox.Name = "textBox1";
            N_textBox.Size = new Size(125, 27);
            N_textBox.TabIndex = 4;
            // 
            // textBox2
            // 
            M_textBox.Location = new Point(435, 62);
            M_textBox.Name = "textBox2";
            M_textBox.Size = new Size(125, 27);
            M_textBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 131);
            label3.Name = "label3";
            label3.Size = new Size(521, 20);
            label3.TabIndex = 6;
            label3.Text = "the number of positive elements of this array located above the left diagonal.";
            // 
            // button1
            // 
            button1.Location = new Point(778, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(M_textBox);
            Controls.Add(N_textBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(Exit_button_Form2);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exit_button_Form2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox N_textBox;
        private TextBox M_textBox;
        private Label label3;
        private Button button1;
    }
}