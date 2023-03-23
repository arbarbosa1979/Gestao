using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormBuscarPermissao : Form
    {
        public FormBuscarPermissao()
        {
            InitializeComponent();
        }

        private void buttonBuscarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                if (radioButtonBuscarPermissaoTodas.Checked)
                {
                    permissaoBindingSource.DataSource = permissaoBLL.ExibirTodasPermissoes();
                }
                else if (radioButtonPermissaoDescricao.Checked)
                {
                    permissaoBindingSource.DataSource = permissaoBLL.BuscarPermissao_PorNome(textBox1.Text);
                }
                else if (radioButtonBuscarPermissaoID.Checked)
                {
                    permissaoBindingSource.DataSource = permissaoBLL.BuscarPorID(Convert.ToInt32(textBox1.Text));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionarPermissao_Click(object sender, EventArgs e)
        {
            using (FormCadastroPermissao frm = new FormCadastroPermissao())
            {
                frm.ShowDialog();
            }
        }
    }
}
