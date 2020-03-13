using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaExercicioATVD6.Entidade;

namespace ListaExercicioATVD6
{
    class Program
    {
        static void Main(string[] args)
        {
            //numeros randomicos para gerar o numero da conta do cliente
            Random r = new Random();

            List<Cliente> clientes = new List<Cliente>();

            Cliente lucas = new Cliente()
            {
                Nome = "lucas Farias",
                Rg = 123456,
                Cpf = "123456789",
                Telefone = "83981188456",
                NumeroConta = Convert.ToInt32(r.Next())
                
            };
            
            clientes.Add(lucas);

            Cliente cliente2 = new Cliente()
            {
                Nome = "Teste 2",
                Rg = 1234,
                Cpf = "7635454545",
                Telefone = "88888888",
                NumeroConta = Convert.ToInt32(r.Next())
            };
            
            clientes.Add(cliente2);

            Cliente cliente3 = new Cliente()
            {
                Nome = "cliente 3",
                Rg = 1234989,
                Cpf = "7868697",
                Telefone = "88888888",
                NumeroConta = Convert.ToInt32(r.Next())
            };

            clientes.Add(cliente3);


            foreach(Cliente cliente in clientes)
            {
                Console.WriteLine(cliente);
            }


        }
    }
}
