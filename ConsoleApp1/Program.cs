using Builder;
using Business;
using ConsoleApp1;
using System;
using System.Collections.Generic;
namespace Strategy.RealWorld
{
    /// <summary>
    /// Strategy - Sorteamentos, tudo dentro dum canto só, que maravilha
    /// Builder - Criação do Notebook
    /// Prototype - Poder Clonar o Aluno
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {

            ListaSorteada alunos = new ListaSorteada();
            Aluno aluno;

            NotebookDirector director = new NotebookDirector();
            ConcretNotebookBuilder notebookBuilder = new ConcretNotebookBuilder();


            director.ConstructNotebookAluno(notebookBuilder);
            aluno = new Aluno("zé", "12312312312");
            aluno.Notebook = notebookBuilder.GetNotebook();
            alunos.Add(aluno);

            director.ConstructNotebookAluno(notebookBuilder);
            aluno = new Aluno("suzana", "69696969691");
            aluno.Notebook = notebookBuilder.GetNotebook();
            alunos.Add(aluno);

            //Aluna privilegiada 
            director.ConstructNotebookProfessor(notebookBuilder);
            aluno = new Aluno("maria", "32131231232");
            aluno.Notebook = notebookBuilder.GetNotebook();
            alunos.Add(aluno);

            //Filho do diretor, e sim, isso é errado
            director.ConstructNotebookDiretor(notebookBuilder);
            aluno = new Aluno("Enzo", "99999999911");
            aluno.Notebook = notebookBuilder.GetNotebook();
            alunos.Add(aluno);

            alunos.SetSorteamentoStrategy(new NomeSort());
            alunos.Sort();
            alunos.SetSorteamentoStrategy(new CpfSort());
            alunos.Sort();
            alunos.SetSorteamentoStrategy(new CpuNoteSort());
            alunos.Sort();
            alunos.SetSorteamentoStrategy(new MemoriaSort());
            alunos.Sort();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Venhamos a entender que hipoteticamente, uma parte do");
            Console.WriteLine(" programa irá precisar manipular o nome do aluno. Para");
            Console.WriteLine("não alterar o nome dele no resto do sistema, ele precisará clona-lo");
            Console.WriteLine();
            Console.WriteLine();

            var alunoOrigi = aluno;
            var alunoManip = aluno.Clone();

            Console.WriteLine("Alunos originais:");
            Console.WriteLine(alunoOrigi);
            Console.WriteLine(alunoManip);
            Console.WriteLine();

            alunoOrigi.Nome = String.Format("{0} - {1}", alunoOrigi.Nome, alunoOrigi.Cpf);
            Console.WriteLine("Modificado");
            Console.WriteLine(alunoOrigi);
            Console.WriteLine(alunoManip);



            Console.ReadKey();
        }
    }  
}