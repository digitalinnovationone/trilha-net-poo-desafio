namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    { 
        public Nokia(string numero, string modelo, string imei, int memoria)  
        {
            
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp){ 
            
            Console.WriteLine($"Instalando Aplicativo {nomeApp} no Nokia...");
            Console.WriteLine($"{nomeApp} instalado com sucesso!");
        }
    }
}