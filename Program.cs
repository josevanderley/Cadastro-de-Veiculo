using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Veiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CadastroVeiculos cadastro = new CadastroVeiculos();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("************************BEM VINDO AO PROGRAMA CADASTRO DE VEICULOS**************************");
            
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Cadastrar Veículo");
                Console.WriteLine("2 - Listar Veículos");
                Console.WriteLine("3 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Marca: ");
                        string marca = Console.ReadLine();

                        Console.Write("Modelo: ");
                        string modelo = Console.ReadLine();

                        Console.Write("Ano de Fabricação: ");
                        int ano;
                        while (!int.TryParse(Console.ReadLine(), out ano) || ano > DateTime.Now.Year)
                        {
                            Console.WriteLine("Ano de fabricação inválido. Digite novamente:");
                        }

                        Console.Write("Preço: ");
                        decimal preco;
                        while (!decimal.TryParse(Console.ReadLine(), out preco) || preco < 0)
                        {
                            Console.WriteLine("Preço inválido. Digite novamente:");
                        }

                        cadastro.CadastrarVeiculo(marca, modelo, ano, preco);
                        break;

                    case "2":
                        cadastro.ListarVeiculos();
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;

                
                }
            }
        }
    }

}
    
