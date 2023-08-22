namespace WindowsFormsApp
{
    partial class FormBuscarPermissao
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
            this.radioButtonBuscarPermissaoTodas = new System.Windows.Forms.RadioButton();
            this.radioButtonPermissaoDescricao = new System.Windows.Forms.RadioButton();
            this.radioButtonBuscarPermissaoID = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBuscarPermissao = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonExcluirPermissaoGrupo = new System.Windows.Forms.Button();
            this.buttonAdicionarPermissao = new System.Windows.Forms.Button();
            this.buttonAlterarPermissao = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAdicionarPermissaoGrupo = new System.Windows.Forms.Button();
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissaoDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoUsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.NomeGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonBuscarPermissaoTodas
            // 
            this.radioButtonBuscarPermissaoTodas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonBuscarPermissaoTodas.AutoSize = true;
            this.radioButtonBuscarPermissaoTodas.Checked = true;
            this.radioButtonBuscarPermissaoTodas.Location = new System.Drawing.Point(13, 45);
            this.radioButtonBuscarPermissaoTodas.Name = "radioButtonBuscarPermissaoTodas";
            this.radioButtonBuscarPermissaoTodas.Size = new System.Drawing.Size(196, 20);
            this.radioButtonBuscarPermissaoTodas.TabIndex = 0;
            this.radioButtonBuscarPermissaoTodas.TabStop = true;
            this.radioButtonBuscarPermissaoTodas.Text = "Buscar Permissões (Todas)";
            this.radioButtonBuscarPermissaoTodas.UseVisualStyleBackColor = true;
            // 
            // radioButtonPermissaoDescricao
            // 
            this.radioButtonPermissaoDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonPermissaoDescricao.AutoSize = true;
            this.radioButtonPermissaoDescricao.Location = new System.Drawing.Point(215, 45);
            this.radioButtonPermissaoDescricao.Name = "radioButtonPermissaoDescricao";
            this.radioButtonPermissaoDescricao.Size = new System.Drawing.Size(158, 20);
            this.radioButtonPermissaoDescricao.TabIndex = 1;
            this.radioButtonPermissaoDescricao.Text = "Buscar por Descrição";
            this.radioButtonPermissaoDescricao.UseVisualStyleBackColor = true;
            // 
            // radioButtonBuscarPermissaoID
            // 
            this.radioButtonBuscarPermissaoID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonBuscarPermissaoID.AutoSize = true;
            this.radioButtonBuscarPermissaoID.Location = new System.Drawing.Point(379, 45);
            this.radioButtonBuscarPermissaoID.Name = "radioButtonBuscarPermissaoID";
            this.radioButtonBuscarPermissaoID.Size = new System.Drawing.Size(109, 20);
            this.radioButtonBuscarPermissaoID.TabIndex = 2;
            this.radioButtonBuscarPermissaoID.Text = "Buscar por ID";
            this.radioButtonBuscarPermissaoID.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(13, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 22);
            this.textBox1.TabIndex = 3;
            // 
            // buttonBuscarPermissao
            // 
            this.buttonBuscarPermissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarPermissao.Location = new System.Drawing.Point(545, 102);
            this.buttonBuscarPermissao.Name = "buttonBuscarPermissao";
            this.buttonBuscarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarPermissao.TabIndex = 4;
            this.buttonBuscarPermissao.Text = "Buscar";
            this.buttonBuscarPermissao.UseVisualStyleBackColor = true;
            this.buttonBuscarPermissao.Click += new System.EventHandler(this.buttonBuscarPermissao_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(13, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(526, 22);
            this.textBox2.TabIndex = 3;
            // 
            // buttonExcluirPermissaoGrupo
            // 
            this.buttonExcluirPermissaoGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirPermissaoGrupo.Location = new System.Drawing.Point(1245, 102);
            this.buttonExcluirPermissaoGrupo.Name = "buttonExcluirPermissaoGrupo";
            this.buttonExcluirPermissaoGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirPermissaoGrupo.TabIndex = 4;
            this.buttonExcluirPermissaoGrupo.Text = "Excluir";
            this.buttonExcluirPermissaoGrupo.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarPermissao
            // 
            this.buttonAdicionarPermissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdicionarPermissao.Location = new System.Drawing.Point(626, 102);
            this.buttonAdicionarPermissao.Name = "buttonAdicionarPermissao";
            this.buttonAdicionarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarPermissao.TabIndex = 4;
            this.buttonAdicionarPermissao.Text = "Adicionar";
            this.buttonAdicionarPermissao.UseVisualStyleBackColor = true;
            this.buttonAdicionarPermissao.Click += new System.EventHandler(this.buttonAdicionarPermissao_Click);
            // 
            // buttonAlterarPermissao
            // 
            this.buttonAlterarPermissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterarPermissao.Location = new System.Drawing.Point(707, 102);
            this.buttonAlterarPermissao.Name = "buttonAlterarPermissao";
            this.buttonAlterarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarPermissao.TabIndex = 4;
            this.buttonAlterarPermissao.Text = "Alterar";
            this.buttonAlterarPermissao.UseVisualStyleBackColor = true;
            this.buttonAlterarPermissao.Click += new System.EventHandler(this.buttonAlterarPermissao_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluir.Location = new System.Drawing.Point(788, 102);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAdicionarPermissaoGrupo
            // 
            this.buttonAdicionarPermissaoGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdicionarPermissaoGrupo.Location = new System.Drawing.Point(1164, 104);
            this.buttonAdicionarPermissaoGrupo.Name = "buttonAdicionarPermissaoGrupo";
            this.buttonAdicionarPermissaoGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarPermissaoGrupo.TabIndex = 4;
            this.buttonAdicionarPermissaoGrupo.Text = "Adicionar";
            this.buttonAdicionarPermissaoGrupo.UseVisualStyleBackColor = true;
            this.buttonAdicionarPermissaoGrupo.Click += new System.EventHandler(this.buttonAdicionarPermissaoGrupo_Click);
            // 
            // permissaoDataGridView
            // 
            this.permissaoDataGridView.AllowUserToAddRows = false;
            this.permissaoDataGridView.AllowUserToDeleteRows = false;
            this.permissaoDataGridView.AllowUserToOrderColumns = true;
            this.permissaoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.permissaoDataGridView.AutoGenerateColumns = false;
            this.permissaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissaoDataGridView.ColumnHeadersVisible = false;
            this.permissaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descricao});
            this.permissaoDataGridView.DataSource = this.permissaoBindingSource;
            this.permissaoDataGridView.Location = new System.Drawing.Point(12, 131);
            this.permissaoDataGridView.Name = "permissaoDataGridView";
            this.permissaoDataGridView.ReadOnly = true;
            this.permissaoDataGridView.RowHeadersWidth = 51;
            this.permissaoDataGridView.RowTemplate.Height = 24;
            this.permissaoDataGridView.Size = new System.Drawing.Size(851, 533);
            this.permissaoDataGridView.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 65;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // grupoUsuariosBindingSource
            // 
            this.grupoUsuariosBindingSource.DataMember = "GrupoUsuarios";
            this.grupoUsuariosBindingSource.DataSource = this.permissaoBindingSource;
            // 
            // grupoUsuariosDataGridView
            // 
            this.grupoUsuariosDataGridView.AllowUserToAddRows = false;
            this.grupoUsuariosDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuariosDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuariosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoUsuariosDataGridView.AutoGenerateColumns = false;
            this.grupoUsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeGrupo});
            this.grupoUsuariosDataGridView.DataSource = this.grupoUsuariosBindingSource;
            this.grupoUsuariosDataGridView.Location = new System.Drawing.Point(869, 131);
            this.grupoUsuariosDataGridView.Name = "grupoUsuariosDataGridView";
            this.grupoUsuariosDataGridView.ReadOnly = true;
            this.grupoUsuariosDataGridView.RowHeadersVisible = false;
            this.grupoUsuariosDataGridView.RowHeadersWidth = 51;
            this.grupoUsuariosDataGridView.RowTemplate.Height = 24;
            this.grupoUsuariosDataGridView.Size = new System.Drawing.Size(451, 533);
            this.grupoUsuariosDataGridView.TabIndex = 13;
            // 
            // NomeGrupo
            // 
            this.NomeGrupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeGrupo.DataPropertyName = "NomeGrupo";
            this.NomeGrupo.HeaderText = "Grupos";
            this.NomeGrupo.MinimumWidth = 6;
            this.NomeGrupo.Name = "NomeGrupo";
            this.NomeGrupo.ReadOnly = true;
            // 
            // FormBuscarPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 688);
            this.Controls.Add(this.grupoUsuariosDataGridView);
            this.Controls.Add(this.permissaoDataGridView);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterarPermissao);
            this.Controls.Add(this.buttonAdicionarPermissao);
            this.Controls.Add(this.buttonAdicionarPermissaoGrupo);
            this.Controls.Add(this.buttonExcluirPermissaoGrupo);
            this.Controls.Add(this.buttonBuscarPermissao);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButtonBuscarPermissaoID);
            this.Controls.Add(this.radioButtonPermissaoDescricao);
            this.Controls.Add(this.radioButtonBuscarPermissaoTodas);
            this.MaximumSize = new System.Drawing.Size(1350, 735);
            this.MinimumSize = new System.Drawing.Size(1350, 735);
            this.Name = "FormBuscarPermissao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Permissões";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonBuscarPermissaoTodas;
        private System.Windows.Forms.RadioButton radioButtonPermissaoDescricao;
        private System.Windows.Forms.RadioButton radioButtonBuscarPermissaoID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBuscarPermissao;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonExcluirPermissaoGrupo;
        private System.Windows.Forms.Button buttonAdicionarPermissao;
        private System.Windows.Forms.Button buttonAlterarPermissao;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAdicionarPermissaoGrupo;
        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.DataGridView permissaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.BindingSource grupoUsuariosBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeGrupo;
    }
}