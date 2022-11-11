namespace DesafioPOO.Models
{
    public class Nokia : Celular
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            AplicativosInstalados.Add(nomeApp);
            Console.WriteLine($"Instalando aplicativo no Nokia...");
            Thread.Sleep(2000);
            Console.WriteLine($"Aplicativo {nomeApp} instalado!");
        }

    }
}