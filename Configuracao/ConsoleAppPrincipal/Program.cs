using BLL;
using Models;

namespace ConsoleAppPrincipal
{
    public class Program
    {
        private static void Main(string[] args)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Nome = "Antonio Renato Barbosa";
            usuario.NomeUsuario = "arenato";
            usuario.Ativo = true;
            usuario.Email = "arbarbosa1979@gmail.com";
            usuario.CPF = "871.531.731-53";
            usuario.Senha = "1234";
            usuarioBLL.Inserir(usuario);

        }
    }
}