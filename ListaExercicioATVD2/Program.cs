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

            /*
             
                Crie uma classe chamada Pessoa. A classe terá os atributos
                “nome”, “sexo” e “idade”. Deve haver o método
                “maiorDeIdade()”, que retorna true se a pessoa for maior de idade,
                ou false caso contrário. Considere a maioridade aos 18 anos. Na
                sequência, escreva uma classe que instancie um objeto tipo Pessoa e
                verifique se o mesmo é ou não maior de idade, imprimindo o
                resultado via console.

             * */

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
