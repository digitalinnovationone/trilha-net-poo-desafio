namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
       public  string Numero;
        public string Modelo;
        public string modelo;
        public string Imei;
        public int Memoria;

       

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o App {nomeApp} no {Modelo}");
        }
    }
}