using program_lab1.Task2;
//using program_lab2;

namespace program_lab1
{
    public partial class CalculatingForm : Form
    {
        public CalculatingForm()
        {
            InitializeComponent();
        }
        private void Calculate_button_Click(object sender, EventArgs e)
        {
            ClassForСalculations classForСalculations = new();
            double xn = Convert.ToDouble(Xn_textBox.Text);
            double xK = Convert.ToDouble(Xk_textBox.Text);
            double h = Convert.ToDouble(h_textBox.Text);
            double a = Convert.ToDouble(a_textBox.Text);

            dataGridView.Rows.Clear();
            chart.Series[0].Points.Clear();

            classForСalculations.Tab(xn, xK, h, a);
            for (int i = 0; i < classForСalculations.n; i++)
            {
                dataGridView.Rows.Add(Math.Round(classForСalculations.xy[i, 0], 2).ToString(),
                    Math.Round(classForСalculations.xy[i, 1], 3).ToString());
                chart.Series[0].Points.AddXY(classForСalculations.xy[i, 0], classForСalculations.xy[i, 1]);
            }
        }

        private void CalculatingForm_Load(object sender, EventArgs e)
        {

        }
        private void одновимірніМасивиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new();
            form1.Show();
            this.Hide();
        }
        private void двовимірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new();
            form2.Show();
            this.Hide();
        }

        private void модульнеТестуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            program_lab2.Form1 unitTestForm = new();
            unitTestForm.Show();
            this.Hide();
        }
    }
}
