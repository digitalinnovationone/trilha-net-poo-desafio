using DesafioPOO.Models;

bool menu = true;
Console.WriteLine("Qual Smartphone você deseja acessar?\n Nokia ou Iphone");
string escolha = Console.ReadLine();
escolha = escolha.ToUpper();
if (escolha == "NOKIA")
{
    while (menu)
    {
        Console.Clear();
        Console.WriteLine("Bem vindo ao seu Nokia!");
        Smartphone nokia = new Nokia("40028922", "Nokia 3200", "123456789012345", 64);
        Console.WriteLine("O que deseja fazer?\n 1 - Ligar\n 2 - Receber Ligação\n 3 - Instalar Aplicativo\n 4 - Sair");
        string opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                nokia.Ligar();
                break;
            case "2":
                nokia.ReceberLigacao();
                break;
            case "3":
                nokia.InstalarAplicativo("Nokia");
                break;
            case "4":
                menu = false;
                Console.WriteLine("Saindo do Nokia...");
                break;
            default:
                Console.WriteLine("Opção inválida, tente novamente.");
                break;
        }
    }

} else if (escolha == "IPHONE")
{
    while (menu)
    {
        Console.Clear();
        Console.WriteLine("Bem vindo ao seu Iphone!");
        Smartphone iphone = new Iphone("40028922", "Iphone 13", "123456789012345", 128);
        Console.WriteLine("O que deseja fazer?\n 1 - Ligar\n 2 - Receber Ligação\n 3 - Instalar Aplicativo\n 4 - Sair");
        string opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                iphone.Ligar();
                break;
            case "2":
                iphone.ReceberLigacao();
                break;
            case "3":
                iphone.InstalarAplicativo("Iphone");
                break;
            case "4":
                menu = false;
                Console.WriteLine("Saindo do Iphone...");
                break;
            default:
                Console.WriteLine("Opção inválida, tente novamente.");
                break;
        }
    }
}
else
{
    Console.WriteLine("Opção inválida, tente novamente.");
}


// TODO: Realizar os testes com as classes Nokia e Iphone