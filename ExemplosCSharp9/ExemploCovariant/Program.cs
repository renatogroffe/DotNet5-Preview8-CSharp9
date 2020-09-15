using System;

namespace ExemploCovariant
{
    class Program
    {
        static void Main()
        {
            var aula = new Aula(new Aluno[]
            {
                new Aluno() { Nome = "Joao da Silva", RA = "00001" },
                new Aluno() { Nome = "Maria de Oliveira", RA = "00002" }
            }) { Descricao = "Aula de Geografia" };

            Console.WriteLine($"*** {aula.Descricao} ***");
            foreach (var participanteAula in aula.ListarParticipantes())
            {
                Console.WriteLine($"{participanteAula.RA} - {participanteAula.Nome}");
            }

            Console.WriteLine("");

            var reuniao = new ReuniaoDocencia(new Professor[]
            {
                new Professor() { Nome = "Jose Martins", CodFuncionario = "00012" },
                new Professor() { Nome = "Joana Ferreira", CodFuncionario = "00034" }
            })
            { Descricao = "Reuniao Semestral" };


            Console.WriteLine($"*** {reuniao.Descricao} ***");
            foreach (var participanteReuniao in reuniao.ListarParticipantes())
            {
                Console.WriteLine($"{participanteReuniao.CodFuncionario} - {participanteReuniao.Nome}");
            }
        }
    }
}