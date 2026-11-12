namespace Vendinhas.Desktop
{
    partial class ListaDividas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ldlTitiulo = new Label();
            lblCliente = new Label();
            cmbClientes = new ComboBox();
            dgvDividas = new DataGridView();
            btnNova = new Button();
            btnPagar = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDividas).BeginInit();
            SuspendLayout();
            // 
            // ldlTitiulo
            // 
            ldlTitiulo.AutoSize = true;
            ldlTitiulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ldlTitiulo.ForeColor = Color.FromArgb(23, 52, 93);
            ldlTitiulo.Location = new Point(12, 9);
            ldlTitiulo.Name = "ldlTitiulo";
            ldlTitiulo.Size = new Size(215, 32);
            ldlTitiulo.TabIndex = 0;
            ldlTitiulo.Text = "Gerenciar Dívidas";
            ldlTitiulo.Click += label1_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(12, 52);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(115, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Selecione o cliente:";
            // 
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(12, 70);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(350, 23);
            cmbClientes.TabIndex = 2;
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged;
            // 
            // dgvDividas
            // 
            dgvDividas.AllowUserToAddRows = false;
            dgvDividas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDividas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDividas.Location = new Point(12, 99);
            dgvDividas.MultiSelect = false;
            dgvDividas.Name = "dgvDividas";
            dgvDividas.ReadOnly = true;
            dgvDividas.RowHeadersVisible = false;
            dgvDividas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDividas.Size = new Size(750, 300);
            dgvDividas.TabIndex = 3;
            // 
            // btnNova
            // 
            btnNova.BackColor = Color.FromArgb(23, 52, 93);
            btnNova.ForeColor = Color.White;
            btnNova.Location = new Point(516, 405);
            btnNova.Name = "btnNova";
            btnNova.Size = new Size(120, 40);
            btnNova.TabIndex = 4;
            btnNova.Text = "Nova Dívida";
            btnNova.UseVisualStyleBackColor = false;
            btnNova.Click += btnNova_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(220, 232, 245);
            btnPagar.ForeColor = Color.FromArgb(23, 52, 93);
            btnPagar.Location = new Point(642, 405);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(120, 40);
            btnPagar.TabIndex = 5;
            btnPagar.Text = "Pagar Dívida";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += button2_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(232, 238, 246);
            btnVoltar.ForeColor = Color.FromArgb(23, 52, 93);
            btnVoltar.Location = new Point(672, 451);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(90, 35);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // ListaDividas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 661);
            Controls.Add(btnVoltar);
            Controls.Add(btnPagar);
            Controls.Add(btnNova);
            Controls.Add(dgvDividas);
            Controls.Add(cmbClientes);
            Controls.Add(lblCliente);
            Controls.Add(ldlTitiulo);
            Name = "ListaDividas";
            Text = "ListaDividas";
            ((System.ComponentModel.ISupportInitialize)dgvDividas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ldlTitiulo;
        private Label lblCliente;
        private ComboBox cmbClientes;
        private DataGridView dgvDividas;
        private Button btnNova;
        private Button btnPagar;
        private Button btnVoltar;
    }
}