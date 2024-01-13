namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp) {
            Console.WriteLine($"Instalando aplicativo {nomeApp} da Apple Store em seu {modelo}");
        };
    }
}