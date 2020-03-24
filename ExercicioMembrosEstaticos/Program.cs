using System;
using System.Globalization;

namespace ExercicioMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler a cotação do dólar ,e depois um valor em dólares a ser comprado por uma pessoa em reais.
            Informar quantos reais a pessoa vai pagar pelo dólares,considerando que a pessoa terá que pagar 6% de IOF SOBRE o valor em dólar.Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.*/
            
            Console.WriteLine("Qual é a cotação do dólar? : ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);
            
            Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
