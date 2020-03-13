using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioATVD3.Atvd3
{
    public class Passeio : Veiculo
    {
        public double ValorFixoPas { get; set; }


        public Passeio()
        {
        }

        public Passeio(string modelo, string marca, DateTime ano, double precoLoc, int qtdDaysLoc, double valorFixo) 
            : base(modelo, marca, ano, precoLoc, qtdDaysLoc)
        {
            this.ValorFixoPas = valorFixo;
        }


        public override double PrecoLocacao()
        {
            this.ValorFixoPas = 60 - 20;
            return base.PrecoLocacao() + this.ValorFixoPas;
        }
    }
}
