namespace DesafioPOO.Models
{
    public class Motorola : Smartphone
    {
         public Motorola(string numero) : base(numero){
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"{nomeApp} instalado com sucesso no seu MotoG.\n");
        }
    }
}