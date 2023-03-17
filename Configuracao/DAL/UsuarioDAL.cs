using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO USUARIO(NOME, NOME_USUARIO, CPF_USUARIO, EMAIL_USUARIO, SENHA_USUARIO, ATIVO)

                                    VALUES(@NOME, @NOME_USUARIO, @CPF_USUARIO, @EMAIL_USUARIO, @SENHA_USUARIO, @ATIVO)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NOME", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NOME_USUARIO", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@CPF_USUARIO", _usuario.CPF);
                cmd.Parameters.AddWithValue("@EMAIL_USUARIO", _usuario.Email);
                cmd.Parameters.AddWithValue("@SENHA_USUARIO", _usuario.Senha);
                cmd.Parameters.AddWithValue("@ATIVO", _usuario.Ativo);

                cn.Open();
                cmd.ExecuteScalar();
				
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o usuário no banco de dados: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
		public void Alterar(Usuario _usuario)
		{
			SqlConnection cn = new SqlConnection();
			try
			{
				cn.ConnectionString = Conexao.StringDeConexao;
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;
				cmd.CommandText = @"UPDATE USUARIO SET 
										NOME = @NOME, 
										CPF_USUARIO = @CPF_USUARIO, 
										EMAIL_USUARIO = @EMAIL_USUARIO,
										ATIVO = @ATIVO 
									WHERE ID_USUARIO = @ID_USUARIO";
				cmd.CommandType = System.Data.CommandType.Text;
				cmd.Parameters.AddWithValue("@NOME", _usuario.Nome);
				cmd.Parameters.AddWithValue("@CPF_USUARIO", _usuario.CPF);
				cmd.Parameters.AddWithValue("@EMAIL_USUARIO", _usuario.Email);
				cmd.Parameters.AddWithValue("@ATIVO", _usuario.Ativo);
				cmd.Parameters.AddWithValue("@ID_USUARIO", _usuario.IdUser);

				cn.Open();
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				throw new Exception("Ocorreu um erro ao tentar atualizar o usuário no banco de dados: " + ex.Message);
			}
			finally
			{
				cn.Close();
			}
		}

		public void Excluir(int _id)
		{
			SqlConnection cn = new SqlConnection();
			try
			{
				cn.ConnectionString = Conexao.StringDeConexao;
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;
				cmd.CommandText = @"DELETE FROM USUARIO WHERE ID_USUARIO = @ID_USUARIO";
				cmd.CommandType = System.Data.CommandType.Text;
				cmd.Parameters.AddWithValue("@ID_USUARIO", _id);

				cn.Open();
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				throw new Exception("Ocorreu um erro ao tentar excluir o usuário no banco de dados: " + ex.Message);
			}
			finally
			{
				cn.Close();
			}
		}
        public void AddGrupoUsuario(int idUser, int idGrupoUser)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO UsuarioGrupoUsuario(ID_Usuario, ID_GrupoUsuario) VALUES (@ID_Usuario, @ID_GrupoUsuario)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ID_Usuario", idUser);
                cmd.Parameters.AddWithValue("@ID_GrupoUsuario", idGrupoUser);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um grupo no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
		public void RemoverGrupoUsuario(int idUser, int idGrupoUser)
		{
			SqlConnection cn = new SqlConnection();
			SqlCommand cmd = new SqlCommand();

			try
			{
				cn.ConnectionString = Conexao.StringDeConexao;
				cmd.Connection = cn;
				cmd.CommandText = @"DELETE FROM UsuarioGrupoUsuario WHERE ID_USUARIO = @IdUsuario AND ID_GrupoUsuario = @IdGrupoUsuario";
				cmd.Parameters.AddWithValue("@IdUsuario", idUser);
				cmd.Parameters.AddWithValue("@IdGrupoUsuario", idGrupoUser);
				cmd.CommandType = System.Data.CommandType.Text;

				cn.Open();

				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				throw new Exception("Ocorreu um erro ao tentar remover o usuário do grupo: " + ex.Message);
			}
			finally
			{
				cn.Close();
			}
		}		
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID_USUARIO, NOME, NOME_USUARIO, CPF_USUARIO, EMAIL_USUARIO, ATIVO FROM USUARIO WHERE NOME_USUARIO = @NOME_USUARIO";

                cmd.Parameters.AddWithValue("@NOME_USUARIO", _nomeUsuario);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.IdUser = Convert.ToInt32(rd["ID_USUARIO"]);
                        usuario.Nome = rd["NOME"].ToString();
                        usuario.NomeUsuario = rd["NOME_USUARIO"].ToString();
                        usuario.CPF = rd["CPF_USUARIO"].ToString();
                        usuario.Email = rd["EMAIL_USUARIO"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["ATIVO"]);

                        GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        usuario.GrupoUsuarios = grupoUsuarioDAL.BuscarPorIdGrupo(usuario.IdUser);
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o usuario digitado: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public Usuario BuscarPorId(int idUser)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            Usuario usuario = new Usuario();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID_USUARIO, NOME, NOME_USUARIO, CPF_USUARIO, EMAIL_USUARIO, ATIVO FROM USUARIO WHERE ID_USUARIO = @IdUser";
                cmd.Parameters.AddWithValue("@ID_USUARIO", idUser);
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.IdUser = Convert.ToInt32(rd["ID_USUARIO"]);
                        usuario.Nome = rd["NOME"].ToString();
                        usuario.NomeUsuario = rd["NOME_USUARIO"].ToString();
                        usuario.CPF = rd["CPF_USUARIO"].ToString();
                        usuario.Email = rd["EMAIL_USUARIO"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["ATIVO"]);
                        GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        usuario.GrupoUsuarios = grupoUsuarioDAL.BuscarPorIdGrupo(usuario.IdUser);
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro durante a busca por usuários: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Usuario> ExibirTodosUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario;

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID_USUARIO, NOME_USUARIO, CPF_USUARIO, EMAIL_USUARIO, ATIVO 
                                    FROM USUARIO";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.IdUser = Convert.ToInt32(rd["ID_USUARIO"]);
                        usuario.Nome = rd["NOME_USUARIO"].ToString();
                        usuario.NomeUsuario = rd["NOME_USUARIO"].ToString();
                        usuario.CPF = rd["CPF_USUARIO"].ToString();
                        usuario.Email = rd["EMAIL_USUARIO"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["ATIVO"]);
                        GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        usuario.GrupoUsuarios = grupoUsuarioDAL.BuscarPorIdGrupo(usuario.IdUser);

                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuários: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

		public bool ExisteRelacionamento(int idUser, int idGrupoUser)
		{
			SqlConnection cn = new SqlConnection();
			SqlCommand cmd = new SqlCommand();

			try
			{
				cn.ConnectionString = Conexao.StringDeConexao;
				cmd.Connection = cn;
				cmd.CommandText = @"SELECT COUNT(*) FROM UsuarioGrupoUsuario WHERE ID_USUARIO = @idUser AND ID_GrupoUsuario = @idGrupoUser";
				cmd.Parameters.AddWithValue("@idUser", idUser);
				cmd.Parameters.AddWithValue("@idGrupoUser", idGrupoUser);
				cmd.CommandType = System.Data.CommandType.Text;

				cn.Open();

				int count = Convert.ToInt32(cmd.ExecuteScalar());

				return (count > 0);
			}
			catch (Exception ex)
			{
				throw new Exception("Ocorreu um erro ao tentar verificar o relacionamento do usuário com o grupo de usuário no banco: " + ex.Message);
			}
			finally
			{
				cn.Close();
			}
		}

    }
}