using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaExercicioATVD2.Atvd2;

namespace ListaExercicioATVD2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Sexo: ");
            string sexo = Console.ReadLine();
            Console.WriteLine();

            Pessoa p1 = new Pessoa(nome, sexo, idade);


            p1.MaiorIdade();




        }
    }
}
