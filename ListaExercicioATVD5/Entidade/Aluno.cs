using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioATVD5.Entidade
{
    public class Aluno
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public int Matricula { get; set; }

        public string Email { get; set; }


        public Aluno()
        {
        }

        public Aluno(string nome, string cpf, int matricula, string email)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Matricula = matricula;
            this.Email = email;
        }


        public override string ToString()
        {
            return "Aluno: "
                + this.Nome
                + ", cpf: "
                + this.Cpf
                + ", Matricula: "
                + this.Matricula
                + ", Email: "+this.Email;
        }
    }
}
