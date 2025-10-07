using DesafioPOO.Models;

class Program
{
  static void Main(string[] args)
  {
    Nokia nokia = new Nokia("123456789", "Nokia Tijolão", "9876543210", 32);
    nokia.Ligar();
    nokia.ReceberLigacao();
    nokia.InstalarAplicativo("Windows");

    Console.WriteLine();

    Iphone iphone = new Iphone("987654321", "iPhone 14", "1234567890", 128);
    iphone.Ligar();
    iphone.ReceberLigacao();
    iphone.InstalarAplicativo("Apple");
  }
  }