using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaExercicioATVD4.Entidades;
using System.Globalization;

namespace ListaExercicioATVD4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Crie uma classe chamada Fatura para que uma loja de suprimentos de
                informática possa utilizá-la para representar uma fatura de um item
                vendido na loja.
                • Uma Fatura deve incluir quatro partes das informações como variáveis
                de instância – o número (tipo String), a descrição (tipo String), a
                quantidade comprada de um item(tipo int) e o preço por item (tipo
                double).
                • Além disso, forneça um método chamado getValorFatura que calcula
                o valor da fatura (isso é, multiplica a quantidade pelo preço por item) e
                depois retorna o valor como um double.
                • Se o valor não for positivo, ele deve ser configurado como 0. Se o
                preço por item não for positivo ele deve ser configurado como 0.0 
             */

                    // Obs: O tópico 4 nao conseguir entender


            Console.Write("Numero da fatura: ");
            string numero = Console.ReadLine();
            Console.Write("Descricao: ");
            string descricao = Console.ReadLine();
            Console.Write("Quantidade de item: ");
            int qtd = int.Parse(Console.ReadLine());
            Console.Write("Preco por item: ");
            double precoitem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Fatura fatura = new Fatura(numero, descricao, qtd, precoitem);

            LojaSuprimentos lojaSuprimentos = new LojaSuprimentos(fatura);

            double valor = lojaSuprimentos.fatura.ValorFatura();
            Console.WriteLine();
            Console.WriteLine("Fatura do item: R$: "+valor.ToString("F2", CultureInfo.InvariantCulture)+" Reais");


 
        }
    }
}
