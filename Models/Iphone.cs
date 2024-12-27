namespace DesafioPOO.Models
{
    // A classe Iphone herda da classe Smartphone
    public class Iphone : Smartphone
    {
        // Construtor
        public Iphone(string numero, string modelo, string fabricante, int memoria)
            : base(numero, modelo, fabricante, memoria)
        {
        }

        // Sobrescrevendo o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no iPhone.");
        }
    }
}
