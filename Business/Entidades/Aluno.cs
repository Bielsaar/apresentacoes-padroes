using Business.Abstract;

namespace Business
{
    public class Aluno : AlunoPrototype
    {
        public string Nome { get; set; }
        public string Cpf { get; set; } 
        public Notebook Notebook { get; set; }

        public Aluno(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
            Notebook = new Notebook();
        }

        public override string ToString()
        {
            var note = Notebook;
            return String.Format("Aluno {0}, cpf n {1} com {2}", this.Nome, this.Cpf, this.Notebook);
        }

        public override Aluno Clone()
        {
            //Aluno aluno = new Aluno(this.Nome, this.Cpf);
            //aluno.Notebook = this.Notebook;
            return this.MemberwiseClone() as Aluno;
        }
    }
}