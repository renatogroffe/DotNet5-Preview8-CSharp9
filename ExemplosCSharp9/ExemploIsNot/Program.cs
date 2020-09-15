using System;

namespace ExemploIsNot
{
    class Program
    {
        static void Main()
        {
            var valores = new object[] { "Teste 1", 2, 3.0, null, "Teste 5", null, DateTime.Now };

            foreach (object valor in valores)
            {
                if (valor is not null)
                {
                    if (valor is not string)
                        Console.WriteLine($"Tipo: {valor.GetType().FullName} - Valor: {valor}");
                    else
                        Console.WriteLine($"Encontrada uma string: {valor}");
                }
                else
                    Console.WriteLine("Encontrado um valor nulo...");
            }
        }
    }
}