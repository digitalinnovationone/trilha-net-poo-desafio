namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
            // OK
        }
        // TODO: Sobrescrever o método "InstalarAplicativo" OK
        override public void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}