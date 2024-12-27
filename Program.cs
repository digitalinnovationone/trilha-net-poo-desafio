using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Testando a classe Nokia
        Smartphone meuNokia = new Nokia("98765", "Nokia 6", "Nokia", 64);
        Console.WriteLine("Teste com o Nokia:");
        meuNokia.Ligar();
        meuNokia.ReceberLigacao();
        meuNokia.InstalarAplicativo("Facebook");

        Console.WriteLine("\n");

        // Testando a classe Iphone
        Smartphone meuIphone = new Iphone("112233", "iPhone 13", "Apple", 128);
        Console.WriteLine("Teste com o iPhone:");
        meuIphone.Ligar();
        meuIphone.ReceberLigacao();
        meuIphone.InstalarAplicativo("Instagram");
    }
}
