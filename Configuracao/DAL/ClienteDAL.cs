using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class ClienteDAL
    {
        public void Inserir(Cliente cliente)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO CLIENTE (NOME_CLIENTE, CPF_CLIENTE, RG_CLIENTE, SEXO_CLIENTE, DATA_NASCIMENTO_CLIENTE, ENDERECO_CLIENTE, CIDADE_CLIENTE, ESTADO_CLIENTE, CEP_CLIENTE) VALUES (@NomeCliente, @CPFCliente, @RGCliente, @SexoCliente, @DataNascimentoCliente, @EnderecoCliente, @CidadeCliente, @EstadoCliente, @CEPCliente); SELECT SCOPE_IDENTITY();";
                cmd.Parameters.AddWithValue("@NomeCliente", cliente.Nome);
                cmd.Parameters.AddWithValue("@CPFCliente", cliente.CPF);
                cmd.Parameters.AddWithValue("@RGCliente", cliente.RG);
                cmd.Parameters.AddWithValue("@SexoCliente", cliente.Sexo);
                cmd.Parameters.AddWithValue("@DataNascimentoCliente", cliente.DataNascimento);
                cmd.Parameters.AddWithValue("@EnderecoCliente", cliente.Endereco);
                cmd.Parameters.AddWithValue("@CidadeCliente", cliente.Cidade);
                cmd.Parameters.AddWithValue("@EstadoCliente", cliente.Estado);
                cmd.Parameters.AddWithValue("@CEPCliente", cliente.CEP);

                cn.Open();
                cliente.IdCliente = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao inserir o cliente: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Atualizar(Cliente cliente)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"UPDATE CLIENTE SET NOME_CLIENTE = @NomeCliente, CPF_CLIENTE = @CPFCliente, RG_CLIENTE = @RGCliente, SEXO_CLIENTE = @SexoCliente, DATA_NASCIMENTO_CLIENTE = @DataNascimentoCliente, ENDERECO_CLIENTE = @EnderecoCliente, CIDADE_CLIENTE = @CidadeCliente, ESTADO_CLIENTE = @EstadoCliente, CEP_CLIENTE = @CEPCliente WHERE ID_CLIENTE = @IdCliente";
                cmd.Parameters.AddWithValue("@NomeCliente", cliente.Nome);
                cmd.Parameters.AddWithValue("@CPFCliente", cliente.CPF);
                cmd.Parameters.AddWithValue("@RGCliente", cliente.RG);
                cmd.Parameters.AddWithValue("@SexoCliente", cliente.Sexo);
                cmd.Parameters.AddWithValue("@DataNascimentoCliente", cliente.DataNascimento);
                cmd.Parameters.AddWithValue("@EnderecoCliente", cliente.Endereco);
                cmd.Parameters.AddWithValue("@CidadeCliente", cliente.Cidade);
                cmd.Parameters.AddWithValue("@EstadoCliente", cliente.Estado);
                cmd.Parameters.AddWithValue("@CEPCliente", cliente.CEP);
                cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao atualizar o cliente: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int id)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM CLIENTE WHERE ID_CLIENTE = @IdCliente";
                cmd.Parameters.AddWithValue("@IdCliente", id);
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao excluir o cliente: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public Cliente BuscarPorNome(string _nomeCliente)
        {
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT * FROM Clientes WHERE Nome LIKE @Nome";

                cmd.Parameters.AddWithValue("@Nome", _nomeCliente);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            cliente = new Cliente();
                            cliente.IdCliente = (int)rd["IdCliente"];
                            cliente.Nome = (string)rd["Nome"];
                            cliente.CPF = (string)rd["CPF"];
                            cliente.RG = (string)rd["RG"];
                            cliente.Endereco = (string)rd["Endereco"];
                            cliente.Cidade = (string)rd["Cidade"];
                            cliente.Estado = (string)rd["Estado"];
                            cliente.CEP = (string)rd["CEP"];
                            cliente.Telefone = (string)rd["Telefone"];
                            cliente.Email = (string)rd["Email"];
                            cliente.DataNascimento = (DateTime)rd["DataNascimento"];
                        }
                    }
                return cliente;
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
        public Cliente BuscarPorID(int idCliente)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            Cliente cliente = null;

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;

                cmd.CommandText = @"SELECT IdCliente, Nome, Endereco, Cidade, Estado, CEP, RG, CPF, Sexo, DataNascimento FROM Clientes WHERE IdCliente = @IdCliente";
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.IdCliente = Convert.ToInt32(rd["IdCliente"]);
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.Endereco = rd["Endereco"].ToString();
                        cliente.Cidade = rd["Cidade"].ToString();
                        cliente.Estado = rd["Estado"].ToString();
                        cliente.CEP = rd["CEP"].ToString();
                        cliente.RG = rd["RG"].ToString();
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.Sexo = rd["Sexo"].ToString();
                        cliente.DataNascimento = Convert.ToDateTime(rd["DataNascimento"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro durante a busca por clientes: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

            if (cliente == null)
            {
                throw new Exception("Cliente não encontrado.");
            }

            return cliente;
        }
        public List<Cliente> BuscarPorTodos()
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente cliente;

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IdCliente, Nome, Endereco, Cidade, Estado, CEP, RG, CPF, Sexo, DataNascimento
                                FROM Cliente";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.IdCliente = Convert.ToInt32(rd["IdCliente"]);
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.Endereco = rd["Endereco"].ToString();
                        cliente.Cidade = rd["Cidade"].ToString();
                        cliente.Estado = rd["Estado"].ToString();
                        cliente.CEP = rd["CEP"].ToString();
                        cliente.RG = rd["RG"].ToString();
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.Sexo = rd["Sexo"].ToString();
                        cliente.DataNascimento = Convert.ToDateTime(rd["DataNascimento"]);

                        clientes.Add(cliente);
                    }
                }
                if (clientes.Count == 0)
                {
                    throw new Exception("Não há clientes cadastrados.");
                }
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar os clientes. Erro: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
