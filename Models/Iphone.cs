namespace DesafioPOO.Models
{
    public class Iphone : Celular
    {

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            AplicativosInstalados.Add(nomeApp);
            Console.WriteLine($"Instalando aplicativo no Iphone...");
            Thread.Sleep(2000);
            Console.WriteLine($"Aplicativo {nomeApp} instalado!");
        }
    }
}