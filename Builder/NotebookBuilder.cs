using Business;

namespace Builder
{
    public abstract class NotebookBuilder
    {
        protected Notebook notebook;

        public void CreateNotebook()
        {
            notebook = new Notebook();
        }

        public abstract void setTipoCpu(Enumeraveis.CpuTypes cpu);
        public abstract void setTipoArmazenamento(Enumeraveis.ArmazenamentoType armazenamento);
        public abstract void addPenteMemoria(int quantidade = 1);

        

    }

    public class ConcretNotebookBuilder : NotebookBuilder
    {

        
        public Notebook GetNotebook() { return notebook; }

        public override void setTipoCpu(Enumeraveis.CpuTypes cpu)
        {
            this.notebook.Cpu = cpu;
        }

        public override void setTipoArmazenamento(Enumeraveis.ArmazenamentoType armazenamento)
        {
            this.notebook.Armazenamento = armazenamento;
        }

        public override void addPenteMemoria(int quantidade = 1)
        {
            this.notebook.Memoria += quantidade;
        }


    }

    public class NotebookDirector
    {
        public void ConstructNotebookDiretor(NotebookBuilder builder)
        {
            builder.CreateNotebook();
            builder.setTipoCpu(Enumeraveis.CpuTypes.AMD);
            builder.setTipoArmazenamento(Enumeraveis.ArmazenamentoType.SSD);
            builder.addPenteMemoria(4);
            
        }

        public void ConstructNotebookAluno(NotebookBuilder builder)
        {
            builder.CreateNotebook();
            builder.setTipoCpu(Enumeraveis.CpuTypes.INTEL);
            builder.setTipoArmazenamento(Enumeraveis.ArmazenamentoType.HDD);
            builder.addPenteMemoria();
        }

        public void ConstructNotebookProfessor(NotebookBuilder builder)
        {
            builder.CreateNotebook();
            builder.setTipoCpu(Enumeraveis.CpuTypes.AMD);
            builder.setTipoArmazenamento(Enumeraveis.ArmazenamentoType.SSD);
            builder.addPenteMemoria(2);
        }

    }

}