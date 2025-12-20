namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        private string _modelo;
        private string _imei;
        private int _memoria;
        public string Numero { get; set; }
        public string Modelo
        {
            get => _modelo; set => _modelo = value;
        }
        public string Imei
        {
            get => _imei;
            set => _imei = value;
        }
        public int Memoria
        {
            get => _memoria; set => _memoria = value;
        }

        public static void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public static void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}