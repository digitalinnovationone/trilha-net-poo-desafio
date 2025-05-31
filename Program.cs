using DesafioPOO.Models;

class Program
{
    static void Main(String[] args)
    {
        Smartphone Iphone = new Iphone("1626516515165", "Iphone 16", "5555555555", 64);
        Iphone.Ligar();
        Iphone.ReceberLigacao();
        Iphone.InstalarAplicativo("Telegram");

        Smartphone Nokia = new Nokia("156165148", "Nokia X", "8785685465", 128);
        Nokia.Ligar();
        Nokia.ReceberLigacao();
        Nokia.InstalarAplicativo("Telegram");
    }
}

