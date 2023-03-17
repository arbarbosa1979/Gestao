using BLL;
using Models;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído.");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            // Chamar o método Excluir passando a ID do usuário
            int id = ((Usuario)usuarioBindingSource.Current).IdUser;
            new UsuarioBLL().Excluir(id);

           // Mostra uma mensagem de operação concluída com sucesso
            MessageBox.Show("Registro excluído com sucesso!");
            buttonBuscar_Click(null, null);
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
            int id = ((Usuario)usuarioBindingSource.Current).IdUser;

            using (FormCadastroUsuario frm = new FormCadastroUsuario(true, id))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(sender, e);
        }
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(sender, e);
        }

        private void buttonAdicionarGrupoUsuario_Click(object sender, EventArgs e)
        {
            using (FormConsultarGrupoUsuario frm = new FormConsultarGrupoUsuario())
            {
                frm.ShowDialog();
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                int id = ((Usuario)usuarioBindingSource.Current).IdUser;
                usuarioBLL.AdicionarGrupoUsuario(id, frm.Id);
            }
        }

        private void buttonExcluirGrupoUsuario_Click(object sender, EventArgs e)
        {
            using (FormConsultarGrupoUsuario frm = new FormConsultarGrupoUsuario())
            {
                frm.ShowDialog();
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                int id = ((Usuario)usuarioBindingSource.Current).IdUser;
                usuarioBLL.(id, frm.Id);
            }
        }
    }
}
