using System;
using BLL;
using Models;
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
    public partial class FormConsultaCliente : Form
    {
        public FormConsultaCliente(int id = 0)
        {
            InitializeComponent();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteBindingSource.DataSource = new ClienteBLL().BuscarPorNome(textBoxBuscar.Text);
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
                if (clienteBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Cliente)clienteBindingSource.Current).Id;
                new ClienteBLL().Excluir(id);
                clienteBindingSource.RemoveCurrent();

                MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroCliente frm = new FormCadastroCliente())
                {
                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if(clienteBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe nenhum registro selecionado para alterar.");
                    return;
                }
                int id = ((Cliente)clienteBindingSource.Current).Id;

                using (FormCadastroCliente frm = new FormCadastroCliente(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
