namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _numero;
        private string _modelo;
        private string _imei;
        private int _memoria;

        public string Numero 
        { 
            get => _numero;
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Número não pode ser vazio ou nulo");
                _numero = value;
            }
        }

        public string Modelo 
        { 
            get => _modelo;
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Modelo não pode ser vazio ou nulo");
                _modelo = value;
            }
        }

        public string IMEI 
        { 
            get => _imei;
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("IMEI não pode ser vazio ou nulo");
                if (value.Length != 15) // IMEI padrão tem 15 dígitos
                    throw new ArgumentException("IMEI deve conter 15 dígitos");
                _imei = value;
            }
        }

        public int Memoria 
        { 
            get => _memoria;
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("Memória deve ser maior que zero");
                _memoria = value;
            }
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
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