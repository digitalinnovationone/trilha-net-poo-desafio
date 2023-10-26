namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class iPhone : Smartphone
{
    public iPhone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando o aplicativo {nome} em um iPhone {Modelo}.");
    }
}

}