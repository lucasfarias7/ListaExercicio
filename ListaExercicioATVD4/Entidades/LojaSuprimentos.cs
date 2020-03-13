using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioATVD4.Entidades
{
    public class LojaSuprimentos
    {
        public Fatura fatura { get; set; }


        public LojaSuprimentos(Fatura fatura)
        {
            this.fatura = fatura;
        }
    }
}
