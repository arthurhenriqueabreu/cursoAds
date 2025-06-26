namespace Calculadora2
{
    public partial class Form1 : Form
    {
        string num1, num2, operador;
        double estagio = 1, resultado = 0, num1Double, num2Double;

        public Form1()
        {
            InitializeComponent();
            lblResultado.Text = resultado.ToString();
        }
        private void Operacao(string operador)
        {
            switch (operador)
            {
                case "+":
                    resultado = (num1Double + num2Double);
                    lblResultado.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = num1Double - num2Double;
                    lblResultado.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = num1Double * num2Double;
                    lblResultado.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = num2Double != 0 ? num1Double / num2Double : 0;
                    lblResultado.Text = resultado.ToString();
                    break;
                default:
                    resultado = 0;
                    break;
            }
        }
        private void AdicionarNumero(int numero)
        {
            if (estagio == 1)
            {
                num1 += numero.ToString();
                lblResultado.Text = num1;
            }
            else if (estagio == 2)
            {
                num2 += numero.ToString();
                lblResultado.Text = num2;
            }
            else if (estagio == 3)
            {
                num1Double += resultado;
                num1 = num1Double.ToString();
            }
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            AdicionarNumero(1);
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            AdicionarNumero(2);
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            AdicionarNumero(3);
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            AdicionarNumero(4);
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            AdicionarNumero(5);
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            AdicionarNumero(6);
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            AdicionarNumero(7);
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            AdicionarNumero(8);
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            AdicionarNumero(9);
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            AdicionarNumero(0);
        }

        private void btnAdittion_Click(object sender, EventArgs e)
        {
            estagio = 2;
            operador = "+";
            lblResultado.Text = operador;
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            estagio = 2;
            operador = "-";
            lblResultado.Text = operador;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            estagio = 2;
            operador = "/";
            lblResultado.Text = operador;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            estagio = 2;
            operador = "*";
            lblResultado.Text = operador;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(num1) && !string.IsNullOrEmpty(num2))
            {
                num1Double = double.Parse(num1);
                num2Double = double.Parse(num2);
                Operacao(operador);

                num1 = resultado.ToString(); // Resultado vira o novo num1
                num2 = "";                   // Limpa num2 para possível próxima operação
                estagio = 3;
            }

            lblResultado.Text = resultado.ToString();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (estagio == 1) {
                if (num1.Length != 1){
                    num1 = num1.Remove(num1.Length - 1, 1);
                    num1Double = double.Parse(num1);
                    lblResultado.Text = num1;
                }
                else{
                    num1 = "0";
                    num1Double = double.Parse(num1);
                    lblResultado.Text = num1;
                }
                
            } else if (estagio == 2)
            {
                if(num2.Length != 1)
                {
                    num2 = num2.Remove(num2.Length - 1, 1);
                    num2Double = double.Parse(num2);
                    lblResultado.Text = num2;
                }
                else
                {
                    num2 = "0";
                    num2Double = double.Parse(num2);
                    lblResultado.Text = num2;
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            estagio = 1;
            num1 = "";
            num2 = "";
            operador = "";
            resultado = 0;
            lblResultado.Text = resultado.ToString();
        }
    }
}
