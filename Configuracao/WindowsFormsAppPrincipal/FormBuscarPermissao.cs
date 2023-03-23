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
                    permissaoBindingSource.DataSource = permissaoBLL.BuscarPermissaoPorNome(textBox1.Text);
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
            try
            {
                new UsuarioBLL().ValidarPermissao(9);
                using (FormCadastroPermissao frm = new FormCadastroPermissao())
                {
                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(9);
                int id = ((Permissao)permissaoBindingSource.Current).ID;
                using (FormCadastroPermissao frm = new FormCadastroPermissao(true, id))
                {
                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (permissaoBindingSource.Count == 0)
                {
                    MessageBox.Show("Não foi selecionado nenhum grupo para exclusão");
                    return;
                }
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                permissaoBLL.Excluir((Permissao)permissaoBindingSource.Current);
                MessageBox.Show("Permissão excluída com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionarPermissaoGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(9);
                using (FormConsultarGruposPermissao frm = new FormConsultarGruposPermissao())
                {
                    frm.ShowDialog();
                    if (frm.Id == 0)
                    {
                        return;
                    }
                    GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                    int idGrupo = frm.Id;
                    int idPermissao = ((Permissao)permissaoBindingSource.Current).ID;
                    grupoUsuarioBLL.VincularPermissaoGrupo(idGrupo, idPermissao);
                    MessageBox.Show("Permissão adicionada com sucesso!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
