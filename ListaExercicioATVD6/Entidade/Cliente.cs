using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioATVD6.Entidade
{
    public class Cliente
    {
        public string Nome { get; set; }

        public int Rg { get; set; }

        public string Cpf { get; set; }

        public string Telefone { get; set; }

        public int NumeroConta { get; set; }


        public override string ToString()
        {
            return "Nome do cliente: "
                + this.Nome
                + "\nRg do cliente: "
                + this.Rg
                + "\ncpf do cliente: "
                + this.Cpf
                + "\nTelefone do cliente: "
                + this.Telefone
                + "\ne o numero da conta do cliente "
                + this.Nome
                + " é: "
                + this.NumeroConta
                +"\n";
        }
    }
}
