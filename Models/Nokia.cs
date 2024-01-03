using System.Runtime.CompilerServices;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // Implementado
    
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base (numero,  modelo, imei, memoria)
        {

        }
        
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Implementado 
                
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{nomeApp} instalado com sucesso no seu Nokia!");
        }

    
    }
}
