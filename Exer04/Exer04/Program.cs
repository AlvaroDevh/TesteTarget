namespace Exer04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double MG = 29.22988, RJ = 36.67866, SP = 67.83643, ES = 27.16548, OUTROS = 19.84953;

            double soma = MG + RJ + SP + ES + OUTROS;

            Console.WriteLine("RJ: " + (RJ / soma * 100).ToString("F2") + "%");
            Console.WriteLine("MG: " + (MG / soma * 100).ToString("F2") + "%");
            Console.WriteLine("ES: " + (ES / soma * 100).ToString("F2") + "%");
            Console.WriteLine("SP: " + (SP / soma * 100).ToString("F2") + "%");
            Console.WriteLine("Outros: " + (OUTROS / soma * 100).ToString("F2") + "%");

        }
    }
}
