using System.Collections.Generic;

namespace ExemploCovariant
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
    }

    public class Aluno : Pessoa
    {
        public string RA { get; set; }
    }

    public class Professor : Pessoa
    {
        public string CodFuncionario { get; set; }
    }

    public abstract class AtividadeAcademica
    {
        public string Descricao { get; set; }
        public abstract IEnumerable<Pessoa> ListarParticipantes();
    }

    public class Aula : AtividadeAcademica
    {
        private Aluno[] _alunos;

        public Aula(Aluno[] alunos)
        {
            _alunos = alunos;
        }

        public override IEnumerable<Aluno> ListarParticipantes()
        {
            return _alunos;
        }
    }

    public class ReuniaoDocencia : AtividadeAcademica
    {
        private Professor[] _professores;

        public ReuniaoDocencia(Professor[] professores)
        {
            _professores = professores;
        }

        public override IEnumerable<Professor> ListarParticipantes()
        {
            return _professores;
        }
    }
}