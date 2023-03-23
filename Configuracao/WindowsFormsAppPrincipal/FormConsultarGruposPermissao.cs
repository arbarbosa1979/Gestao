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
    public partial class FormConsultarGruposPermissao : Form
    {
        public int Id;
        public FormConsultarGruposPermissao()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.ExibirTodosGrupos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                if (grupoUsuarioBindingSource.Count > 0)
                {
                    Id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).IdGrupoUser;
                    Close();
                }
                else
                {
                    MessageBox.Show("Não existe um grupo selecionado");
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
    }
}
