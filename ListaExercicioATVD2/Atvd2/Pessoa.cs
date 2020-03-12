using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioATVD2.Atvd2
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public string Sexo { get; set; }

        public int Idade { get; set; }


        public Pessoa()
        {
        }

        public Pessoa(string nome, string sexo, int idade)
        {
            this.Nome = nome;
            this.Sexo = sexo;
            this.Idade = idade;
        }



        public bool MaiorIdade()
        {
            bool teste = false;

            if(this.Idade < 18)
            {
                Console.WriteLine(this.Nome+" é menor de idade");
                teste = false;
            }
            else
            {
                Console.WriteLine(this.Nome + " é maior de idade");
                teste = true;
            }

            return teste;
        }
    }
}
