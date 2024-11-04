namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string numero
        {
            get; set;
        }

        private string _modelo
        {
            get; set;
        }

        private string _IMEI
        {
            get; set;
        }

        private int _memoria
        {
            get; set;
        }

        public Smartphone(string Numero, string Modelo, string IMEI, int Memoria)
        {
            numero = Numero;
            _modelo = Modelo;
            _IMEI = IMEI;
            _memoria = Memoria;
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