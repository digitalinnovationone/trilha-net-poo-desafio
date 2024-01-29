namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoriaInterna) : base(numero, modelo, imei, memoriaInterna)
        {
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string whatsapp)
        { 
            Console.WriteLine($"Instalando aplicativo {whatsapp} no Nokia");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}