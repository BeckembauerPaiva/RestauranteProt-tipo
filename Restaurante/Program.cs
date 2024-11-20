using System;
using Restaurante.Entities;
using Restaurante.Services;
using Restaurante.Repositories;
using System.Globalization;
using Microsoft.VisualBasic;

namespace MeuRestaurate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var produtoRepository = new ProdutoRepository();
            var ProductService = new ProdutoService(produtoRepository);// evitar perda de dados
            var mesaRepository = new MesaRepository();
            var mesaService = new MesaService(mesaRepository);
            var garcomRepository = new GarcomRepository();
            var garcomService = new GarcomService(garcomRepository);
            var pedidoRepository = new PedidoRepository();
            var pedidoService = new PedidoService(pedidoRepository);




            int N = 0;
            int Resposta;
            do
            {
                Console.WriteLine("MESA digite: 1");
                Console.WriteLine("GARÇOM digite: 2");
                Console.WriteLine("PRODUTO digite: 3");
                Console.WriteLine("PEDIDO digite: 4");
                Resposta = int.Parse(Console.ReadLine());
                switch (Resposta)
                {
                    case 1:

                        Console.WriteLine("Adicionar: 1 remover: 2");
                        N = int.Parse(Console.ReadLine());
                        if (N == 1)
                        {
                            Console.Write("Mesa: ");
                            int numero = int.Parse(Console.ReadLine());
                            var novaMesa = new Mesa(numero);  // ´construtor com 1 parametro sem guid(id)
                            mesaService.Adicionar(novaMesa);
                        }
                        else if (N == 2)
                        {
                            Console.Write("Mesa: ");
                            int numero = int.Parse(Console.ReadLine());
                            var novaMesa = new Mesa(numero);  // ´construtor com 1 parametro sem guid(id)
                            mesaService.Remover(novaMesa);
                        }
                        else { Console.WriteLine("Opção invalida:"); }
                        break;
                    case 2:
                        Console.WriteLine("Adicionar: 1 remover: 2");
                        N = int.Parse(Console.ReadLine());
                        if (N == 1)
                        {
                            Console.Write("Nome: ");
                            string Nome = Console.ReadLine();
                            var novoGarcom = new Garcom(Nome);
                            garcomService.Adicionar(novoGarcom);
                        }
                        else if (N == 2)
                        {
                            Console.Write("Nome: ");
                            string Nome = Console.ReadLine();
                            var novoGarcom = new Garcom(Nome);
                            garcomService.Remover(novoGarcom);
                        }
                        else { Console.WriteLine("Opção invalida:"); }

                        break;
                    case 3:
                        Console.WriteLine("Adicionar: 1 remover: 2");
                        N = int.Parse(Console.ReadLine());
                        if (N == 1)
                        {
                            Console.Write("Nome:");
                            string Nome = Console.ReadLine();
                            Console.Write("Preço:");
                            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("codigo de barras:");
                            string codigoDeBarras = Console.ReadLine();
                            var novoProduto = new Produto(Nome, Preco, codigoDeBarras);

                            ProductService.Adicionar(novoProduto);
                        }
                        else if (N == 2)
                        {
                            Console.WriteLine("codigo de barras:");
                            var codigoDeBarras = Console.ReadLine();
                            var produto = new Produto() { CodigoDeBarras = codigoDeBarras };
                            ProductService.Remover(produto);
                        }
                        else { Console.WriteLine("Opção invalida:"); }
                        break;
                    case 4:
                        Console.WriteLine("Adicionar: 1 remover: 2");
                        N = int.Parse(Console.ReadLine());
                        if ((N == 1))
                        {
                            Console.WriteLine("Abrindo novo pedido:");
                            Console.Write("Mesa: ");
                            int numero = int.Parse(Console.ReadLine());
                            var mesa = new Mesa(numero);
                            Console.WriteLine("Lista de consumo:");
                            List<Produto>listConsumo = new List<Produto>();
                            var novoPedido = new Pedido(mesa,listConsumo);
                            pedidoService.Adicionar(novoPedido);
                        }
                        else if (N == 2)
                        {
                            Console.WriteLine("Fechando pedido:");
                            Console.Write("Mesa: ");
                            int numero = int.Parse(Console.ReadLine());
                            var mesa = new Mesa(numero);
                            var fecharPedido = new Pedido(mesa);
                            pedidoService.Remover((fecharPedido));

                        }
                        else { Console.WriteLine("Opção invalida:"); }
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;

                }






                Console.WriteLine("Para fechar o progama digite: 0");
                N = int.Parse(Console.ReadLine());
                if (N == 0)
                {
                    Console.WriteLine("Fechando .");
                    Console.Clear();
                    Console.WriteLine("Fechando ..");
                    Console.Clear();
                    Console.WriteLine("Fechando ...");
                }
                else { N = 1; }
            } while (N == 1);

        }
    }
}