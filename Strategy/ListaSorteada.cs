
using Business;


namespace ConsoleApp1
{
    public class ListaSorteada
    {
        private List<Aluno> lista = new List<Aluno>();
        private SorteamentoStrategy? SorteamentoStrategy;

        

        public ListaSorteada()
        {
        }

        public void SetSorteamentoStrategy(SorteamentoStrategy sortstrategy)
        {
            this.SorteamentoStrategy = sortstrategy;
        }
        public void Add(Aluno aluno)
        {
            lista.Add(aluno);
        }
        public void AddRange(List<Aluno> listaAluno)
        {
            lista.AddRange(listaAluno);
        }
        public void Sort()
        {
            SorteamentoStrategy.Sort(lista);
            
            foreach (Aluno aluno in lista)
            {
                Console.WriteLine(" " + aluno.ToString());
            }
            Console.WriteLine();
        }
    }

    public class CpuNoteSort : SorteamentoStrategy
    {
        public override void Sort(List<Aluno> list)
        {
            list.Sort((x,y) => string.Compare(x.Notebook.Cpu.ToString(), y.Notebook.Cpu.ToString()));
            Console.WriteLine("Lista sorteada por cpu do notebook ");
        }
    }

    public class NomeSort : SorteamentoStrategy
    {
        public override void Sort(List<Aluno> list)
        {
            list.Sort((x,y) => string.Compare(x.Nome, y.Nome));
            Console.WriteLine("Lista sorteada por nome ");
        }
    }

    public class CpfSort : SorteamentoStrategy
    {
        public override void Sort(List<Aluno> list)
        {
            list.Sort((x,y) => string.Compare(x.Cpf, y.Cpf));  
            Console.WriteLine("Lista sorteada por cpf ");
        }
    }

    public abstract class SorteamentoStrategy
    {
        public abstract void Sort(List<Aluno> list);
    }
}
