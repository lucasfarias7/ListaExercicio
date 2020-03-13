using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioATVD3.Atvd3
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }

        public string Marca { get; set; }

        public DateTime Ano { get; set; }

        public double PrecoLoc { get; set; }

        public int QtdLoc { get; set; }


        public Veiculo()
        {
        }

        public Veiculo(string modelo, string marca, DateTime ano, double precoLoc, int qtdDaysLoc)
        {
            this.Modelo = modelo;
            this.Marca = marca;
            this.Ano = ano;
            this.PrecoLoc = precoLoc;
            this.QtdLoc = qtdDaysLoc;
        }


        public virtual double PrecoLocacao()
        {
            return this.PrecoLoc * this.QtdLoc;
        }
    }
}
