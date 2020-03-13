using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaExercicioATVD3.Atvd3;
using System.Globalization;

namespace ListaExercicioATVD3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Uma locadora possui dois tipos de veículos: utilitário e de passeio. O
            veículo, independente do tipo, deve ser identificada pelo modelo,
            marca, ano, preço de locação e quantidade de dias de locação. Para
            calcular o preço da locação e construir as entidades apresentadas,
            utilize como regra as definições a seguir:
            - Veículos utilitários possuem um valor fixo acrescentado de R$ 40,00;
            – Veículos de passeio possuem um valor fixo com desconto de R$ 20,00;

             */


            Console.WriteLine("Dados do veiculo utilitario: ");
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Ano: ");
            DateTime ano = DateTime.Parse(Console.ReadLine());
            Console.Write("Preco locação: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade dias: ");
            int qtd = int.Parse(Console.ReadLine());
            Console.Write("Valor locacao carro utilitario: ");
            double valorutil = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Utilitario CarroUtil = new Utilitario(modelo, marca, ano, preco, qtd, valorutil);

            double total = CarroUtil.PrecoLocacao();
            Console.WriteLine("O valor da locacao do carro utilitario é: R$: "+total.ToString("F2",CultureInfo.InvariantCulture)+" Reais");
            Console.WriteLine();

            Console.WriteLine("Dados do carro de passeio: ");
            Console.Write("Modelo: ");
            modelo = Console.ReadLine();
            Console.Write("Marca: ");
            marca = Console.ReadLine();
            Console.Write("Ano: ");
            ano = DateTime.Parse(Console.ReadLine());
            Console.Write("Preco locação: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade dias: ");
            qtd = int.Parse(Console.ReadLine());
            Console.Write("Valor locacao carro passeio: ");
            valorutil = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Passeio carroPasseio = new Passeio(modelo, marca, ano, preco, qtd, valorutil);

            double totalPasseio = carroPasseio.PrecoLocacao();

            Console.WriteLine("O valor da locacao do carro de passeio é: R$: " + totalPasseio.ToString("F2", CultureInfo.InvariantCulture) + " Reais");
            Console.WriteLine();


        }
    }
}
