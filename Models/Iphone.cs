namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) 
                    : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando um aplicativo no Iphone");
            Thread.Sleep(1000);
            Console.WriteLine($"...");
            Thread.Sleep(1000);
            Console.WriteLine($"# {nomeApp} - instalado com sucesso");        }
    }
}