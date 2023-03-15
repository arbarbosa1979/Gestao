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
    public partial class FormCadastroUsuario : Form
    {
        private bool alterar;
        public FormCadastroUsuario(bool _alterar = false, int _id=0)
        {
            InitializeComponent();
            alterar = _alterar;
            if(alterar)
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorID(_id);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.EndEdit();
                if (!alterar)
                    usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current, confirmacaoSenhatextBox.Text);
                else
                    usuarioBLL.Alterar((Usuario)usuarioBindingSource.Current, confirmacaoSenhatextBox.Text);
                MessageBox.Show("Registro salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            if(!alterar)
                usuarioBindingSource.AddNew();
        }
    }
}
