namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero){
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
           System.Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso no seu Iphone.\n");
        }

    }
}