using System;
using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Criar objetos Nokia e Iphone
        Nokia nokia = new Nokia("123456789");
        Iphone iphone = new Iphone("987654321");

        // Realizar ações nos smartphones
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Facebook");

        // Pausa para que você possa ver a saída antes de fechar o programa
        Console.ReadLine();
    }
}
