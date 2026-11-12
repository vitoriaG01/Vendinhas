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
    public partial class CadastroDivida : Form
    {
        private int clienteId;
        public CadastroDivida()
        {
            InitializeComponent();
        }

        public CadastroDivida(int clienteId)
        {
            InitializeComponent();

            this.clienteId = clienteId;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (nudValor.Value <= 0)
            {
                MessageBox.Show("Informe um valor maior que zero!");
                return;
            }

            Divida divida = new Divida();

            divida.ClientId = clienteId;
            divida.Valor = nudValor.Value;

            DividaService service = new DividaService();

            bool resultado = service.CadastrarDivida(divida);

            if (resultado)
            {
                MessageBox.Show("Dívida cadastrada com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Este cliente ja possui uma dívida em aberto!");
            }
        }
    }
}
