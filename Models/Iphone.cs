namespace DesafioPOO.Models
{
    // Herdando de Smartphone
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string cor) 
            : base(numero, modelo, cor)
        {
        }

        // Sobrescrevendo InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} através da App Store no iPhone...");
        }
    }
}
