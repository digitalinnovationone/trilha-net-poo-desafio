namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;

            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.Write("Para qual número deseja ligar? ");
            var numeroTel = Console.ReadLine();
            Console.WriteLine($"Ligando para o numero {numeroTel}...");
        }

        public void ReceberLigacao()
        {
            var numeroTeste = "99555954";
            Console.WriteLine($"Recebendo ligação de {numeroTeste}...");
        }

        public abstract void InstalarAplicativo();
    }
}