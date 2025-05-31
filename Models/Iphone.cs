namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

       
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Verificando a instalação do {nomeApp} no Iphone");
        }
    }
}