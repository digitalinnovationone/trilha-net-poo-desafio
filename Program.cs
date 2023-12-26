using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
            Iphone iphone = new Iphone("987654321", "iPhone 11", "987654321", 64);

            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Snake");

            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
            iphone.Modelo = "iPhone 12";
        }
    }
}