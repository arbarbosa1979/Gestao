namespace WindowsFormsAppPrincipal
{
    partial class FormCadastroFornecedor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label foneLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label siteLabel;
            this.labelCadastroCliente = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.foneTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.siteTextBox = new System.Windows.Forms.TextBox();
            emailLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            siteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCadastroCliente
            // 
            this.labelCadastroCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroCliente.Location = new System.Drawing.Point(0, 0);
            this.labelCadastroCliente.Name = "labelCadastroCliente";
            this.labelCadastroCliente.Size = new System.Drawing.Size(803, 55);
            this.labelCadastroCliente.TabIndex = 12;
            this.labelCadastroCliente.Text = "Cadastro de Fornecedor";
            this.labelCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancelar.Location = new System.Drawing.Point(716, 236);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 31);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSalvar.Location = new System.Drawing.Point(636, 236);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(74, 31);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(Models.Fornecedor);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(504, 67);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(41, 16);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(507, 86);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(276, 22);
            this.emailTextBox.TabIndex = 16;
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.Location = new System.Drawing.Point(5, 124);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(38, 16);
            foneLabel.TabIndex = 16;
            foneLabel.Text = "Fone";
            // 
            // foneTextBox
            // 
            this.foneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Fone", true));
            this.foneTextBox.Location = new System.Drawing.Point(4, 143);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(250, 22);
            this.foneTextBox.TabIndex = 17;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 67);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(44, 16);
            nomeLabel.TabIndex = 18;
            nomeLabel.Text = "Nome";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(8, 86);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(493, 22);
            this.nomeTextBox.TabIndex = 19;
            // 
            // siteLabel
            // 
            siteLabel.AutoSize = true;
            siteLabel.Location = new System.Drawing.Point(257, 124);
            siteLabel.Name = "siteLabel";
            siteLabel.Size = new System.Drawing.Size(30, 16);
            siteLabel.TabIndex = 19;
            siteLabel.Text = "Site";
            // 
            // siteTextBox
            // 
            this.siteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Site", true));
            this.siteTextBox.Location = new System.Drawing.Point(260, 143);
            this.siteTextBox.Name = "siteTextBox";
            this.siteTextBox.Size = new System.Drawing.Size(523, 22);
            this.siteTextBox.TabIndex = 20;
            // 
            // FormCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 333);
            this.Controls.Add(siteLabel);
            this.Controls.Add(this.siteTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelCadastroCliente);
            this.Name = "FormCadastroFornecedor";
            this.ShowIcon = false;
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.FormCadastroFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCadastroCliente;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox foneTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox siteTextBox;
    }
}