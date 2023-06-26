using DesafioPOO.Models;



public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Instalando Aplicativo no celular Nokia ...");
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Smartphone Nokia");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("================");
        Nokia nokia = new Nokia("12345", "Modelo 1", "1111111111", 9832950);
        nokia.Ligar();
        nokia.InstalarAplicativo("Whatsapp");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine("Smartphone IPhone");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("==================");

        Iphone iphone = new Iphone("12345Iphone", "Modelo 2", "1@2343%", 982940);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Photoshop");
    }
}