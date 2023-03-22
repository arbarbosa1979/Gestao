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
            this.radioButtonBuscarPermissaoTodas = new System.Windows.Forms.RadioButton();
            this.radioButtonPermissaoDescricao = new System.Windows.Forms.RadioButton();
            this.radioButtonBuscarPermissaoID = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonPermBuscar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // buttonPermBuscar
            // 
            this.buttonPermBuscar.Location = new System.Drawing.Point(503, 102);
            this.buttonPermBuscar.Name = "buttonPermBuscar";
            this.buttonPermBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonPermBuscar.TabIndex = 4;
            this.buttonPermBuscar.Text = "Buscar";
            this.buttonPermBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(475, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1128, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(584, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Adicionar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(665, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Alterar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(746, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Excluir";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1047, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormBuscarPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 638);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonPermBuscar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButtonBuscarPermissaoID);
            this.Controls.Add(this.radioButtonPermissaoDescricao);
            this.Controls.Add(this.radioButtonBuscarPermissaoTodas);
            this.Name = "FormBuscarPermissao";
            this.ShowIcon = false;
            this.Text = "Gestão de Permissões";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonBuscarPermissaoTodas;
        private System.Windows.Forms.RadioButton radioButtonPermissaoDescricao;
        private System.Windows.Forms.RadioButton radioButtonBuscarPermissaoID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonPermBuscar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}