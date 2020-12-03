using System;
using System.Globalization;

namespace Exercicio_individual_Tema_Array_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de produtos: ");
            int n = int.Parse(Console.ReadLine()); //Criando a variável de entrada

            Produto[] vect = new Produto[n]; //Criando vetor com o número da variável de entrada
            for (int i = 0; i < n; i++) //Utilização do comando for para percorrer o vetor
            {
                Console.WriteLine("Produto (" + (i + 1) + ") "); //numero do produto
                Console.Write("Nome: "); //Nome do produto
                string name = Console.ReadLine();
                Console.Write("Preço: "); //Preco do produto
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Name = name, Price = price }; //Entrada dos elementos no vetor pelo usuário
            }
            double sum = 0.0; //Variável soma  

            for (int i = 0; i < n; i++) //Utilização do for para percorrer o vetor
            {
                sum += vect[ i ].Price; //Somatoriados elementos inseridos
            }

            double media = sum / vect.Length;//Calcula a media dos preços

            Console.WriteLine("A média de preço dos produtos inseridos é: R$ " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
