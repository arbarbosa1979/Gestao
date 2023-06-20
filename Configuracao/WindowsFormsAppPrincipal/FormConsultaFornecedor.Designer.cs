namespace WindowsFormsAppPrincipal
{
    partial class FormConsultaFornecedor
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
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.fornecedorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxBuscarF = new System.Windows.Forms.TextBox();
            this.comboBoxBuscarPorF = new System.Windows.Forms.ComboBox();
            this.buttonBuscarFornec = new System.Windows.Forms.Button();
            this.buttonAlterarFornec = new System.Windows.Forms.Button();
            this.buttonInserirFornec = new System.Windows.Forms.Button();
            this.buttonExcluirFornec = new System.Windows.Forms.Button();
            this.labelBusar = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedor.Location = new System.Drawing.Point(0, 0);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(1043, 55);
            this.labelFornecedor.TabIndex = 3;
            this.labelFornecedor.Text = "Consulta Fornecedor";
            this.labelFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fornecedorDataGridView
            // 
            this.fornecedorDataGridView.AllowUserToAddRows = false;
            this.fornecedorDataGridView.AllowUserToDeleteRows = false;
            this.fornecedorDataGridView.AllowUserToOrderColumns = true;
            this.fornecedorDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fornecedorDataGridView.AutoGenerateColumns = false;
            this.fornecedorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fornecedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fornecedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.fornecedorDataGridView.DataSource = this.fornecedorBindingSource;
            this.fornecedorDataGridView.Location = new System.Drawing.Point(12, 109);
            this.fornecedorDataGridView.Name = "fornecedorDataGridView";
            this.fornecedorDataGridView.ReadOnly = true;
            this.fornecedorDataGridView.RowHeadersWidth = 51;
            this.fornecedorDataGridView.RowTemplate.Height = 24;
            this.fornecedorDataGridView.Size = new System.Drawing.Size(1031, 364);
            this.fornecedorDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.FillWeight = 283.871F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fone";
            this.dataGridViewTextBoxColumn3.FillWeight = 38.70966F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Fone";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.FillWeight = 38.70966F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Site";
            this.dataGridViewTextBoxColumn5.FillWeight = 38.70966F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Site";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(Models.Fornecedor);
            // 
            // textBoxBuscarF
            // 
            this.textBoxBuscarF.Location = new System.Drawing.Point(140, 81);
            this.textBoxBuscarF.Name = "textBoxBuscarF";
            this.textBoxBuscarF.Size = new System.Drawing.Size(567, 22);
            this.textBoxBuscarF.TabIndex = 5;
            // 
            // comboBoxBuscarPorF
            // 
            this.comboBoxBuscarPorF.FormattingEnabled = true;
            this.comboBoxBuscarPorF.Items.AddRange(new object[] {
            "Todos",
            "Nome",
            "Id",
            "Site"});
            this.comboBoxBuscarPorF.Location = new System.Drawing.Point(13, 81);
            this.comboBoxBuscarPorF.Name = "comboBoxBuscarPorF";
            this.comboBoxBuscarPorF.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBuscarPorF.TabIndex = 6;
            // 
            // buttonBuscarFornec
            // 
            this.buttonBuscarFornec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarFornec.Location = new System.Drawing.Point(713, 82);
            this.buttonBuscarFornec.Name = "buttonBuscarFornec";
            this.buttonBuscarFornec.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarFornec.TabIndex = 7;
            this.buttonBuscarFornec.Text = "&Buscar";
            this.buttonBuscarFornec.UseVisualStyleBackColor = true;
            this.buttonBuscarFornec.Click += new System.EventHandler(this.buttonBuscarFornec_Click);
            // 
            // buttonAlterarFornec
            // 
            this.buttonAlterarFornec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterarFornec.Location = new System.Drawing.Point(794, 82);
            this.buttonAlterarFornec.Name = "buttonAlterarFornec";
            this.buttonAlterarFornec.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarFornec.TabIndex = 7;
            this.buttonAlterarFornec.Text = "&Alterar";
            this.buttonAlterarFornec.UseVisualStyleBackColor = true;
            this.buttonAlterarFornec.Click += new System.EventHandler(this.buttonAlterarFornec_Click);
            // 
            // buttonInserirFornec
            // 
            this.buttonInserirFornec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInserirFornec.Location = new System.Drawing.Point(875, 82);
            this.buttonInserirFornec.Name = "buttonInserirFornec";
            this.buttonInserirFornec.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirFornec.TabIndex = 7;
            this.buttonInserirFornec.Text = "&Inserir";
            this.buttonInserirFornec.UseVisualStyleBackColor = true;
            this.buttonInserirFornec.Click += new System.EventHandler(this.buttonInserirFornec_Click);
            // 
            // buttonExcluirFornec
            // 
            this.buttonExcluirFornec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirFornec.Location = new System.Drawing.Point(956, 80);
            this.buttonExcluirFornec.Name = "buttonExcluirFornec";
            this.buttonExcluirFornec.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirFornec.TabIndex = 7;
            this.buttonExcluirFornec.Text = "&Excluir";
            this.buttonExcluirFornec.UseVisualStyleBackColor = true;
            this.buttonExcluirFornec.Click += new System.EventHandler(this.buttonExcluirFornec_Click);
            // 
            // labelBusar
            // 
            this.labelBusar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBusar.AutoSize = true;
            this.labelBusar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusar.Location = new System.Drawing.Point(12, 58);
            this.labelBusar.Name = "labelBusar";
            this.labelBusar.Size = new System.Drawing.Size(92, 20);
            this.labelBusar.TabIndex = 8;
            this.labelBusar.Text = "Buscar por";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(930, 495);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCancelar.Size = new System.Drawing.Size(75, 28);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionar.Location = new System.Drawing.Point(841, 495);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(83, 28);
            this.buttonSelecionar.TabIndex = 10;
            this.buttonSelecionar.Text = "&Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            // 
            // FormConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 553);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.labelBusar);
            this.Controls.Add(this.buttonExcluirFornec);
            this.Controls.Add(this.buttonInserirFornec);
            this.Controls.Add(this.buttonAlterarFornec);
            this.Controls.Add(this.buttonBuscarFornec);
            this.Controls.Add(this.comboBoxBuscarPorF);
            this.Controls.Add(this.textBoxBuscarF);
            this.Controls.Add(this.fornecedorDataGridView);
            this.Controls.Add(this.labelFornecedor);
            this.Name = "FormConsultaFornecedor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Consulta de Fornecedores";
            this.Load += new System.EventHandler(this.FormConsultaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.DataGridView fornecedorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox textBoxBuscarF;
        private System.Windows.Forms.ComboBox comboBoxBuscarPorF;
        private System.Windows.Forms.Button buttonBuscarFornec;
        private System.Windows.Forms.Button buttonAlterarFornec;
        private System.Windows.Forms.Button buttonInserirFornec;
        private System.Windows.Forms.Button buttonExcluirFornec;
        private System.Windows.Forms.Label labelBusar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSelecionar;
    }
}