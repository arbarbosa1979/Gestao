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
  //              SqlCommand cmd = new SqlCommand();
                SqlCommand cmd = new SqlCommand("SELECT * FROM USUARIO ORDER BY Nome", cn);
            }
            catch (Exception)
            {

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