using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario, string _confirmacaodeSenha)
        {
            ValidarPermissao(2);

            ValidarDados(_usuario, _confirmacaodeSenha);

            Usuario usuario = new Usuario();
            usuario = BuscarPorNomeUsuario(_usuario.NomeUsuario);
            if (usuario.NomeUsuario == _usuario.NomeUsuario)
                throw new Exception("Já existe um usuário com este nome.");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }
		public void Alterar(Usuario _usuario, string _confirmacaodeSenha)
		{
            ValidarPermissao(3);

            ValidarDados(_usuario, _confirmacaodeSenha);

			Usuario usuario = new Usuario();
			Usuario usuarioExistente = BuscarPorNomeUsuario(_usuario.NomeUsuario);
			if (usuarioExistente != null && usuarioExistente.IdUser != _usuario.IdUser)
				throw new Exception("Já existe um usuário com este nome.");

			UsuarioDAL usuarioDAL = new UsuarioDAL();
			usuarioDAL.Alterar(_usuario);
		}
        public void Excluir(int _id)
        {
            ValidarPermissao(4);

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
        }
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            ValidarPermissao(1);

            if (String.IsNullOrEmpty(_nomeUsuario))
                throw new Exception("Informe o nome do usuário.");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorNomeUsuario(_nomeUsuario);

        }
		public Usuario BuscarPorID(int _id)
		{
            ValidarPermissao(1);

            UsuarioDAL usuarioDAL=new UsuarioDAL();
			return usuarioDAL.BuscarPorId(_id);
		}
        public List<Usuario> ExibirTodosUsuarios()
        {
            ValidarPermissao(1);

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.ExibirTodosUsuarios();
        }
        public void AdicionarGrupoUsuario(int _idUser, int _idGrupoUser)
        {
            ValidarPermissao(6);

            if (new UsuarioDAL().ExisteRelacionamento(_idUser, _idGrupoUser))
                return;

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.AddGrupoUsuario(_idUser, _idGrupoUser);
        }
        public void RemoverGrupoUsuario(int idUsuario, int idGrupoUsuario)
        {
            ValidarPermissao(8);

            try
            {
                new UsuarioDAL().RemoverGrupoUsuario(idUsuario, idGrupoUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar remover o usuário do grupo: " + ex.Message);
            }
        }
        private void ValidarDados(Usuario _usuario, string _confirmacaodeSenha)
		{
			if (_usuario.NomeUsuario?.Length <= 3 || _usuario.NomeUsuario?.Length >= 50)
				throw new Exception("O nome de usuário deve ter mais de três caracteres.");

			if (_usuario.NomeUsuario.Contains(" "))
				throw new Exception("O nome de usuário não pode conter espaço.");

			if (_usuario.Senha.Contains("1234567"))
				throw new Exception("Não é permitido um número sequencial.");

			if (_usuario.Senha?.Length < 7 || _usuario.Senha?.Length > 11)
				throw new Exception("A senha deve ter entre 7 e 11 caracteres.");
			
			if (_confirmacaodeSenha != _usuario.Senha)
				throw new Exception("Os valores inseridos nos campos senha e confirmação da senha não são iguais.");

			if (!IsValidEmail(_usuario.Email))
				throw new Exception("O endereço de e-mail informado é inválido.");
		}

		public bool IsValidEmail(string email)
		{
			if (string.IsNullOrWhiteSpace(email))
				return false;

			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}
        public void ValidarPermissao(int _idPermissao)
        {
            if (!new UsuarioDAL().ValidarPermissao(Constantes.IdUsuarioLogado, _idPermissao))
                throw new Exception("Você não tem permissão para executar esta operação.");
        }
    }
}