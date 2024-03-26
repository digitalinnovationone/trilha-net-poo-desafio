using DesafioPOO.Models;

class Program
{
  static void Main()
  {

    Console.WriteLine("# IPHONE # \n");
    Iphone iphoneNew = new Iphone("66554433", "Iphone 13", "#99887733", 128);
    iphoneNew.Ligar();
    iphoneNew.ReceberLigacao();
    iphoneNew.InstalarAplicativo("Instagram");
    Console.WriteLine("#############\n");

    Console.WriteLine("# NOKIA # \n");
    Nokia nokiaOld = new Nokia("33445566", "Nokia 1100", "#99887744", 8);
    nokiaOld.Ligar();
    nokiaOld.ReceberLigacao();
    nokiaOld.InstalarAplicativo("Snake");
    Console.WriteLine("#############\n");
  }
}