using System.Collections.Generic;
using System;

namespace Cadastro_de_Veiculos
{
    public class CadastroVeiculos
    {
        private List<Veiculo> veiculos;

        public CadastroVeiculos()
        {
            veiculos = new List<Veiculo>();
        }

        public void CadastrarVeiculo(string marca, string modelo, int ano, decimal preco)
        {
            if (!string.IsNullOrWhiteSpace(marca) && ano >= 2000 && ano <= DateTime.Now.Year)
            {
                Veiculo novoVeiculo = new Veiculo
                {
                    Marca = marca,
                    Modelo = modelo,
                    AnoFabricacao = ano,
                    Preco = preco
                };

                veiculos.Add(novoVeiculo);

                Console.WriteLine("Veículo cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Veículo não pertence a uma marca ou ano de fabricação inválido.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado.");
            }
            else
            {
                Console.WriteLine("Lista de veículos cadastrados:");

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"----------------------------------------");
                    Console.WriteLine($"Marca: {veiculo.Marca}");
                    Console.WriteLine($"Modelo: {veiculo.Modelo}");
                    Console.WriteLine($"Ano: {veiculo.AnoFabricacao}");
                    Console.WriteLine($"Preço: {veiculo.Preco:C}");
                    Console.WriteLine($"----------------------------------------");
                }
            }
        }
    }
}