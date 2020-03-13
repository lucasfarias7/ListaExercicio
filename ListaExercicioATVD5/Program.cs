using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaExercicioATVD5.Entidade;

namespace ListaExercicioATVD5
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             *  implemente uma classe chamada Aluno. Essa
                classe deve possuir 4 atributos: nome, cpf, matricula e e-mail.
                Faça um teste criando objetos da classe Aluno. Altere e exiba no
                Console os valores armazenados nos atributos desse objeto. Crie
                uma nova classe chamada TestaAluno trazendo como retorno os
                atributos de 2 alunos diferentes.
             * */

            List<Aluno> alunos = new List<Aluno>();

            for(int i=1; i<=2; i++)
            {
                Console.WriteLine("Informe os dados do aluno #"+i);
                Console.WriteLine();
                Console.Write("nome: ");
                string nome = Console.ReadLine();
                Console.Write("cpf: ");
                string cpf = Console.ReadLine();
                Console.Write("Matricula: ");
                int matricula = int.Parse(Console.ReadLine());
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("\n");
                Aluno aluno = new Aluno(nome, cpf, matricula, email);
                alunos.Add(aluno);
            }
            Console.WriteLine();
            foreach(Aluno aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.ReadKey();
            
            
        }
    }
}
