using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioATVD3.Atvd3
{
    public class Utilitario : Veiculo
    {
        public double ValorUtil { get; set; }

        public Utilitario()
        {
        }

        public Utilitario(string modelo, string marca, DateTime ano, double precoLoc, int qtdDaysLoc, double valorUtil)
            : base(modelo, marca, ano, precoLoc, qtdDaysLoc)
        {
            this.ValorUtil = valorUtil;
        }


        public override double PrecoLocacao()
        {
            // 100 é o valor fixo que eu definir para o carro utilitario e os 40 é o acrescentado pela locadora.
            this.ValorUtil = 100 + 40;
            return base.PrecoLocacao() + this.ValorUtil;
        }


        

    }
}
