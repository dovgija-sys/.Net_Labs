namespace program_lab1
{
    partial class CalculatingForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Xn_label = new Label();
            Xk_label = new Label();
            h_label = new Label();
            a_label = new Label();
            Xn_textBox = new TextBox();
            a_textBox = new TextBox();
            h_textBox = new TextBox();
            Xk_textBox = new TextBox();
            dataGridView = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            y = new DataGridViewTextBoxColumn();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Calculate_button = new Button();
            menuStrip1 = new MenuStrip();
            одновимірніМасивиToolStripMenuItem = new ToolStripMenuItem();
            одновимірніМасивиToolStripMenuItem1 = new ToolStripMenuItem();
            двовимірніМасивиToolStripMenuItem = new ToolStripMenuItem();
            модульнеТестуванняToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Xn_label
            // 
            Xn_label.AutoSize = true;
            Xn_label.Location = new Point(35, 46);
            Xn_label.Name = "Xn_label";
            Xn_label.Size = new Size(26, 20);
            Xn_label.TabIndex = 0;
            Xn_label.Text = "Xn";
            // 
            // Xk_label
            // 
            Xk_label.AutoSize = true;
            Xk_label.Location = new Point(127, 46);
            Xk_label.Name = "Xk_label";
            Xk_label.Size = new Size(25, 20);
            Xk_label.TabIndex = 1;
            Xk_label.Text = "Xk";
            // 
            // h_label
            // 
            h_label.AutoSize = true;
            h_label.Location = new Point(224, 46);
            h_label.Name = "h_label";
            h_label.Size = new Size(17, 20);
            h_label.TabIndex = 2;
            h_label.Text = "h";
            // 
            // a_label
            // 
            a_label.AutoSize = true;
            a_label.Location = new Point(317, 46);
            a_label.Name = "a_label";
            a_label.Size = new Size(17, 20);
            a_label.TabIndex = 3;
            a_label.Text = "a";
            // 
            // Xn_textBox
            // 
            Xn_textBox.Location = new Point(35, 82);
            Xn_textBox.Name = "Xn_textBox";
            Xn_textBox.Size = new Size(61, 27);
            Xn_textBox.TabIndex = 4;
            // 
            // a_textBox
            // 
            a_textBox.Location = new Point(317, 82);
            a_textBox.Name = "a_textBox";
            a_textBox.Size = new Size(61, 27);
            a_textBox.TabIndex = 5;
            // 
            // h_textBox
            // 
            h_textBox.Location = new Point(224, 82);
            h_textBox.Name = "h_textBox";
            h_textBox.Size = new Size(61, 27);
            h_textBox.TabIndex = 6;
            // 
            // Xk_textBox
            // 
            Xk_textBox.Location = new Point(127, 82);
            Xk_textBox.Name = "Xk_textBox";
            Xk_textBox.Size = new Size(61, 27);
            Xk_textBox.TabIndex = 7;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { x, y });
            dataGridView.Location = new Point(34, 132);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(300, 306);
            dataGridView.TabIndex = 8;
            // 
            // x
            // 
            x.HeaderText = "x";
            x.MinimumWidth = 6;
            x.Name = "x";
            x.ReadOnly = true;
            x.Width = 125;
            // 
            // y
            // 
            y.HeaderText = "y";
            y.MinimumWidth = 6;
            y.Name = "y";
            y.ReadOnly = true;
            y.Width = 125;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(380, 132);
            chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(824, 306);
            chart.TabIndex = 9;
            chart.Text = "chart";
            // 
            // Calculate_button
            // 
            Calculate_button.Location = new Point(418, 82);
            Calculate_button.Name = "Calculate_button";
            Calculate_button.Size = new Size(82, 27);
            Calculate_button.TabIndex = 10;
            Calculate_button.Text = "Calculate";
            Calculate_button.UseVisualStyleBackColor = true;
            Calculate_button.Click += Calculate_button_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { одновимірніМасивиToolStripMenuItem, модульнеТестуванняToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1244, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // одновимірніМасивиToolStripMenuItem
            // 
            одновимірніМасивиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { одновимірніМасивиToolStripMenuItem1, двовимірніМасивиToolStripMenuItem });
            одновимірніМасивиToolStripMenuItem.Name = "одновимірніМасивиToolStripMenuItem";
            одновимірніМасивиToolStripMenuItem.Size = new Size(158, 24);
            одновимірніМасивиToolStripMenuItem.Text = "Робота з масивами";
            // 
            // одновимірніМасивиToolStripMenuItem1
            // 
            одновимірніМасивиToolStripMenuItem1.Name = "одновимірніМасивиToolStripMenuItem1";
            одновимірніМасивиToolStripMenuItem1.Size = new Size(239, 26);
            одновимірніМасивиToolStripMenuItem1.Text = "Одновимірні масиви";
            одновимірніМасивиToolStripMenuItem1.Click += одновимірніМасивиToolStripMenuItem1_Click;
            // 
            // двовимірніМасивиToolStripMenuItem
            // 
            двовимірніМасивиToolStripMenuItem.Name = "двовимірніМасивиToolStripMenuItem";
            двовимірніМасивиToolStripMenuItem.Size = new Size(239, 26);
            двовимірніМасивиToolStripMenuItem.Text = "Двовимірні масиви";
            двовимірніМасивиToolStripMenuItem.Click += двовимірніМасивиToolStripMenuItem_Click;
            // 
            // модульнеТестуванняToolStripMenuItem
            // 
            модульнеТестуванняToolStripMenuItem.Name = "модульнеТестуванняToolStripMenuItem";
            модульнеТестуванняToolStripMenuItem.Size = new Size(173, 24);
            модульнеТестуванняToolStripMenuItem.Text = "Модульне тестування";
            модульнеТестуванняToolStripMenuItem.Click += модульнеТестуванняToolStripMenuItem_Click;
            // 
            // CalculatingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 450);
            Controls.Add(Calculate_button);
            Controls.Add(chart);
            Controls.Add(dataGridView);
            Controls.Add(Xk_textBox);
            Controls.Add(h_textBox);
            Controls.Add(a_textBox);
            Controls.Add(Xn_textBox);
            Controls.Add(a_label);
            Controls.Add(h_label);
            Controls.Add(Xk_label);
            Controls.Add(Xn_label);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CalculatingForm";
            Text = "Form1";
            Load += CalculatingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Xn_label;
        private Label Xk_label;
        private Label h_label;
        private Label a_label;
        private TextBox Xn_textBox;
        private TextBox a_textBox;
        private TextBox h_textBox;
        private TextBox Xk_textBox;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Button Calculate_button;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem одновимірніМасивиToolStripMenuItem;
        private ToolStripMenuItem одновимірніМасивиToolStripMenuItem1;
        private ToolStripMenuItem двовимірніМасивиToolStripMenuItem;
        private ToolStripMenuItem модульнеТестуванняToolStripMenuItem;
    }
}
