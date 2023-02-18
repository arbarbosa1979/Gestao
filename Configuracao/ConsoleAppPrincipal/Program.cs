using BLL;
using Models;

namespace ConsoleAppPrincipal
{
    public class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                string? asw = "sim";
                while (asw == "sim"){
                    Usuario usuario = new Usuario();
                    UsuarioBLL usuarioBLL = new UsuarioBLL();
                    Console.WriteLine("Digite o nome completo do usuário: ");
                    usuario.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o nome de usuário desejado: ");
                    usuario.NomeUsuario = Console.ReadLine();
                    Console.WriteLine("O usuário estará ativo? Escreva (S) ou (N)");
                    usuario.Ativo = Console.ReadLine().ToUpper() == "S";
                    Console.WriteLine("Digite o email do usuário: ");
                    usuario.Email = Console.ReadLine();
                    Console.WriteLine("Digite o número do CPF com pontos e traços: ");
                    usuario.CPF = Console.ReadLine();
                    Console.WriteLine("Digite a senha do usuário: ");
                    usuario.Senha = Console.ReadLine();

                    usuarioBLL.Inserir(usuario);
                    Console.WriteLine("Deseja inserir outro usuário? ");
                    asw = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}