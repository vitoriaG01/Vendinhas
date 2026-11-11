using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendinhas.Models;
using Vendinhas.Services;

namespace Vendinhas.Desktop
{
    public partial class CadastroCliente : Form
    {
        private int idCliente = 0;

        public CadastroCliente()
        {
            InitializeComponent();
        }
        public CadastroCliente(Cliente cliente)
        {
            InitializeComponent();

            idCliente = cliente.Id;

            txtNome.Text = cliente.NomeCompleto;
            txtCPF.Text = cliente.CPF;
            dtpNascimento.Value = cliente.DataNascimento.ToLocalTime();
            txtEmail.Text = cliente.Email;

            btnCadastrar.Text = "Salvar alterações";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.NomeCompleto = txtNome.Text;
            cliente.CPF = txtCPF.Text;
            cliente.DataNascimento = DateTime.SpecifyKind(
                dtpNascimento.Value.Date,
                DateTimeKind.Utc);
            cliente.Email = txtEmail.Text;

            ClienteService service = new ClienteService();

            bool resultado;

            if (idCliente == 0)
            {
                resultado = service.CadastrarCliente(cliente);
            }
            else
            {
                cliente.Id = idCliente;
                resultado = service.AtualizarCliente(cliente);
            }

            if (resultado)
            {
                MessageBox.Show("Cliente salvo com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Já existe um cliente com esse CPF!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
