using System;

namespace ExemploLogicalPatterns
{
    class Program
    {
        public static string AnalisarPeriodoHistorico(int ano) =>
             ano switch
             {
                 < -4000 => "Pré-História",
                 >= -4000 and < 1453 => "Antiguidade ou Idade Média",
                 >= 1453 => "Idade Moderna ou Contemporânea"
             };

        static void Main()
        {
            int[] anos = { 236, 1982, 1089, -10000, 2020, 625, -429, 1500, 1810, 1947 };
            foreach (int ano in anos)
                Console.WriteLine($"{ano} = {AnalisarPeriodoHistorico(ano)}");
        }
    }
}