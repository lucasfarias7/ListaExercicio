using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioATVD1.Entidades
{
    public class Atvd1
    {
        // Crie uma classe com as seguintes rotinas e teste elas em uma principal

        // A - Imprima todos os numeros pares entre 1 e 100;

        public void metodoPar()
        {
            for(int ac=1; ac<=100; ac++)
            {
                if(ac % 2 == 0)
                {
                    Console.WriteLine(ac);
                }
            }
        }

        // B - Imprima todos os multiplos de 3 entre 1 e 100;

        public void metodoMultiplo()
        {
            for (int ac = 1; ac <= 100; ac++)
            {
                if (ac % 3 == 0)
                {
                    Console.WriteLine(ac);
                }
            }
        }
    }
}
