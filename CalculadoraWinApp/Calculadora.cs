namespace CalculadoraWinApp
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        private void button1_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += ",";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = "";
            lblOperacao.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtOperacao.Text);

            lblOperacao.Text = txtOperacao.Text + " +";
            txtOperacao.Text = "";
            operacao = "SOMAR";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtOperacao.Text);

            lblOperacao.Text = txtOperacao.Text + " -";
            txtOperacao.Text = "";
            operacao = "SUBTRAIR";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtOperacao.Text);

            lblOperacao.Text = txtOperacao.Text + " *";
            txtOperacao.Text = "";
            operacao = "MULTIPLICAR";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtOperacao.Text);

            lblOperacao.Text = txtOperacao.Text + " /";
            txtOperacao.Text = "";
            operacao = "DIVIDIR";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDecimal(txtOperacao.Text);

            switch (operacao)
            {
                case "SOMAR":

                    txtOperacao.Text = "";
                    lblOperacao.Text = "";

                    txtResultado.Text = Convert.ToString(valor1 + valor2);

                    valor1 = 0;
                    valor2 = 0;
                    operacao = "";

                    break;

                case "SUBTRAIR":

                    txtOperacao.Text = "";
                    lblOperacao.Text = "";

                    txtResultado.Text = Convert.ToString(valor1 - valor2);

                    valor1 = 0;
                    valor2 = 0;
                    operacao = "";

                    break;

                case "MULTIPLICAR":

                    txtOperacao.Text = "";
                    lblOperacao.Text = "";

                    txtResultado.Text = Convert.ToString(valor1 * valor2);

                    valor1 = 0;
                    valor2 = 0;
                    operacao = "";

                    break;

                case "DIVIDIR":

                    txtOperacao.Text = "";
                    lblOperacao.Text = "";

                    txtResultado.Text = Convert.ToString(valor1 / valor2);

                    valor1 = 0;
                    valor2 = 0;
                    operacao = "";

                    break;

                default:
                    break;
            }
        }
    }
}