namespace DesafioPOO.Models
{
   
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Console.WriteLine($"iPhone {modelo} inicializado com IMEI {imei} e memória {memoria}GB.");
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no iPhone");
        }
        
    }
}