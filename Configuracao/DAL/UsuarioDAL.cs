using Models;
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
                cn.ConnectionString = Conexao.StringdDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO USUARIO(NOME, NOME_USUARIO, CPF_USUARIO, EMAIL_USUARIO, SENHA_USUARIO, ATIVO)" +
                                    "VALUES(@NOME, @NOME_USUARIO, @CPF_USUARIO, @EMAIL_USUARIO, @SENHA_USUARIO, @ATIVO)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NOME", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NOME_USUARIO", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@CPF_USUARIO", _usuario.CPF);
                cmd.Parameters.AddWithValue("@EMAIL_USUARIO", _usuario.Email);
                cmd.Parameters.AddWithValue("@SENHA_USUARIO", _usuario.Senha);
                cmd.Parameters.AddWithValue("@ATIVO", _usuario.Ativo);

                cn.Open();
                cmd.ExecuteScalar();
                
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM USUARIO ORDER BY Nome", cn);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public Usuario Buscar(string _nomeUsuario)
        {
            return new Usuario();
        }
        public void Alterar(Usuario _usuario)
        {

        }
        public void Excluir(int _id)
        {

        }

    }
}