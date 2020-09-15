using System;
using System.Collections.Generic;

namespace ExemploRelationalPatterns
{
    public enum ClassificacaoIMC
    {
        Magreza,
        Normal,
        Sobrepeso,
        Obesidade,
        ObesidadeGrave
    }

    public class MedidasPessoa
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double IMC => Peso / (Altura * Altura);
    }

    class Program
    {
        public static ClassificacaoIMC AnalisarPeso(double imc) =>
                imc switch
                {
                    < 18.5 => ClassificacaoIMC.Magreza,
                    < 25.0 => ClassificacaoIMC.Normal,
                    < 29.9 => ClassificacaoIMC.Sobrepeso,
                    < 40.0 => ClassificacaoIMC.Obesidade,
                    _ => ClassificacaoIMC.ObesidadeGrave
                };

        static void Main()
        {
            var pessoas = new List<MedidasPessoa>
            {
                new MedidasPessoa() { Peso = 70, Altura = 2.05 },
                new MedidasPessoa() { Peso = 75, Altura = 1.81 },
                new MedidasPessoa() { Peso = 130, Altura = 1.90 },
                new MedidasPessoa() { Peso = 150, Altura = 1.60 },
                new MedidasPessoa() { Peso = 70, Altura = 1.54 }
            };

            foreach (var pessoa in pessoas)
                Console.WriteLine($"Peso: {pessoa.Peso} | Altura: {pessoa.Altura} | " +
                    $"Estado: {AnalisarPeso(pessoa.IMC)}");
        }
    }
}