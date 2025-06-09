using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

public class Iphone : Smartphone
{
    public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"instalação do {nomeApp} no Iphone feita com sucesso!");
    }
}

public class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Verificando a instalação do {nomeApp} no Nokia");
    }
}
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