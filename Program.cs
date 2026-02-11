using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("111111", "Tijolão 3310", "123456789", 64);
        Smartphone iphone = new Iphone("222222", "iPhone 15", "987654321", 256);

        Console.WriteLine("=== Nokia ===");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        Console.WriteLine("=== iPhone ===");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

    }
}