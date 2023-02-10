namespace ConsoleAppPrincipal
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int x;
            int y;
            int z;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Informe o primeiro número: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o segundo número: ");
                z = Convert.ToInt32(Console.ReadLine());

                try
                {
                    x = y / z;
                    Console.WriteLine("O resultado é: " + x);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao tentar realizar a divisão: " + ex.Message);
                }
                finally
                {

                }
                Console.WriteLine("\nPressione ENTER para continuar.");
                Console.ReadLine();
            }
        }
    }
}