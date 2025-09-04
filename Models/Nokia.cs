namespace DesafioPOO.Models
// Classe Nokia herdando de Smartphone
    public class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
    {
    }

    // Implementação do método abstrato
    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando o aplicativo '{nome}' no Nokia.");
    }
}