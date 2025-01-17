namespace Exer02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número.");
            Console.WriteLine("Digite -1 para encerrar.");

            int numero;

            do
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero != -1)
                {
                    if (Fibonacci(numero))
                    {
                        Console.WriteLine(numero + " pertence à sequência.");
                    }
                    else
                    {
                        Console.WriteLine(numero + " não pertence à sequência.");
                    }
                }

            } while (numero != -1);

            Console.WriteLine("Programa encerrado.");
        }

        static bool Fibonacci(int num)
        {
            int a = 0, b = 1, temp;
            bool valido = false;

            while (b <= num && !valido)
            {
                if (b == num)
                {
                    valido = true;
                }
                else
                {
                    temp = a + b;
                    a = b;
                    b = temp;
                }
            }

            return valido;
        }
    }
}