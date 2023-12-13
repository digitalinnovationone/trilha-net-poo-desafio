namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : 
        base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o {nomeApp} - Acesse a Apple Store para baixar mais aplicativos no seu iPhone");
        }
    }
}