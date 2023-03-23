using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class PermissaoDAL
    {
        public void Inserir(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO Permissao(ID, Descricao) VALUES (@IdPermissao, @Descricao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPermissao", _permissao.ID);
                cmd.Parameters.AddWithValue("@Descricao", _permissao.Descricao);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar inserir uma permissão no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
        public void Alterar(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE Permissao SET Descricao = @descricao WHERE ID = @id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@descricao", _permissao.Descricao);
                cmd.Parameters.AddWithValue("@id", _permissao.ID);


                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar uma permissão no banco " + ex.Message);


            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"DELETE FROM Permissao WHERE ID = @IdPermissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPermissao", _permissao.ID);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir a permissão no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Permissao> BuscarPermissaoPorNome(string _nomePermissao)
        {
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT ID, Descricao FROM Permissao WHERE  UPPER (Descricao) lIKE UPPER(@nome)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", "%" + _nomePermissao + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["id_Permissao"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                        GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        permissao.GrupoUsuarios = grupoUsuarioDAL.BuscarPorIdGrupo(permissao.Id);
                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar Permissões no banco de dados: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public Permissao BuscarPermPorId(int _id)
        {
            Permissao permissao = new Permissao();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT TOP 100 ID, Descricao FROM Permissao WHERE ID = @IdPermissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPermissao", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.ID= Convert.ToInt32(rd["ID"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar uma permissão no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return permissao;
        }
        public List<Permissao> ExibirTodasPermissoes(int _id)
        {
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT ID, Descricao FROM Permissao WHERE ID = @id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.ID = Convert.ToInt32(rd["ID"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                        GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        permissao.GrupoUsuarios = grupoUsuarioDAL.(permissao.ID);
                        permissoes.Add(permissao);
                    }
                }

                return permissoes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar exibir todas as permissões no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public bool IdPermissaoExistente(int _id)
        {
            Permissao permissao = new Permissao();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 AS retorno FROM Permissao  WHERE ID = @id ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar incluir a permissão: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public bool PermissaoVinculadaGrupo(int _id)
        {

            Permissao permissao = new Permissao();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 AS retorno FROM PermissaoGrupoUsuario WHERE ID_Permissao = @id ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar relacionamentos de permissão com o grupo: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
