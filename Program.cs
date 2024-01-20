﻿using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Muito obrigada por ter escolhido nosso serviço!" + "\n"
                + "Vamos criar um Smartphone especialmente personalizado para você!" + "\n"
                + "Primeiro... Que marca você gostaria?" + "\n" 
                + "Temos duas opções:" + "\n"
                + "Digite 1 se você gostaria de um Iphone" + "\n"
                + "Digite 2 se você gostaria de um Nokia");

string marcaEscolhida = Console.ReadLine();
string marca = " ";

do {
    if (marcaEscolhida.Equals("1")) {
        marca = "Iphone";
    }
    else if (marcaEscolhida.Equals("2")) {
        marca = "Nokia";
    }
    else {
        Console.WriteLine("Não temos esta opção de marca ainda :(");
    }
}
while(marca.Equals(" "));

Console.WriteLine($"Pressione a tecla 'Enter' para continuar");
Console.ReadLine();

Console.WriteLine($"Me diga qual modelo você gostaria de adquirir");
Console.Write("Modelo:");
string modelo = Console.ReadLine();
Console.WriteLine($"Pressione a tecla 'Enter' para continuar.");
Console.ReadLine();

Random rnd = new();
string imei = rnd.Next().ToString();

Console.WriteLine($"Me diga qual a operadora do seu chip");
Console.Write("Operadora:");
string operadora = Console.ReadLine();
Console.WriteLine($"Pressione a tecla 'Enter' para continuar.");
Console.ReadLine();

Console.WriteLine($"Agora o seu número");
Console.Write("Número:");
string numero = Console.ReadLine();
Console.WriteLine($"Pressione a tecla 'Enter' para continuar.");
Console.ReadLine();

int memoria = 0;

Console.WriteLine($"Quantos GB de memória interna deseja:" +"\n" 
            + "(Digite uma das opções abaixo)" +"\n" 
            + "1 - 3 GB" +"\n" 
            + "2 - 5 GB" +"\n" 
            + "3 - 7 GB");

while (memoria==0) {
    switch (Console.ReadLine()) {
            case "1":
                memoria = 3;
                break;

            case "2":
                memoria = 5;
                break;

            case "3":
                memoria = 7;
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
    }
}
Console.WriteLine($"Pressione a tecla 'Enter' para continuar.");
Console.ReadLine();

Smartphone smartphone = new Iphone();

if (marca.Equals("Iphone"))
{
    smartphone = new Iphone(numero, marca, modelo, imei, memoria, operadora, 10);
}
else if (marca.Equals("Nokia")) {
    smartphone = new Nokia(numero, marca, modelo, imei, memoria, operadora, 10);
}

bool home = true;
while (home)
{
    Console.WriteLine($"Digite o número da ação que deseja realizar: " + "\n"
    + "1 para ver detalhes do seu Smartphone" + "\n"
    + "2 para realizar chamada" + "\n"
    + "3 para receber chamada" + "\n"
    + "4 para instalar app" + "\n"
    + "5 para listar apps instalados" + "\n"
    + "6 para desistalar app" + "\n"
    + "7 para comprar memoria" + "\n"
    + "8 para mostrar histórico da sua carteira" + "\n"
    + "9 para encerrar serviço");

    switch (Console.ReadLine())
    {
        case "1":
            smartphone.Detalhes();
            break;

        case "2":
            smartphone.Ligar();
            break;

        case "3":
            smartphone.ReceberLigacao();
            break;

        case "4":

            bool res = smartphone.InstalarAplicativo();
            if (res.Equals(true)) {
                Console.WriteLine("Caso deseje instalar o app, você pode:" + "\n" 
                    + "(Digite uma das opções abaixo)" + "\n"
                    + "1 - Desinstalar um app já existente em seu Nokia" + "\n"
                    + "2 - Comprar mais memória");
                string num = Console.ReadLine();
                if(num.Equals("1")){
                    smartphone.DesinstalarApp();
                }
                else if (num.Equals("2")) {
                    smartphone.Comprar();
                }
            }
            break;

        case "5":
            smartphone.ListarApps();
            break;

        case "6":
            smartphone.DesinstalarApp();
            break;

        case "7":
            smartphone.Comprar();
            break;

        case "8":
            smartphone.Historico();
            break;
        
        case "9":
            home = false;
            Console.WriteLine("Encerrando serviço...");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione a tecla 'Enter' para continuar");
    Console.ReadLine();
}
