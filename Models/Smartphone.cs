namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        // CHECK
        private string Model { get; set; }
        private string IMEI { get; set; }
        private int Storage { get; set; }

        public Smartphone(string cNumber, string cModel, string cIMEI, int cStorage)
        {
            Number = cNumber;
            // TODO: Passar os parâmetros do construtor para as propriedades
            // CHECK
            Model = cModel;
            IMEI = cIMEI;
            Storage = cStorage;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando desde " + Number + "...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação em " + Number + "...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}