namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone {
        public Nokia(string numero, string modelo, string iMEI, string memoria) : base(numero, modelo, iMEI, memoria) {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp) {
            Console.WriteLine($"Instalando {nomeApp} no nokia.");
        }
    }
}