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
                cmd.Parameters.AddWithValue("@IdPermissao", _permissao.Id);
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
                cmd.Parameters.AddWithValue("@id", _permissao.Id);


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
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"DELETE FROM Permissao WHERE ID = @IdPermissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPermissao", _id);

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

        public Permissao BuscarPorId(int _id)
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
                        permissao.Id= Convert.ToInt32(rd["ID"]);
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
        public List<Permissao> ExibirTodasPermissoes()
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT * FROM Permissao";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                List<Permissao> permissoes = new List<Permissao>();

                while (reader.Read())
                {
                    Permissao permissao = new Permissao();
                    permissao.Descricao = Convert.ToString(reader["Descricao"]);

                    permissoes.Add(permissao);
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
    }
}
