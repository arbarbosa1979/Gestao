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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarPermissao));
            this.radioButtonBuscarPermissaoTodas = new System.Windows.Forms.RadioButton();
            this.radioButtonPermissaoDescricao = new System.Windows.Forms.RadioButton();
            this.radioButtonBuscarPermissaoID = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBuscarPermissao = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAdicionarPermissao = new System.Windows.Forms.Button();
            this.buttonAlterarPermissao = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.permissaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.permissaoDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoUsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.NomeGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGrupoUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeGrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingNavigator)).BeginInit();
            this.permissaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonBuscarPermissaoTodas
            // 
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
            this.textBox1.Location = new System.Drawing.Point(13, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(475, 22);
            this.textBox1.TabIndex = 3;
            // 
            // buttonBuscarPermissao
            // 
            this.buttonBuscarPermissao.Location = new System.Drawing.Point(572, 102);
            this.buttonBuscarPermissao.Name = "buttonBuscarPermissao";
            this.buttonBuscarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarPermissao.TabIndex = 4;
            this.buttonBuscarPermissao.Text = "Buscar";
            this.buttonBuscarPermissao.UseVisualStyleBackColor = true;
            this.buttonBuscarPermissao.Click += new System.EventHandler(this.buttonPermBuscar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(553, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1272, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarPermissao
            // 
            this.buttonAdicionarPermissao.Location = new System.Drawing.Point(653, 102);
            this.buttonAdicionarPermissao.Name = "buttonAdicionarPermissao";
            this.buttonAdicionarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarPermissao.TabIndex = 4;
            this.buttonAdicionarPermissao.Text = "Adicionar";
            this.buttonAdicionarPermissao.UseVisualStyleBackColor = true;
            this.buttonAdicionarPermissao.Click += new System.EventHandler(this.buttonAdicionarPermissao_Click);
            // 
            // buttonAlterarPermissao
            // 
            this.buttonAlterarPermissao.Location = new System.Drawing.Point(734, 102);
            this.buttonAlterarPermissao.Name = "buttonAlterarPermissao";
            this.buttonAlterarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarPermissao.TabIndex = 4;
            this.buttonAlterarPermissao.Text = "Alterar";
            this.buttonAlterarPermissao.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(815, 102);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1191, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // permissaoBindingNavigator
            // 
            this.permissaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.permissaoBindingNavigator.BindingSource = this.permissaoBindingSource;
            this.permissaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.permissaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.permissaoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.permissaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.permissaoBindingNavigatorSaveItem});
            this.permissaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.permissaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.permissaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.permissaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.permissaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.permissaoBindingNavigator.Name = "permissaoBindingNavigator";
            this.permissaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.permissaoBindingNavigator.Size = new System.Drawing.Size(1359, 27);
            this.permissaoBindingNavigator.TabIndex = 5;
            this.permissaoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // permissaoBindingNavigatorSaveItem
            // 
            this.permissaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.permissaoBindingNavigatorSaveItem.Enabled = false;
            this.permissaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("permissaoBindingNavigatorSaveItem.Image")));
            this.permissaoBindingNavigatorSaveItem.Name = "permissaoBindingNavigatorSaveItem";
            this.permissaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.permissaoBindingNavigatorSaveItem.Text = "Save Data";
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
            this.Descricao,
            this.descricaoDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.permissaoDataGridView.DataSource = this.permissaoBindingSource;
            this.permissaoDataGridView.Location = new System.Drawing.Point(12, 131);
            this.permissaoDataGridView.Name = "permissaoDataGridView";
            this.permissaoDataGridView.ReadOnly = true;
            this.permissaoDataGridView.RowHeadersWidth = 51;
            this.permissaoDataGridView.RowTemplate.Height = 24;
            this.permissaoDataGridView.Size = new System.Drawing.Size(878, 483);
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
            this.NomeGrupo,
            this.idGrupoUserDataGridViewTextBoxColumn,
            this.nomeGrupoDataGridViewTextBoxColumn});
            this.grupoUsuariosDataGridView.DataSource = this.grupoUsuariosBindingSource;
            this.grupoUsuariosDataGridView.Location = new System.Drawing.Point(896, 131);
            this.grupoUsuariosDataGridView.Name = "grupoUsuariosDataGridView";
            this.grupoUsuariosDataGridView.ReadOnly = true;
            this.grupoUsuariosDataGridView.RowHeadersVisible = false;
            this.grupoUsuariosDataGridView.RowHeadersWidth = 51;
            this.grupoUsuariosDataGridView.RowTemplate.Height = 24;
            this.grupoUsuariosDataGridView.Size = new System.Drawing.Size(451, 483);
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
            // idGrupoUserDataGridViewTextBoxColumn
            // 
            this.idGrupoUserDataGridViewTextBoxColumn.DataPropertyName = "IdGrupoUser";
            this.idGrupoUserDataGridViewTextBoxColumn.HeaderText = "IdGrupoUser";
            this.idGrupoUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idGrupoUserDataGridViewTextBoxColumn.Name = "idGrupoUserDataGridViewTextBoxColumn";
            this.idGrupoUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.idGrupoUserDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeGrupoDataGridViewTextBoxColumn
            // 
            this.nomeGrupoDataGridViewTextBoxColumn.DataPropertyName = "NomeGrupo";
            this.nomeGrupoDataGridViewTextBoxColumn.HeaderText = "NomeGrupo";
            this.nomeGrupoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeGrupoDataGridViewTextBoxColumn.Name = "nomeGrupoDataGridViewTextBoxColumn";
            this.nomeGrupoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeGrupoDataGridViewTextBoxColumn.Width = 125;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormBuscarPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 638);
            this.Controls.Add(this.grupoUsuariosDataGridView);
            this.Controls.Add(this.permissaoDataGridView);
            this.Controls.Add(this.permissaoBindingNavigator);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterarPermissao);
            this.Controls.Add(this.buttonAdicionarPermissao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonBuscarPermissao);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButtonBuscarPermissaoID);
            this.Controls.Add(this.radioButtonPermissaoDescricao);
            this.Controls.Add(this.radioButtonBuscarPermissaoTodas);
            this.Name = "FormBuscarPermissao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Permissões";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingNavigator)).EndInit();
            this.permissaoBindingNavigator.ResumeLayout(false);
            this.permissaoBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAdicionarPermissao;
        private System.Windows.Forms.Button buttonAlterarPermissao;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.BindingNavigator permissaoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton permissaoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView permissaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.BindingSource grupoUsuariosBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupoUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeGrupoDataGridViewTextBoxColumn;
    }
}