namespace program_lab2
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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            Close_button = new Button();
            txtA1 = new TextBox();
            txtB1 = new TextBox();
            txtC1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblRes1 = new Label();
            btnCalc1 = new Button();
            txtA2 = new TextBox();
            txtB2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lblRes2 = new Label();
            btnCalc2 = new Button();
            btnCalc3 = new Button();
            txtLegA = new TextBox();
            txtLegB = new TextBox();
            label6 = new Label();
            label7 = new Label();
            lblHypotenuse = new Label();
            lblAngles = new Label();
            lblRadius = new Label();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 306);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCalc1);
            tabPage1.Controls.Add(lblRes1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtC1);
            tabPage1.Controls.Add(txtB1);
            tabPage1.Controls.Add(txtA1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 273);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Task1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnCalc2);
            tabPage2.Controls.Add(lblRes2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtB2);
            tabPage2.Controls.Add(txtA2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 273);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Task2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lblRadius);
            tabPage3.Controls.Add(lblAngles);
            tabPage3.Controls.Add(lblHypotenuse);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(txtLegB);
            tabPage3.Controls.Add(txtLegA);
            tabPage3.Controls.Add(btnCalc3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 273);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Task3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Close_button
            // 
            Close_button.Location = new Point(694, 355);
            Close_button.Name = "Close_button";
            Close_button.Size = new Size(94, 29);
            Close_button.TabIndex = 1;
            Close_button.Text = "exit";
            Close_button.UseVisualStyleBackColor = true;
            // 
            // txtA1
            // 
            txtA1.Location = new Point(73, 46);
            txtA1.Name = "txtA1";
            txtA1.Size = new Size(57, 27);
            txtA1.TabIndex = 0;
            // 
            // txtB1
            // 
            txtB1.Location = new Point(258, 46);
            txtB1.Name = "txtB1";
            txtB1.Size = new Size(57, 27);
            txtB1.TabIndex = 1;
            // 
            // txtC1
            // 
            txtC1.Location = new Point(455, 46);
            txtC1.Name = "txtC1";
            txtC1.Size = new Size(57, 27);
            txtC1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 49);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 3;
            label1.Text = "a = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 49);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 4;
            label2.Text = "c = ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 49);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 5;
            label3.Text = "b = ";
            // 
            // lblRes1
            // 
            lblRes1.AutoSize = true;
            lblRes1.Location = new Point(591, 49);
            lblRes1.Name = "lblRes1";
            lblRes1.Size = new Size(57, 20);
            lblRes1.TabIndex = 6;
            lblRes1.Text = "lblRes1";
            // 
            // btnCalc1
            // 
            btnCalc1.Location = new Point(690, 224);
            btnCalc1.Name = "btnCalc1";
            btnCalc1.Size = new Size(94, 29);
            btnCalc1.TabIndex = 7;
            btnCalc1.Text = "Calculate";
            btnCalc1.UseVisualStyleBackColor = true;
            btnCalc1.Click += btnCalc1_Click;
            // 
            // txtA2
            // 
            txtA2.Location = new Point(97, 46);
            txtA2.Name = "txtA2";
            txtA2.Size = new Size(59, 27);
            txtA2.TabIndex = 0;
            // 
            // txtB2
            // 
            txtB2.Location = new Point(289, 46);
            txtB2.Name = "txtB2";
            txtB2.Size = new Size(59, 27);
            txtB2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 49);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 2;
            label4.Text = "a = ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(233, 49);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 3;
            label5.Text = "b = ";
            // 
            // lblRes2
            // 
            lblRes2.AutoSize = true;
            lblRes2.Location = new Point(605, 49);
            lblRes2.Name = "lblRes2";
            lblRes2.Size = new Size(57, 20);
            lblRes2.TabIndex = 4;
            lblRes2.Text = "lblRes2";
            // 
            // btnCalc2
            // 
            btnCalc2.Location = new Point(690, 227);
            btnCalc2.Name = "btnCalc2";
            btnCalc2.Size = new Size(94, 29);
            btnCalc2.TabIndex = 5;
            btnCalc2.Text = "Calculate";
            btnCalc2.UseVisualStyleBackColor = true;
            btnCalc2.Click += btnCalc2_Click;
            // 
            // btnCalc3
            // 
            btnCalc3.Location = new Point(690, 221);
            btnCalc3.Name = "btnCalc3";
            btnCalc3.Size = new Size(94, 29);
            btnCalc3.TabIndex = 0;
            btnCalc3.Text = "Calculate";
            btnCalc3.UseVisualStyleBackColor = true;
            btnCalc3.Click += btnCalc3_Click;
            // 
            // txtLegA
            // 
            txtLegA.Location = new Point(124, 34);
            txtLegA.Name = "txtLegA";
            txtLegA.Size = new Size(56, 27);
            txtLegA.TabIndex = 1;
            // 
            // txtLegB
            // 
            txtLegB.Location = new Point(301, 34);
            txtLegB.Name = "txtLegB";
            txtLegB.Size = new Size(56, 27);
            txtLegB.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 37);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 3;
            label6.Text = "a = ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(245, 37);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 4;
            label7.Text = "b = ";
            // 
            // lblHypotenuse
            // 
            lblHypotenuse.AutoSize = true;
            lblHypotenuse.Location = new Point(577, 46);
            lblHypotenuse.Name = "lblHypotenuse";
            lblHypotenuse.Size = new Size(105, 20);
            lblHypotenuse.TabIndex = 5;
            lblHypotenuse.Text = "lblHypotenuse";
            // 
            // lblAngles
            // 
            lblAngles.AutoSize = true;
            lblAngles.Location = new Point(577, 97);
            lblAngles.Name = "lblAngles";
            lblAngles.Size = new Size(71, 20);
            lblAngles.TabIndex = 6;
            lblAngles.Text = "lblAngles";
            // 
            // lblRadius
            // 
            lblRadius.AutoSize = true;
            lblRadius.Location = new Point(577, 145);
            lblRadius.Name = "lblRadius";
            lblRadius.Size = new Size(70, 20);
            lblRadius.TabIndex = 7;
            lblRadius.Text = "lblRadius";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(Close_button);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtC1;
        private TextBox txtB1;
        private TextBox txtA1;
        private Button Close_button;
        private Button btnCalc1;
        private Label lblRes1;
        private Button btnCalc2;
        private Label lblRes2;
        private Label label5;
        private Label label4;
        private TextBox txtB2;
        private TextBox txtA2;
        private TextBox txtLegB;
        private TextBox txtLegA;
        private Button btnCalc3;
        private Label label7;
        private Label label6;
        private Label lblRadius;
        private Label lblAngles;
        private Label lblHypotenuse;
    }
}
