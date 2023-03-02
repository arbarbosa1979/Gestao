using Models;
using System;
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
                cmd.CommandText = @"INSERT INTO Permissao(Descricao) VALUES (@Descricao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", _permissao.Descricao);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar inserir uma descrição no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public Permissao Buscar(Permissao permissao)
        {
            return new Permissao();
        }
        public void Alterar(Permissao permissao)
        {

        }
        public void Excluir(int _id)
        {

        }

    }
}

