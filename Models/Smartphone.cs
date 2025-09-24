namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public int Numero { get; set; }
        protected string Modelo { get; set; }
		protected string Cor { get; set; }
		protected int Tamanho { get; set; }

        public Smartphone(int numero, string modelo, string cor, int tamanho)
        {
            Numero = numero;
            Modelo = modelo;
            Cor = cor;
            Tamanho = tamanho;
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
        
        public void DadosSmartphone()
		{
			Console.WriteLine($"Número: {Numero}, Modelo: {Modelo}, Tamanho: {tamanho}, Cor: {cor}");
		}
    }
}