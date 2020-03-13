using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaExercicioATVD1.Entidades;

namespace ListaExercicioATVD1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Crie uma classe Principal e uma classe de
                teste que contenham métodos para as
                seguintes rotinas:

                A. Imprima todos os números pares entre 1 e 100;
                B. Imprima todos os múltiplos de 3 entre 1 e 100;

             * */
            Atvd1 at = new Atvd1();

            Console.WriteLine("Numeros pares\n");
            at.metodoPar();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Numeros multiplos de 3\n");
            at.metodoMultiplo();

            Console.ReadKey();
        }
    }
}
