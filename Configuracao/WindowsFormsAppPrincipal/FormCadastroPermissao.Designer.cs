namespace WindowsFormsApp
{
    partial class FormCadastroPermissao
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label descricaoLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(155, 143);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(38, 29);
            idLabel.TabIndex = 1;
            idLabel.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissaoBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(160, 175);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(101, 34);
            this.idTextBox.TabIndex = 2;
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(155, 236);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(130, 29);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Descricao";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissaoBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(160, 268);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(660, 34);
            this.descricaoTextBox.TabIndex = 4;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(536, 436);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(130, 31);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(689, 436);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(130, 31);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(882, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cadastro de Permissões";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCadastroPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "FormCadastroPermissao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de Permissões";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
    }
}