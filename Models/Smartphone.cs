namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private int memoria;

        public string Numero { get; set; }
        // TODO: feito
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero)
        {
            Numero = numero;
            // TODO: FEito
            Modelo = Modelo;
            IMEI = IMEI;
            Memoria = memoria;
        }

        public Smartphone(string numero, string modelo, string imei, int memoria) : this(numero)
        {
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}