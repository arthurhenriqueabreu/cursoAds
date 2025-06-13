namespace EstruturaDecisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                double l1, l2, l3; //lados do triângulo
                l1 = Convert.ToDouble(txtLado1.Text);
                l2 = Convert.ToDouble(txtLado2.Text);
                l3 = Convert.ToDouble(txtLado3.Text);
                if ((l1 + l2 >= l3) && (l1 + l3 >= l2) && (l2 + l3 >= l1))//verifica se é triângulo
                {
                    if (l1 == l2 && l2 == l3 && l3 == l1)//lados iguais?
                    {
                        lblResultadoOutput.Text = "Triangulo Equilátero";
                    }
                    else if (l1 == l2 || l2 == l3 || l3 == l1)// dois lados são iguais?
                    {
                        lblResultadoOutput.Text = "Triangulo Isósceles";
                    }
                    else if (l1 != l2 && l2 != l3 && l3 != l1)//os lados são diferentes?
                    {
                        lblResultadoOutput.Text = "Triangulo Escaleno";
                    }
                }
                else
                {
                    lblResultadoOutput.Text = "Não é um triângulo";
                }
            }
            catch
            {
                lblResultadoOutput.Text = "Error!";
                MessageBox.Show("Insira valores numéricos válidos!", "Erro");
            }
        }
    }
}
