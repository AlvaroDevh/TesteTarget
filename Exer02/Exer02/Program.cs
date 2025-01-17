using System;
using System.Linq;

namespace Exer02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] valores = {
                22174.1664, 24537.6698, 26139.6134, 0.0, 0.0, 26742.6612, 0.0,
                42889.2258, 46251.174, 11191.4722, 0.0, 0.0, 3847.4823, 373.7838,
                2659.7563, 48924.2448, 18419.2614, 0.0, 0.0, 35240.1826, 43829.1667,
                18235.6852, 4355.0662, 13327.1025, 0.0, 0.0, 25681.8318, 1718.1221,
                13220.495, 8414.61
            };

            double menor = double.MaxValue;
            double maior = double.MinValue;
            double soma = 0, media;
            int qtd = 0, diasAcima;

            foreach (double valor in valores)
            {
                if (valor > 0)
                {
                    if (valor < menor)
                        menor = valor;

                    if (valor > maior)
                        maior = valor;

                    soma += valor;
                    qtd++;
                }
            }

            media = soma / qtd;

            diasAcima = valores.Count(v => v > media);

            Console.WriteLine("Dia Menor faturamento: " + menor);
            Console.WriteLine(" Dia Maior faturamento: " + maior);
            Console.WriteLine("Média mensal: " + media);
            Console.WriteLine("Dias com faturamento acima da média: " + diasAcima);
        }
    }
}
