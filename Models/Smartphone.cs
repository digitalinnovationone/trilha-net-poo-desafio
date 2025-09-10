namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        
        // Modificação mdlpontual: incrementar métodos de ligação para mostrar números de ligação
        public void Ligar(string numeroChamando)
        {
            Console.WriteLine($"Ligando para {numeroChamando}");
        }

        public void ReceberLigacao(string numeroLigando)
        {
            Console.WriteLine($"Recebendo ligação de {numeroLigando}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}