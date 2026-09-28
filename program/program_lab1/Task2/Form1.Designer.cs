namespace program_lab1.Task2
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
            Exit_button_Form1 = new Button();
            dataGridView1 = new DataGridView();
            Direction = new DataGridViewTextBoxColumn();
            Power = new DataGridViewTextBoxColumn();
            label1 = new Label();
            Array1_textBox = new TextBox();
            Calculate_button = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Exit_button_Form1
            // 
            Exit_button_Form1.Location = new Point(1009, 409);
            Exit_button_Form1.Name = "Exit_button_Form1";
            Exit_button_Form1.Size = new Size(94, 29);
            Exit_button_Form1.TabIndex = 0;
            Exit_button_Form1.Text = "Exit";
            Exit_button_Form1.UseVisualStyleBackColor = true;
            Exit_button_Form1.Click += Exit_button_Form1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Direction, Power });
            dataGridView1.Location = new Point(22, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(303, 426);
            dataGridView1.TabIndex = 1;
            // 
            // Direction
            // 
            Direction.HeaderText = "Direction";
            Direction.MinimumWidth = 6;
            Direction.Name = "Direction";
            Direction.Width = 125;
            // 
            // Power
            // 
            Power.HeaderText = "Power";
            Power.MinimumWidth = 6;
            Power.Name = "Power";
            Power.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 15);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 2;
            label1.Text = "N = ";
            // 
            // Array1_textBox
            // 
            Array1_textBox.Location = new Point(401, 15);
            Array1_textBox.Name = "Array1_textBox";
            Array1_textBox.Size = new Size(125, 27);
            Array1_textBox.TabIndex = 3;
            // 
            // Calculate_button
            // 
            Calculate_button.Location = new Point(896, 409);
            Calculate_button.Name = "Calculate_button";
            Calculate_button.Size = new Size(94, 29);
            Calculate_button.TabIndex = 4;
            Calculate_button.Text = "Calculate";
            Calculate_button.UseVisualStyleBackColor = true;
            Calculate_button.Click += Calculate_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 70);
            label2.Name = "label2";
            label2.Size = new Size(437, 20);
            label2.TabIndex = 5;
            label2.Text = "how many days the south wind blew at a speed exceeding 8 m/s:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 450);
            Controls.Add(label2);
            Controls.Add(Calculate_button);
            Controls.Add(Array1_textBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(Exit_button_Form1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exit_button_Form1;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox Array1_textBox;
        private Button Calculate_button;
        private Label label2;
        private DataGridViewTextBoxColumn Direction;
        private DataGridViewTextBoxColumn Power;
    }
}