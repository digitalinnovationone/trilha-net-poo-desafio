using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    {
        Nokia nokia = new Nokia("123456789", "Nokia 3310", "1234", 16);
        iPhone iphone = new iPhone("987654321", "iPhone 12 Pro", "5678", 64);

        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");
    }
}