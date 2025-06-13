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

        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 1;
                lblResultado.Text = num1;
            }
            else
            {
                num2 += 1;
                lblResultado.Text = num2;
            }
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 2;
                lblResultado.Text = num1;
            }
            else
            {
                num2 += 2;
                lblResultado.Text = num2;
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 3;
                lblResultado.Text = num1;
            }
            else
            {
                num2 += 3;
                lblResultado.Text = num2;
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 4;
                lblResultado.Text = num1;
            }
            else
            {
                num2 += 4;
                lblResultado.Text = num2;
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 5;
                lblResultado.Text = num1;
            }
            else
            {
                num2 += 5;
                lblResultado.Text = num2;
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 6;
                lblResultado.Text = num1;
            }
            else
            {
                num2 += 6;
                lblResultado.Text = num2;
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 7;
                lblResultado.Text = num1;
            }
            else
            {
                num2 += 7;
                lblResultado.Text = num2;
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 8;
                lblResultado.Text = num1;
            }
            else
            {
                num2 += 8;
                lblResultado.Text = num2;
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 9;
                lblResultado.Text = num1;
            }
            else
            {
                num2 += 9;
                lblResultado.Text = num2;
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 0;
                lblResultado.Text = num1;
            }
            else
            {
                num2 += 0;
                lblResultado.Text = num2;
            }
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
