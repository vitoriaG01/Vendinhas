namespace Vendinhas.Desktop
{
    partial class CadastroDivida
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
            lblTitulo = new Label();
            lblValor = new Label();
            nudValor = new NumericUpDown();
            btnSalvar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudValor).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(23, 52, 93);
            lblTitulo.Location = new Point(132, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(230, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro de Dívida";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValor.ForeColor = Color.FromArgb(23, 52, 93);
            lblValor.Location = new Point(115, 77);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(105, 17);
            lblValor.TabIndex = 1;
            lblValor.Text = "Valor da dívida:";
            lblValor.Click += label2_Click;
            // 
            // nudValor
            // 
            nudValor.AllowDrop = true;
            nudValor.BackColor = Color.White;
            nudValor.DecimalPlaces = 2;
            nudValor.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudValor.Location = new Point(115, 106);
            nudValor.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudValor.Name = "nudValor";
            nudValor.Size = new Size(300, 23);
            nudValor.TabIndex = 2;
            nudValor.ThousandsSeparator = true;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(23, 52, 93);
            btnSalvar.CausesValidation = false;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(115, 149);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(130, 40);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Cadastrar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(220, 232, 245);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(23, 52, 93);
            btnCancelar.Location = new Point(270, 149);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 40);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Voltar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // CadastroDivida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(534, 361);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(nudValor);
            Controls.Add(lblValor);
            Controls.Add(lblTitulo);
            Name = "CadastroDivida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Divida";
            ((System.ComponentModel.ISupportInitialize)nudValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblValor;
        private NumericUpDown nudValor;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}