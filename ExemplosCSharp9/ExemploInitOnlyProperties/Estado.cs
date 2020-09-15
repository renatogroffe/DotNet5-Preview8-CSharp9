namespace ExemploInitOnlyProperties
{
    public class Estado
    {
        public string Sigla { get; init; }
        public string Nome { get; init; }

        public Estado() { }

        public Estado(string sigla, string nome)
        {
            Sigla = sigla;
            Nome = nome;
        }
    }
}