namespace DesafioPOO.Models
{
    
    public  class Iphone: Smartphone
    {
        public Iphone(string numero) : base(numero)
        {
            this.Numero = numero;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Intalando o aplicativo {nomeApp} ...");
        }

    }
}