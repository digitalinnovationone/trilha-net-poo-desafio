namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)  
        {
            
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp){ 
            
            Console.WriteLine($"Instalando Aplicativo {nomeApp} no Iphone...");
            Console.WriteLine($"{nomeApp} instalado com sucesso!");
        }
    }
}