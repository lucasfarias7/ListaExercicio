using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioATVD7.Entidade
{
    public class Funcionarios
    {
        public string Nome { get; set; }

        public int Matricula { get; set; }

        public string Cpf { get; set; }

        public double Salario { get; set; }

        public double ValeRefeicao { get; set; }


        public double SalarioBruto()
        {
            return this.Salario + this.ValeRefeicao;
        }

        
    }
}
