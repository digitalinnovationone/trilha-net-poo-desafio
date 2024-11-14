namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" - CHECK
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo" - CHECK
        public Iphone(string Number, string Model, string IMEI, int Storage) : base(Number, Model, IMEI, Storage)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"instalando aplicativo '{nomeApp}' no teu Iphone");
        }
    }
}