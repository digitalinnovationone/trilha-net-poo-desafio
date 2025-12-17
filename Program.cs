using DesafioPOO.Models;
using System;

class Program
{
    static void Main()
    {
        Smartphone nokia = new Nokia("11999999999", "Nokia G20", "123456789", 64);
        Smartphone iphone = new Iphone("11888888888", "iPhone 14", "987654321", 128);

        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
