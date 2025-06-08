namespace WinFormsCalculator
{
    public partial class CalculatorMainForm : Form
    {
        private readonly MathParser.MathParser _parser;

        public CalculatorMainForm()
        {
            InitializeComponent();
            _parser = new MathParser.MathParser();
        }

        private void BtnEvaluation_Click(object sender, EventArgs e)
        {
            try
            {
                CalculatorDisplayField.Text = _parser.Evaluate(CalculatorDisplayField.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CalculatorDisplayField.Text = "0";
            }
        }

        private void SimpleBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is not null)
            {
                if (CalculatorDisplayField.Text == "0" || string.IsNullOrWhiteSpace(CalculatorDisplayField.Text))
                {
                    CalculatorDisplayField.Text = btn.Tag.ToString();
                }
                else
                {
                    CalculatorDisplayField.Text += btn.Tag.ToString();
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CalculatorDisplayField.Text = "0";
        }
    }
}
