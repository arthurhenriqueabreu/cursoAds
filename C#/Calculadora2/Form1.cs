namespace Calculadora2
{
    public partial class Form1 : Form
    {
        string num1, num2;
        double estagio = 1, resultado, num1Double, num2Double;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 1;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += 1;
                txtResultado.Text = num2;
            }
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 2;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += 2;
                txtResultado.Text = num2;
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 3;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += 3;
                txtResultado.Text = num2;
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 4;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += 4;
                txtResultado.Text = num2;
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 5;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += 5;
                txtResultado.Text = num2;
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 6;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += 6;
                txtResultado.Text = num2;
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 7;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += 7;
                txtResultado.Text = num2;
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 8;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += 8;
                txtResultado.Text = num2;
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 9;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += 9;
                txtResultado.Text = num2;
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (estagio == 1)
            {
                num1 += 0;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += 0;
                txtResultado.Text = num2;
            }
        }

        private void btnAdittion_Click(object sender, EventArgs e)
        {
            estagio = 2;
            txtResultado.Text = "+";
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            estagio = 3;
            txtResultado.Text = "-";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            estagio = 4;
            txtResultado.Text = "/";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            estagio = 5;
            txtResultado.Text = "*";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            num1Double = double.Parse(num1);
            num2Double = double.Parse(num2);
            
        }
    }
}
