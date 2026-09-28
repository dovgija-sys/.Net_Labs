namespace program_lab1.Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_button_Form1_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                var n = Convert.ToInt32(Array1_textBox.Text);
                var array = new Array1(n);
                for (int i = 0; i < array.Length; i++)
                {
                    dataGridView1.Rows.Add(array[i].Direction, array[i].Power.ToString());
                }
                label2.Text = $"how many days the south wind blew at a speed exceeding 8 m/s: {array.Count()} days";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
