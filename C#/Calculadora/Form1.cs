namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double resultado = num1 + num2;
            txtResultado.Text = resultado.ToString();
        }
    }
}
