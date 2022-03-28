

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
            Controle controle = new Controle();
            controle.numero1 = txbNumero1.Text;
            controle.numero2 = txbNumero2.Text;
            controle.Calcular();
            if (controle.mensagem.Equals(""))
            {
                lblResultado.Text = controle.resultado;
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}