// See https://aka.ms/new-console-template for more information
namespace 1157
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um número inteiro para mostrar todos os seus divisores positivos: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
