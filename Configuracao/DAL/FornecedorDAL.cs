using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FornecedorDAL
    {
        public void Inserir(Fornecedor _fornecedor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Fornecedor(NomeSocial, RazaoSocial, CNPJ, IncricaoEstadual, Email, Fone) VALUES(@NomeSocial, @RazaoSocial, @CNPJ, @InscricaoEstadual, @Email, @Fone)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@NomeSocial", _fornecedor.NomeSocial);
                cmd.Parameters.AddWithValue("@RazaoSocial", _fornecedor.RazaoSocial);
                cmd.Parameters.AddWithValue("@CNPJ", _fornecedor.CNPJ);
                cmd.Parameters.AddWithValue("@InscricaoEstadual", _fornecedor.InscricaoEstadual);
                cmd.Parameters.AddWithValue("@Email", _fornecedor.Email);
                cmd.Parameters.AddWithValue("@Fone", _fornecedor.Fone);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um fornecedor no banco de dados", ex) { Data = { { "Id", 22 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Fornecedor> BuscarTodos()
        {
            List<Fornecedor> fornecedorList = new List<Fornecedor>();
            Fornecedor fornecedor = new Fornecedor();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, NomeSocial, RazaoSocial, CNPJ, InscricaoEstadual, Email, Fone FROM Fornecedor";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.NomeSocial = rd["NomeSocial"].ToString();
                        fornecedor.RazaoSocial = rd["RazaoSocial"].ToString();
                        fornecedor.CNPJ = rd["CNPJ"].ToString();
                        fornecedor.InscricaoEstadual = rd["InscricaoEstadual"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();

                        fornecedorList.Add(fornecedor);
                    }
                }
                return fornecedorList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um Fornecedor por Id no banco de dados.", ex) { Data = { { "Id", 23 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Fornecedor> BuscarPorNome(string _nome)
        {
            List<Fornecedor> fornecedorList = new List<Fornecedor>();
            Fornecedor fornecedor = new Fornecedor();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, NomeSocial, RazaoSocial, CNPJ, InscricaoEstadual, Email, Fone FROM Fornecedor WHERE NomeSocial LIKE @NomeSocial";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeSocial", "%" + _nome + "%");


                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.NomeSocial = rd["NomeSocial"].ToString();
                        fornecedor.RazaoSocial = rd["RazaoSocial"].ToString();
                        fornecedor.CNPJ = rd["CNPJ"].ToString();
                        fornecedor.InscricaoEstadual = rd["InscricaoEstadual"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();

                        fornecedorList.Add(fornecedor);
                    }
                }
                return fornecedorList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Fornecedors por nome no banco de dados.", ex) { Data = { { "Id", 24 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Fornecedor BuscarPorId(int _id)
        {
            Fornecedor fornecedor = new Fornecedor();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, NomeSocial, RazaoSocial, CNPJ, InscricaoEstadual, Email, Fone FROM Fornecedor WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);


                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.NomeSocial = rd["NomeSocial"].ToString();
                        fornecedor.RazaoSocial = rd["RazaoSocial"].ToString();
                        fornecedor.CNPJ = rd["CNPJ"].ToString();
                        fornecedor.InscricaoEstadual = rd["InscricaoEstadual"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();

                    }
                }
                return fornecedor;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um Fornecedor por nome no banco de dados.", ex) { Data = { { "Id", 25 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Fornecedor BuscarPorCNPJ(string _cpf)
        {
            Fornecedor fornecedor = new Fornecedor();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, NomeSocial, RazaoSocial, CNPJ, InscricaoEstadual, Email, Fone FROM Fornecedor WHERE CNPJ = @CNPJ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CPF", _cpf);


                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.NomeSocial = rd["NomeSocial"].ToString();
                        fornecedor.RazaoSocial = rd["RazaoSocial"].ToString();
                        fornecedor.CNPJ = rd["CNPJ"].ToString();
                        fornecedor.InscricaoEstadual = rd["InscricaoEstadual"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();

                    }
                }
                return fornecedor;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um Fornecedor por CNPJ no banco de dados.", ex) { Data = { { "Id", 26 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Fornecedor _fornecedor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Fornecedor SET NomeSocial = @NomeSocial, RazaoSocial = @RazaoSocial, 
                                    CNPJ = @CNPJ, InscricaoEstadual = @InscricaoEstadual, Email = @Email, Fone = @Fone 
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _fornecedor.Id);
                cmd.Parameters.AddWithValue("@NomeSocial", _fornecedor.NomeSocial);
                cmd.Parameters.AddWithValue("@RazaoSocial", _fornecedor.RazaoSocial);
                cmd.Parameters.AddWithValue("@CNPJ", _fornecedor.CNPJ);
                cmd.Parameters.AddWithValue("@InscricaoEstadual", _fornecedor.InscricaoEstadual);
                cmd.Parameters.AddWithValue("@Email", _fornecedor.Email);
                cmd.Parameters.AddWithValue("@Fone", _fornecedor.Fone);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar os dados de um Fornecedor no banco de dados", ex) { Data = { { "Id", 27 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Fornecedor WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um Fornecedor do banco de dados.", ex) { Data = { { "Id", 28 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
