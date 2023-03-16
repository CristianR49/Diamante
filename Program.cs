namespace Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("De um número N ímpar, será desenhado um diamante de x com N altura e N largura");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("Número par, digite novamente");
                    continue;
                }
                int espaco = (n - 1) / 2;
                int intx = 1;
                int plado = ((n - 1) / 2) + 1;
                int slado = ((n - 1) / 2);

                for (int i = n; i > plado; i--)
                {
                    for (int a = 0; a < espaco; a++)
                    {
                        Console.Write(" ");
                    }
                    for (int a = 0; a < intx; a++)
                    {
                        Console.Write("x");
                    }
                    for (int a = 0; a < espaco; a++)
                    {
                        Console.Write(" ");
                    }
                    espaco--;
                    intx += 2;
                    Console.Write("\n");
                }
                for (int i = n; i > slado; i--)
                {
                    for (int a = 0; a < espaco; a++)
                    {
                        Console.Write(" ");
                    }
                    for (int a = 0; a < intx; a++)
                    {
                        Console.Write("x");
                    }
                    for (int a = 0; a < espaco; a++)
                    {
                        Console.Write(" ");
                    }
                    espaco++;
                    intx -= 2;
                    Console.Write("\n");
                }
                Console.ReadLine();
            }
        }
    }
}