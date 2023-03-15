using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class GrupoUsuarioDAL
    {
        public void Inserir(GrupoUsuario _grupoUsuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO GrupoUsuario(NomeGrupo) VALUES (@NomeGrupo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupoUsuario.NomeGrupo);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o nome do grupo no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(GrupoUsuario _grupoUsuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"UPDATE GrupoUsuario SET NomeGrupo = @NomeGrupo WHERE ID = @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupoUsuario.NomeGrupo);
                cmd.Parameters.AddWithValue("@ID", _grupoUsuario.IdGrupoUser);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar o nome do grupo no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int id)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"DELETE FROM GrupoUsuario WHERE ID = @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", id);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir o grupo de usuário no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<GrupoUsuario> BuscarPorIdGrupo(int _idGrupo)
        {
            List<GrupoUsuario> listaGruposUsuario = new List<GrupoUsuario>();
            GrupoUsuario grupoUsuario = new GrupoUsuario();

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT TOP 100 ID, NomeGrupoUsuario FROM GrupoUsuario WHERE ID = @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", _idGrupo);

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    grupoUsuario = new GrupoUsuario();
                    grupoUsuario.IdGrupoUser = Convert.ToInt32(dr["ID"]);
                    grupoUsuario.NomeGrupo = dr["NomeGrupo"].ToString();
                    listaGruposUsuario.Add(grupoUsuario);
                }

                return listaGruposUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o grupo de usuário no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<GrupoUsuario> ExibirTodosGrupos()
        {
            SqlConnection cn = new SqlConnection();
            List<GrupoUsuario> listaGruposUsuario = new List<GrupoUsuario>();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT * FROM GrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    GrupoUsuario grupoUsuario = new GrupoUsuario();
                    grupoUsuario.IdGrupoUser = Convert.ToInt32(dr["ID"]);
                    grupoUsuario.NomeGrupo = dr["NomeGrupo"].ToString();
                    listaGruposUsuario.Add(grupoUsuario);
                }

                return listaGruposUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os grupos de usuários no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
