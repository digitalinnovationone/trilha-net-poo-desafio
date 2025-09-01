namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }
        private bool isLigado = false;
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar(string numero)
        {
            if (!string.IsNullOrWhiteSpace(numero) && numero.Length > 8)
            {
                Console.WriteLine($"Ligando para {numero}...");
                isLigado = true;
            }
            else
            {
                Console.WriteLine("Número inválido. A ligação não pôde ser efetuada.");
                isLigado = false;
            }
        }

        public void ReceberLigacao()
        {
            if (isLigado)
            {
                Console.WriteLine("Recebendo ligação...");
                isLigado = false; // A ligação termina após ser recebida
            }
            else
            {
                Console.WriteLine("Não é possível receber ligação. Nenhuma ligação está em andamento.");
            }
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}