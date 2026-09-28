using program_lab2.Classes;
namespace program_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalc1_Click(object sender, EventArgs e)
        {
            try
            {
                var calc = new Calculation_Task1(
                    Convert.ToInt32(txtA1.Text),
                    Convert.ToInt32(txtB1.Text),
                    Convert.ToInt32(txtC1.Text));

                lblRes1.Text = "Результат: " + calc.Calculate().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Кнопка для Завдання 2
        private void btnCalc2_Click(object sender, EventArgs e)
        {
            try
            {
                var calc = new Calculation_Task2(
                    Convert.ToInt32(txtA2.Text),
                    Convert.ToInt32(txtB2.Text));

                lblRes2.Text = "Сума: " + calc.CalculateSum().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Кнопка для Завдання 3
        private void btnCalc3_Click(object sender, EventArgs e)
        {
            try
            {
                var triangle = new Calculation_Task3(
                    Convert.ToDouble(txtLegA.Text),
                    Convert.ToDouble(txtLegB.Text));

                lblHypotenuse.Text = "Гіпотенуза: " + Math.Round(triangle.GetHypotenuse(), 2);
                lblAngles.Text = $"Кут A: {Math.Round(triangle.GetAngleA(), 2)}°, Кут B: {Math.Round(triangle.GetAngleB(), 2)}°";
                lblRadius.Text = "Радіус вписаного кола: " + Math.Round(triangle.GetInscribedRadius(), 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Кнопка "Закрити"
        private void btnClose_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }
    }
}