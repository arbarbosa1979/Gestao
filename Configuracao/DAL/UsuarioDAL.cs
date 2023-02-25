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
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            return new Usuario();
        }
        public List<Usuario> BuscarTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario;

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, Email, Ativo 
                                    FROM Usuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);

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
        public void Alterar(Usuario _usuario)
        {

        }
        public void Excluir(int _id)
        {
 
        }

    }
}