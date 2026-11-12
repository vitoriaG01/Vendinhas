using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Vendinhas.Models;
using Vendinhas.Services;

namespace Vendinhas.Desktop
{
    public partial class ListaDividas : Form
    {
        public ListaDividas()
        {
            InitializeComponent();

            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;

            CarregarClientes();
        }

        private void CarregarClientes()
        {
            ClienteService service = new ClienteService();

            var clientes = service.ListarClientes();

            clientes.Insert(0, new Cliente
            {
                Id = 0,
                NomeCompleto = "Escolha um cliente..."
            });

            cmbClientes.DisplayMember = "NomeCompleto";
            cmbClientes.ValueMember = "Id";
            cmbClientes.DataSource = clientes;

            cmbClientes.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvDividas.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma dívida para pagar! ");
                return;
            }

            int id = Convert.ToInt32(
                dgvDividas.CurrentRow.Cells["Id"].Value);

            DialogResult resposta = MessageBox.Show(
                "Deseja confirmar o pagamento desta dívida?",
                "Confirmar pagamento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                DividaService service = new DividaService();

                bool resultado = service.PagarDivida(id);

                if (resultado)
                {
                    MessageBox.Show("Dívida paga com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível pagar esta dívida. Ela pode já estar paga.");
                }

                int clienteId = Convert.ToInt32(cmbClientes.SelectedValue);

                CarregarDividas(clienteId);
            }
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedIndex <= 0)
            {
                dgvDividas.DataSource = null;
                return;
            }

            int clientId = Convert.ToInt32(cmbClientes.SelectedValue);

            CarregarDividas(clientId);
        }

        private void CarregarDividas(int clientID)
        {
            DividaService service = new DividaService();

            dgvDividas.DataSource = service.ListarDividas(clientID);

            dgvDividas.Columns["ClientId"].Visible = false;

            dgvDividas.Columns["Id"].HeaderText = "Código";

            dgvDividas.Columns["Valor"].HeaderText = "Valor";
            dgvDividas.Columns["Valor"].DefaultCellStyle.Format = "C2";

            dgvDividas.Columns["Paga"].HeaderText = "Paga?";

            dgvDividas.Columns["DataCriacao"].HeaderText = "Data de criação";
            dgvDividas.Columns["DataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvDividas.Columns["DataPagamento"].HeaderText = "Data de pagamento";
            dgvDividas.Columns["DataPagamento"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedIndex <= 0)
            {
                MessageBox.Show("Selecione um cliente primeiro!");
                return;
            }

            int clienteId = Convert.ToInt32(cmbClientes.SelectedValue);

            CadastroDivida cadastro = new CadastroDivida(clienteId);

            cadastro.ShowDialog();

            CarregarDividas(clienteId);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
