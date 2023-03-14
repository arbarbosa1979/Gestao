using BLL;
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
            try
            {
                int id = int.Parse(textBoxId.Text);

                // Cria uma instância da classe UsuarioBLL
                UsuarioBLL usuarioBLL = new UsuarioBLL();

                // Chamar o método Excluir passando a ID do usuário
                usuarioBLL.Excluir(id);

                // Mostra uma mensagem de de operação concluída com sucesso
                MessageBox.Show("Usuário excluído com sucesso!");

                // Clear the textboxes
                textBoxNome.Text = "";
                textBoxEmail.Text = "";
                textBoxSenha.Text = "";
                textBoxId.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir usuário: " + ex.Message);
            }
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
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(sender, e);
        }

        private void buttonAdicionarGrupoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void buttonExcluirGrupoUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
