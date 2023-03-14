﻿using BLL;
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
        public FormCadastroUsuario()
        {
            InitializeComponent();
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
                usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current, confirmacaoSenhatextBox.Text);
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
            usuarioBindingSource.AddNew();
        }
    }
}
