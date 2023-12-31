namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        
        public void LigarAparelho()
        {
            Console.WriteLine("Ligando o aparelho...");
        }

        public void DesligarAparelho()
        {
            Console.WriteLine("Desligando o aparelho...");
        }

        public void Ligar(string nome)
        {
            Console.WriteLine($"Ligando para {nome}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}