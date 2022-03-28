

namespace Soma
{
    using modelo;
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Controle controle = new();
            String mensagem = controle.Calcular(txbNumero1.Text, txbNumero2.Text);
            if (mensagem.Equals(""))
                lblResultado.Text = controle.resultado;
            else
                MessageBox.Show(mensagem);
        }
    }
}