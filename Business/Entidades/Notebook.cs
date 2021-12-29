using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Notebook
    {
        public int Memoria { get; set; }
        public Enumeraveis.ArmazenamentoType Armazenamento { get; set; }
        public Enumeraveis.CpuTypes Cpu { get; set; }




        public void PrintNotebook()
        {
            Console.WriteLine(String.Format("Tem {0} pentes de memoria", Memoria));
            Console.WriteLine("Armazenamento do tipo: " + Armazenamento);
            Console.WriteLine("Cpu do tipo: " + Cpu);
        }

        public override string ToString()
        {
            return String.Format("Notebook com CPU {0}, armazenamento {1} e tem {2} pentes de memoria", Cpu.ToString(), Armazenamento.ToString(), Memoria.ToString());
        }
    }
}
