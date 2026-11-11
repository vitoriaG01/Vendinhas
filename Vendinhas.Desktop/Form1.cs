namespace Vendinhas.Desktop
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ListaClientes lista = new ListaClientes();

            lista.ShowDialog();
        }

        private void btnDividas_Click(object sender, EventArgs e)
        {
            ListaDividas lista = new ListaDividas();

            lista.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Deseja mesmo sair do sisitema?",
                "Confirmar saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
