using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormConsultaFornecedor : Form
    {
        public FormConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void buttonBuscarFornec_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPorF.SelectedIndex)
                {
                    case 0:
                        fornecedorBindingSource.DataSource = new FornecedorBLL().BuscarTodos();
                        break;
                    case 1:
                        fornecedorBindingSource.DataSource = new FornecedorBLL().BuscarPorNome(textBoxBuscarF.Text);
                        break;
                    case 2:
                        if (String.IsNullOrEmpty(textBoxBuscarF.Text))

                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 42 } } };

                        fornecedorBindingSource.DataSource = new FornecedorBLL().BuscarPorId(Convert.ToInt32(textBoxBuscarF.Text));
                        break;
                    case 3:
                        fornecedorBindingSource.DataSource = new FornecedorBLL().BuscarPorSite(textBoxBuscarF.Text);
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterarFornec_Click(object sender, EventArgs e)
        {
            try
            {
                if (fornecedorBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe nenhum registro selecionado para alterar.");
                    return;
                }
                int id = ((Fornecedor)fornecedorBindingSource.Current).Id;

                using (FormCadastroFornecedor frm = new FormCadastroFornecedor(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscarFornec_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInserirFornec_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroFornecedor frm = new FormCadastroFornecedor())
                {
                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirFornec_Click(object sender, EventArgs e)
        {
            try
            {
                if (fornecedorBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Fornecedor)fornecedorBindingSource.Current).Id;
                new ClienteBLL().Excluir(id);
                fornecedorBindingSource.RemoveCurrent();

                MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConsultaFornecedor_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPorF.SelectedIndex = 0;
        }
    }
}
