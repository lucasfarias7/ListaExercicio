using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioATVD4.Entidades
{
    public class Fatura
    {
        public string Numero { get; set; }

        public string Descricao { get; set; }

        public int QtdItem { get; set; }

        public double PrecoItem { get; set; }


        public Fatura()
        {
        }

        public Fatura(string numero, string descricao, int qtdItem, double precoItem)
        {
            Numero = numero;
            Descricao = descricao;
            QtdItem = qtdItem;
            PrecoItem = precoItem;
        }


        public double ValorFatura()
        {
            return this.PrecoItem * this.QtdItem;
        }
    }
}
