namespace CalculatorApplication
{
    public partial class frmCalculator : Form
    {
        private CalculatorClass cal;
        double num1;
        double num2;
        string calc;

        public frmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void txtBoxInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxInput2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDisplayTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(txtBoxInput1.Text);
            num2 = Double.Parse(txtBoxInput2.Text);
            calc = cbOperator.Text;
             

                switch (calc)
                {
                    case "+":
                        cal.CalculateEvent += new Formula<double>(cal.GetSum);
                        lblDisplayTotal.Text = cal.GetSum(num1 , num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                        break;
                    case "-":
                        cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                        lblDisplayTotal.Text = cal.GetDifference(num1 , num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
                        break;
                    case "*":
                        cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                        lblDisplayTotal.Text = cal.GetProduct(num1 , num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
                        break;
                    case "/":
                        cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                        lblDisplayTotal.Text = cal.GetQuotient(num1 , num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
                        break;

                    default:
                        MessageBox.Show ("Invalid Input or Something is Missing. Please Try Again!");
                        return;
                }
        }
    }
}
