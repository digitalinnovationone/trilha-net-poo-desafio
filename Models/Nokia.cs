namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia: Smartphone
    {
        public Nokia (string numero, string modelo, string imei, string memoria) : base (numero, modelo, imei, memoria) {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O app {nomeApp} será instalado nesse Nokia");
        }

        public override void InstalarAplicativo(string nomeApp, string numero, string modelo, string imei, string memoria)
        {
            Console.WriteLine($"O app {nomeApp} será instalado no Nokia de número {numero}, modelo {modelo}, IMEI {imei} e memória {memoria} GB");
        }
    }
}