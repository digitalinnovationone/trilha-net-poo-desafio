namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        

        public Nokia(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {
            
        }


        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
      
        Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
    
}