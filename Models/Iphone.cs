namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoriaInterna) : base(numero, modelo, imei, memoriaInterna)
        {
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string telegram)
        { 
            Console.WriteLine($"Instalando aplicativo {telegram} no Iphone");
        }
    }
}