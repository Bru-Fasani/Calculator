namespace Calculator
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao Operacaoselecionada { get; set; }
        private enum Operacao
        {
            Soma,
            Sub,
            Div,
            Mul,
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "0";
        }

        private void bntum_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "1";
        }

        private void btndois_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "2";
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "3";
        }

        private void btnquatro_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "4";
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "5";
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "6";
        }

        private void btnsete_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "7";
        }

        private void btnoito_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "8";
        }

        private void btnnove_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "9";
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            Operacaoselecionada = Operacao.Soma;
            Valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            lbloperacao.Text = "+";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            Operacaoselecionada = Operacao.Sub;
            Valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            lbloperacao.Text = "-";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            Operacaoselecionada = Operacao.Div;
            Valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            lbloperacao.Text = "÷";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            Operacaoselecionada = Operacao.Mul;
            Valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            lbloperacao.Text = "x";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            switch (Operacaoselecionada)
            {
                case Operacao.Soma:
                    Resultado = Valor + Convert.ToDecimal(txtresultado.Text);
                    break;
                case Operacao.Sub:
                    Resultado = Valor - Convert.ToDecimal(txtresultado.Text);
                    break;
                case Operacao.Div:
                    Resultado = Valor / Convert.ToDecimal(txtresultado.Text);
                    break;
                case Operacao.Mul:
                    Resultado = Valor * Convert.ToDecimal(txtresultado.Text);
                    break;
            }
            txtresultado.Text = Convert.ToString(Resultado);
            lbloperacao.Text = "=";
        }

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            if (!txtresultado.Text.Contains(","))
                txtresultado.Text += ",";
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            lbloperacao.Text = "";
        }
    }
}
