using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaExercicioATVD7.Entidade;

namespace ListaExercicioATVD7
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionarios func1 = new Funcionarios()
            {
                Nome = "Lucas Farias",
                Cpf = "10872637433",
                Matricula = 201700750,
                Salario = 2000.00,
                ValeRefeicao = 100.00
            };

            func1.SalarioBruto();
            
        }
    }
}
