namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {

        public Nokia(string Numero, string Modelo, string IMEI, int Memoria) : base(Numero, Modelo, IMEI, Memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O celular está instalando o aplicativo {nomeApp} pela google playstore, loja presente em todos os dispositivos Androids");
        }
    }
}