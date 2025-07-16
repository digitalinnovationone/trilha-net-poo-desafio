namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria, string cor, int ano)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            Cor = cor;
            Ano = ano;
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