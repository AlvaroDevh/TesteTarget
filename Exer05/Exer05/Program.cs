namespace Exer05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a palavra");
            string palavra = Console.ReadLine();
            string palavraInvertida = "";

            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                palavraInvertida += palavra[i];
            }

            Console.WriteLine("Palavra invertida: " + palavraInvertida);

        }
    }
}
