using System;
using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Testando a classe Nokia
        Nokia nokia = new Nokia("123456789", "Nokia ModeloX", "IMEI123", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Testando a classe Iphone
        Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI456", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
