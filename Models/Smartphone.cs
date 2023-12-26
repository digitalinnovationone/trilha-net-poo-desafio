namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private String Modelo{get;}
        private String Imei{get;}
        private int Memoria{get;}
        public Smartphone(string numero, string imei, string modelo, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Imei = imei;
            Modelo = modelo;
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