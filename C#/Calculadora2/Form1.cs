// Importa funcionalidade para suporte a cultura (ex: separador decimal)
using System.Globalization;

// Define a classe principal do formulário da calculadora
namespace Calculadora2
{
    public partial class Form1 : Form
    {
        // Variáveis de estado da calculadora
        string num1 = "0", num2 = "0", operador;
        double estagio = 1, resultado = 0, num1Double, num2Double;

        // Construtor do formulário
        public Form1()
        {
            InitializeComponent();
            lblResultado.Text = resultado.ToString();
        }

        // Executa a operação matemática com base no operador selecionado
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

        // Adiciona o número digitado ao número atual (num1 ou num2), atualizando o valor exibido
        private void AdicionarNumero(int numero)
        {
            if (estagio == 1)
            {
                num1 += numero.ToString();
                num1Double = double.Parse(num1);
                lblResultado.Text = num1Double.ToString();
            }
            else if (estagio == 2)
            {
                num2 += numero.ToString();
                num2Double = double.Parse(num2);
                lblResultado.Text = num2Double.ToString();
            }
            else if (estagio == 3)
            {
                num1Double += resultado;
                num1 = num1Double.ToString();
            }
        }
        // Adiciona uma vírgula (representada por ponto) ao número atual
        private void AdicionarVirgula()
        {
            if (estagio == 1)
            {
                if (!num1.Contains(","))
                {
                    num1 += ",";
                    lblResultado.Text = num1;
                }
            }
            else if (estagio == 2)
            {
                if (!num2.Contains(","))
                {
                    num2 += ",";
                    lblResultado.Text = num2;
                }
            }
            else if (estagio == 3)
            {
                if (!num1.Contains(","))
                {
                    num1 += ",";
                    lblResultado.Text = num1;
                }
            }
        }



        // Eventos de clique dos botões de 0 a 9, chamam a função AdicionarNumero
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
        // Define o operador matemático, muda para o estágio 2 (entrada do segundo número) e exibe o símbolo
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

        // Realiza o cálculo quando o botão ENTER é pressionado
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(num1) && !string.IsNullOrEmpty(num2))
            {
                num1Double = double.Parse(num1, CultureInfo.CurrentCulture);
                num2Double = double.Parse(num2, CultureInfo.CurrentCulture);
                Operacao(operador);

                num1 = resultado.ToString(); // Resultado vira o novo num1
                num2 = "";                   // Limpa num2 para possível próxima operação
                estagio = 3;
            }

            lblResultado.Text = resultado.ToString();
        }

        // Remove o último dígito do número atual, atualizando o valor exibido
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                if (num1.Length != 1)
                {
                    num1 = num1.Remove(num1.Length - 1, 1);
                    num1Double = double.Parse(num1);
                    lblResultado.Text = num1Double.ToString();
                }
                else
                {
                    num1 = "0";
                    num1Double = double.Parse(num1);
                    lblResultado.Text = num1Double.ToString();
                }

            }
            else if (estagio == 2)
            {
                if (num2.Length != 1)
                {
                    num2 = num2.Remove(num2.Length - 1, 1);
                    num2Double = double.Parse(num2);
                    lblResultado.Text = num2Double.ToString();
                }
                else
                {
                    num2 = "0";
                    num2Double = double.Parse(num2);
                    lblResultado.Text = num2Double.ToString();
                }
            }
        }

        // Reseta todos os valores da calculadora
        private void btnDelete_Click(object sender, EventArgs e)
        {
            estagio = 1;
            num1Double = 0;
            num2Double = 0;
            num1 = "0";
            num2 = "0";
            operador = "";
            resultado = 0;
            lblResultado.Text = resultado.ToString();
        }

        // Adiciona uma vírgula decimal (.) ao número atual
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            AdicionarVirgula();
        }

        //Calcula raiz quadrada
        private void btnRaizQuadrada_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1Double = Math.Sqrt(num1Double);
                num1 = num1Double.ToString();
                lblResultado.Text = num1;
            }
            else if (estagio == 2)
            {
                num2Double = Math.Sqrt(num2Double);
                num2 = num2Double.ToString();
                lblResultado.Text = num2;
            }
            else
            {
                resultado = Math.Sqrt(resultado);
                lblResultado.Text = resultado.ToString();
            }
        }

        //Calcula ^2
        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1Double = Math.Pow(num1Double, 2);
                num1 = num1Double.ToString();
                lblResultado.Text = num1;
            }
            else if (estagio == 2)
            {
                num2Double = Math.Pow(num2Double, 2);
                num2 = num2Double.ToString();
                lblResultado.Text = num2;
            }
            else
            {
                resultado = Math.Pow(resultado, 2);
                lblResultado.Text = resultado.ToString();
            }
        }

        //Inverte o número/variavel que está no visor
        private void btnInverter_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1Double *= -1;
                num1 = num1Double.ToString();
                lblResultado.Text = num1;
            }
            else if (estagio == 2)
            {
                num2Double *= -1;
                num2 = num2Double.ToString();
                lblResultado.Text = num2;
            }
            else
            {
                resultado *= -1;
                lblResultado.Text = resultado.ToString();
            }
        }

        private void calculadoraDeTemperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnOpcoes_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnOpcoes, new Point(0, btnOpcoes.Height));
        }
    }
}
