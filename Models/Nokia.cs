namespace DesafioPOO.Models
{
    // Herdando de Smartphone
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia chamando o construtor da base
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrevendo o método abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }
    }
}
