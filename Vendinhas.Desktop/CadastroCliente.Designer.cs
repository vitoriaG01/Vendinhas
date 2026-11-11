namespace Vendinhas.Desktop
{
    partial class CadastroCliente
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
            lblNomeCompleto = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtEmail = new TextBox();
            dtpNascimento = new DateTimePicker();
            btnVoltar = new Button();
            btnCadastrar = new Button();
            lblTitlulo = new Label();
            lblSubtitulo = new Label();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeCompleto.ForeColor = Color.MidnightBlue;
            lblNomeCompleto.Location = new Point(124, 84);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(113, 17);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo:";
            lblNomeCompleto.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(124, 132);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 1;
            label2.Text = "CPF:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(124, 180);
            label3.Name = "label3";
            label3.Size = new Size(141, 17);
            label3.TabIndex = 2;
            label3.Text = "Data de Nascimento: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(124, 228);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 3;
            label4.Text = "E-mail: ";
            label4.Click += label4_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.Black;
            txtNome.Location = new Point(124, 104);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(350, 25);
            txtNome.TabIndex = 4;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCPF
            // 
            txtCPF.BackColor = Color.White;
            txtCPF.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCPF.ForeColor = Color.Black;
            txtCPF.Location = new Point(124, 152);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(350, 25);
            txtCPF.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(124, 248);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(350, 25);
            txtEmail.TabIndex = 6;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(124, 200);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(350, 25);
            dtpNascimento.TabIndex = 7;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(280, 279);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(150, 35);
            btnVoltar.TabIndex = 9;
            btnVoltar.TabStop = false;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(124, 279);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(150, 35);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblTitlulo
            // 
            lblTitlulo.AutoSize = true;
            lblTitlulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitlulo.ForeColor = Color.MidnightBlue;
            lblTitlulo.Location = new Point(180, 9);
            lblTitlulo.Name = "lblTitlulo";
            lblTitlulo.Size = new Size(212, 32);
            lblTitlulo.TabIndex = 11;
            lblTitlulo.Text = "Cadastro Clientes";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(205, 41);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(161, 15);
            lblSubtitulo.TabIndex = 12;
            lblSubtitulo.Text = "Preencha os dados do cliente";
            lblSubtitulo.Click += label5_Click;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(634, 511);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitlulo);
            Controls.Add(btnCadastrar);
            Controls.Add(btnVoltar);
            Controls.Add(dtpNascimento);
            Controls.Add(txtEmail);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNomeCompleto);
            Name = "CadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtEmail;
        private DateTimePicker dtpNascimento;
        private Button btnVoltar;
        private Button btnCadastrar;
        private Label lblTitlulo;
        private Label lblSubtitulo;
    }
}