namespace Calculadora2
{
    public partial class Form1 : Form
    {
        string num1, num2;
        double estagio = 1, resultado = 0, num1Double, num2Double;

        public Form1()
        {
            InitializeComponent();
            lblResultado.Text = resultado.ToString();
        }

        private void AdicionarNumero(int numero)
        {
            if (estagio == 1)
            {
                num1 += numero.ToString();
                lblResultado.Text = num1;
            }
            else
            {
                num2 += 1;
                lblResultado.Text = numero.ToString();
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
            lblResultado.Text = "+";
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            estagio = 3;
            lblResultado.Text = "-";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            estagio = 4;
            lblResultado.Text = "/";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            estagio = 5;
            lblResultado.Text = "*";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            num1Double = double.Parse(num1);
            num2Double = double.Parse(num2);

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
            
        }
    }
}
