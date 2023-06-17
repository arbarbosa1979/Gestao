using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class FornecedorDAL
    {
        public void Inserir(Fornecedor fornecedor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Fornecedor(Nome, Fone, Email, Website) VALUES(@Nome, @Fone, @Email, @Site)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", fornecedor.Nome);
                cmd.Parameters.AddWithValue("@Fone", fornecedor.Fone);
                cmd.Parameters.AddWithValue("@Email", fornecedor.Email);
                cmd.Parameters.AddWithValue("@Site", fornecedor.Site);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um fornecedor no banco de dados", ex) { Data = { { "Id", 33 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Fornecedor> BuscarTodos()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Fone, Email, Website FROM Fornecedor";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Fornecedor fornecedor = new Fornecedor();
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Site = rd["Website"].ToString();

                        fornecedores.Add(fornecedor);
                    }
                }

                return fornecedores;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar fornecedores no banco de dados.", ex) { Data = { { "Id", 34 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Fornecedor BuscarPorId(int id)
        {
            Fornecedor fornecedor = new Fornecedor();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Fone, Email, Website FROM Fornecedor WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Site = rd["Website"].ToString();
                    }
                }

                return fornecedor;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar fornecedor por Id no banco de dados.", ex) { Data = { { "Id", 35 } } };
            }
            finally
            {


                cn.Close();
            }
        }
        public List<Fornecedor> BuscarPorNome(string nome)
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Fone, Email, Website FROM Fornecedor WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + nome + "%");

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Fornecedor fornecedor = new Fornecedor();
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Site = rd["Website"].ToString();

                        fornecedores.Add(fornecedor);
                    }
                }

                return fornecedores;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar fornecedores por nome no banco de dados.", ex) { Data = { { "Id", 36 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Fornecedor BuscarPorSite(string site)
        {
            Fornecedor fornecedor = new Fornecedor();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Fone, Email, Website FROM Fornecedor WHERE Website LIKE @Site";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Site", "%" + site + "%");

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Site = rd["Website"].ToString();
                    }
                }

                return fornecedor;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar fornecedor por site no banco de dados.", ex) { Data = { { "Id", 37 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Fornecedor fornecedor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Fornecedor SET Nome = @Nome, Fone = @Fone, 
                                    Email = @Email, Website = @Site 
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", fornecedor.Id);
                cmd.Parameters.AddWithValue("@Nome", fornecedor.Nome);
                cmd.Parameters.AddWithValue("@Fone", fornecedor.Fone);
                cmd.Parameters.AddWithValue("@Email", fornecedor.Email);
                cmd.Parameters.AddWithValue("@Site", fornecedor.Site);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar os dados de um fornecedor no banco de dados", ex) { Data = { { "Id", 38 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Fornecedor WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um fornecedor do banco de dados.", ex) { Data = { { "Id", 39 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}