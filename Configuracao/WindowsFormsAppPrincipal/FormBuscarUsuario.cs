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
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void FormBuscarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void usuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            if (textBoxBuscar.Text == "")
                usuarioBindingSource.DataSource = usuarioBLL.ExibirTodosUsuarios();   
            else
                usuarioBindingSource.DataSource = usuarioBLL.BuscarPorNomeUsuario(textBoxBuscar.Text);
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdicionarGrupoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void buttonExcluirGrupoUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
