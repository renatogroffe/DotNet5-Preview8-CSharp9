using System;
using System.Text.Json;

namespace ExemploInitOnlyProperties
{
    class Program
    {
        static void Main()
        {
            var saoPaulo = new Estado()
            {
                Sigla = "SP",
                Nome = "Sao Paulo"
            };
            Console.WriteLine(JsonSerializer.Serialize(saoPaulo));

            var santaCatarina = new Estado("SC", "Santa Catarina");
            Console.WriteLine(JsonSerializer.Serialize(santaCatarina));
        }
    }
}