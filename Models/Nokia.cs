namespace DesafioPOO.Models
{
   
    public class Nokia : Smartphone
    {
       
        public Nokia(string numero) : base(numero)
        {
            this.Numero = numero;
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Intalando o aplicativo {nomeApp} ...");
        }

       
    }
}