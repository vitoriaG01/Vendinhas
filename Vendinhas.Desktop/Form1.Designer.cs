namespace Vendinhas.Desktop
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnClientes = new Button();
            btnDividas = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(210, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(244, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema Vendinha";
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(227, 65);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(200, 45);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Gerenciar Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnDividas
            // 
            btnDividas.Location = new Point(227, 116);
            btnDividas.Name = "btnDividas";
            btnDividas.Size = new Size(200, 45);
            btnDividas.TabIndex = 2;
            btnDividas.Text = "Gerenciar Dividas";
            btnDividas.UseVisualStyleBackColor = true;
            btnDividas.Click += btnDividas_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(227, 167);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(200, 45);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(884, 561);
            Controls.Add(btnSair);
            Controls.Add(btnDividas);
            Controls.Add(btnClientes);
            Controls.Add(lblTitulo);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendinha - Sistema de Controle";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnClientes;
        private Button btnDividas;
        private Button btnSair;
    }
}
