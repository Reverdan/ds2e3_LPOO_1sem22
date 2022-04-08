

namespace Soma
{
    using modelo;
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        internal Controle Controle
        {
            get => default;
            set
            {
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txbNumero1.Text, txbNumero2.Text);
            if (controle.Mensagem.Equals(""))
            {
                lblResultado.Text = controle.Resultado;
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
            }
        }
    }
}