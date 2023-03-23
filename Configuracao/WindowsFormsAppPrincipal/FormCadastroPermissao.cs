using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormCadastroPermissao : Form
    {
        private bool alterar;
        public FormCadastroPermissao(bool _alterar = false, int _idPermissao = 0)
        {
            InitializeComponent();
            alterar = _alterar;
            if (alterar)
            {
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                permissaoBindingSource.DataSource = permissaoBLL.BuscarPorID(_idPermissao);
            }
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                if (!alterar)
                {
                    permissaoBLL.Inserir(Convert.ToInt32(idTextBox.Text), descricaoTextBox.Text);
                    MessageBox.Show("Permissão cadastrada com sucesso!");
                    Close();
                }
                else
                {
                    permissaoBLL.Alterar((Permissao)permissaoBindingSource.Current);
                    MessageBox.Show("Permissão alterada com sucesso!");
                    Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastroPermissao_Load(object sender, EventArgs e)
        {
            if (!alterar)
                permissaoBindingSource.AddNew();
        }
    }
}
