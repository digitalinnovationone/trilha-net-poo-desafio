using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Iphone iphone = new Iphone("123456789", "iPhone 13", "IMEI123456789", 128, "iOS 15");
            Nokia nokia = new Nokia("987654321", "Nokia 3310", "IMEI987654321", 32, "Symbian");

            bool executando = true;

            while (executando)
            {
                Console.Clear();
                Console.WriteLine("=== MENU INTERATIVO ===");
                Console.WriteLine("1 - Usar iPhone");
                Console.WriteLine("2 - Usar Nokia");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        MenuCelular(iphone);
                        break;
                    case "2":
                        MenuCelular(nokia);
                        break;
                    case "0":
                        executando = false;
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void MenuCelular(Smartphone celular)
        {
            bool voltar = false;

            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine($"=== MENU ===");
                Console.WriteLine("1 - Ligar");
                Console.WriteLine("2 - Receber Ligação");
                Console.WriteLine("3 - Instalar Aplicativo");
                Console.WriteLine("4 - Mostrar Informações");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        celular.Ligar();
                        break;
                    case "2":
                        celular.ReceberLigacao();
                        break;
                    case "3":
                        Console.Write("Digite o nome do aplicativo: ");
                        string app = Console.ReadLine();
                        celular.InstalarAplicativo(app);
                        break;
                    case "4":
                        celular.MostrarInfo();
                        break;
                    case "0":
                        voltar = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                if (!voltar)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
