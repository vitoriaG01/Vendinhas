using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Vendinhas.Services;

namespace Vendinhas.Desktop
{
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            ClienteService service = new ClienteService();

            dgvClientes.DataSource = service.ListarClientes();

            dgvClientes.Columns["TotalDividas"].HeaderText = "Total de Dívidas";

            dgvClientes.Columns["TotalDividas"].DefaultCellStyle.Format = "C2";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastro = new CadastroCliente();

            cadastro.ShowDialog();

            CarregarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente para editar!");
                return;
            }

            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);

            ClienteService service = new ClienteService();

            var cliente = service.BuscarCliente(id);

            if (cliente != null)
            {
                CadastroCliente cadastro = new CadastroCliente(cliente);

                cadastro.ShowDialog();

                CarregarClientes();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente para excluir!");
                return;
            }

            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir um cliente?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                ClienteService service = new ClienteService();

                bool resultado = service.ExcluirCliente(id);

                if (resultado)
                {
                    MessageBox.Show("Cliente excluido com sucesso!");
                    CarregarClientes();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
