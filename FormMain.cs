namespace BmiCalculatorApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelResult.Hide();
            labelStat.Hide();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(textBoxHeight.Text) / 100;
            double mass = Convert.ToDouble(textBoxMass.Text);
            double result = Math.Round(mass / Math.Pow(height, 2), 2);

            labelResult.Show();
            labelITM.Text = result.ToString();

            if (result < 18.5)
            {
                labelStat.Text = "Pothranjen";
                labelStat.ForeColor = Color.Red;
                labelStat.BackColor = Color.Black;
            }
            else if (result < 25)
            {
                labelStat.Text = "Zdrav";
                labelStat.ForeColor = Color.Green;
                labelStat.BackColor = Color.Black;
            }
            else if (result < 30)
            {
                labelStat.Text = "Prekomjerna težina";
                labelStat.ForeColor = Color.Yellow;
                labelStat.BackColor = Color.Black;
            }
            else
            {
                labelStat.Text = "Pretil";
                labelStat.ForeColor = Color.DarkRed;
                labelStat.BackColor = Color.Black;
            }

            labelStat.Show();
        }
    }
}
