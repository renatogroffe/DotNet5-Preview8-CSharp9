using System;
using System.Text.Json;

namespace ExemploRecords
{
    public record Imposto
    {
        public string Sigla { get; init; }
        public string Nome { get; init; }
        public double VlPercAliquota { get; init; }

        public Imposto() { }
        public Imposto(string sigla, string nome, double vlPercAliquota) =>
            (Sigla, Nome, VlPercAliquota) = (sigla, nome, vlPercAliquota);
    }

    public record ImpostoEstadual : Imposto
    {
        public string CodEstado { get; init; }
    }

    public record ImpostoMunicipal : Imposto
    {
        public string NomeCidade { get; init; }

        public ImpostoMunicipal(string sigla, string nome, double vlPercAliquota, string nomeCidade) :
            base(sigla, nome, vlPercAliquota) => (NomeCidade) = (nomeCidade);
    }

    class Program
    {
        private static void ExibirDadosRecord(object imposto) =>
            Console.WriteLine(JsonSerializer.Serialize(imposto));

        static void Main()
        {
            Console.WriteLine("Criando um Record...");
            var ipi10 = new Imposto(
                "IPI", "Imposto sobre Produtos Industrializados", 10);
            ExibirDadosRecord(ipi10);

            Console.WriteLine("Criando um Record com With-expression...");
            Imposto ipi07 = ipi10 with { VlPercAliquota = 7 };
            ExibirDadosRecord(ipi07);

            Console.WriteLine("Criando um Record com construtor sem parametros...");
            var irpf15 = new Imposto()
            {
                Sigla = "IRPF",
                Nome = "Imposto de Renda sobre Pessoa Fisica",
                VlPercAliquota = 15
            };
            ExibirDadosRecord(irpf15);

            Console.WriteLine("Testando a heranca em Records - parte 1...");
            ImpostoEstadual icms12 = new()
            {
                Sigla = "ICMS",
                Nome = "Imposto sobre Circulacao de Mercadorias e Servicos",
                VlPercAliquota = 12,
                CodEstado = "SP"
            };
            ExibirDadosRecord(icms12);

            Console.WriteLine("Testando a heranca em Records - parte 2...");
            ImpostoEstadual icms08 =
                icms12 with { CodEstado = "MG", VlPercAliquota = 8 };
            ExibirDadosRecord(icms08);

            Console.WriteLine("Testando a heranca em Records - parte 3...");
            ImpostoMunicipal iss05 =
                new("ISS", "Imposto sobre Servico", 5, "Sao Paulo");
            ExibirDadosRecord(iss05);
        }
    }
}