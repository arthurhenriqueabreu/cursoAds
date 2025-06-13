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
                double l1, l2, l3; //lados do tri�ngulo
                l1 = Convert.ToDouble(txtLado1.Text);
                l2 = Convert.ToDouble(txtLado2.Text);
                l3 = Convert.ToDouble(txtLado3.Text);
                if ((l1 + l2 >= l3) && (l1 + l3 >= l2) && (l2 + l3 >= l1))//verifica se � tri�ngulo
                {
                    if (l1 == l2 && l2 == l3 && l3 == l1)//lados iguais?
                    {
                        lblResultadoOutput.Text = "Triangulo Equil�tero";
                    }
                    else if (l1 == l2 || l2 == l3 || l3 == l1)// dois lados s�o iguais?
                    {
                        lblResultadoOutput.Text = "Triangulo Is�sceles";
                    }
                    else if (l1 != l2 && l2 != l3 && l3 != l1)//os lados s�o diferentes?
                    {
                        lblResultadoOutput.Text = "Triangulo Escaleno";
                    }
                }
                else
                {
                    lblResultadoOutput.Text = "N�o � um tri�ngulo";
                }
            }
            catch
            {
                lblResultadoOutput.Text = "Error!";
                MessageBox.Show("Insira valores num�ricos v�lidos!", "Erro");
            }
        }
    }
}
