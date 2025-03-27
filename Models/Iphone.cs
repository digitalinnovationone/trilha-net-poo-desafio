namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo()
        {
            Console.Write("Qual aplicativo deseja instalar?");
            var nomeApp = Console.ReadLine();
            Console.WriteLine($"Instalando {nomeApp} no iphone...");
        }
    }
}