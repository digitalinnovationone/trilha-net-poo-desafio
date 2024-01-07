using DesafioPOO.Models;

class Program
{
    static void Main()
    {
         Console.WriteLine("\n");
        Console.WriteLine("Smartphone modelo: Nokia");
        Smartphone nokia = new Nokia("81 98161-0209","Nokia Tijolão", "000000", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n");
        Console.WriteLine("*************************************************************************************************************");
        Console.WriteLine("\n");

        Console.WriteLine("Smartphone modelo: Iphone");
        Smartphone iphone = new Iphone("81 99248-0209", "Iphone 50", "111111", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
        Console.WriteLine("\n");
    }
}
