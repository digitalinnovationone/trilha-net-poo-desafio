namespace DesafioPOO.Models
{
    public abstract class Smartphone : Carteira
    {
        public string Numero { get; set; }
        // DONE: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Marca { get; set; }
        protected string Modelo { get; set; }
        protected string Imei { get; set; }
        protected int Memoria { get; set; }
        protected int MemoriaRam { get; set; }
        protected string Operadora { get; set; }
        protected List<string> apps = new();
        protected List<string> chamadas = new();

        public Smartphone(int credito=0) : base(credito)
        {
        }
        public Smartphone(
            string numero, 
            string marca, 
            string modelo, 
            string imei, 
            int memoria, 
            string operadora,
            int credito
        ) : base (credito)
        {
            Numero = numero;
            // DONE: Passar os parâmetros do construtor para as propriedades
            Marca = marca;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            Operadora = operadora;
        }

        public void Detalhes() {
            Console.WriteLine("Informações do celular: " + "\n" 
            + $"Marca: {Marca}, " + "\n"
            + $"Operadora: {Operadora}" + "\n"
            + $"Número de telefone: {Numero}, " + "\n" 
            + $"Modelo: {Modelo}, " + "\n" 
            + $"Memória interna: {Memoria}"+ "\n"
            + $"Carteira: {Credito}");
        }

        public void Ligar()
        {
            DateTime data = DateTime.Now; 
            chamadas.Add($"Realizou uma ligação em {data}");
            Console.WriteLine($"Celular {Marca} está fazendo uma ligação...");
        }

        public void ReceberLigacao()
        {
            DateTime data = DateTime.Now; 
            chamadas.Add($"Recebeu uma ligação em {data}");
            Console.WriteLine($"Celular {Marca} está recebendo uma ligação...");
        }

        public void HistoricoChamadas() {
            
            if (chamadas.Any()) {
                foreach(string chamada in chamadas) {
                    Console.WriteLine(chamada);
                }                
            } else {
                Console.WriteLine("Você ainda não realizou nenhuma chamada com seu smartphone");
            }
        
        }

        public abstract bool InstalarAplicativo();

        public abstract void Comprar();

        public void DesinstalarApp(){
            Console.WriteLine("Informa o nome do app que você deseja desinstalar");
            string nomeApp = Console.ReadLine();
            if (apps.Contains(nomeApp)) {
                apps.Remove(nomeApp);
                ++Memoria;
                Console.WriteLine($"Aplicativo {nomeApp} removido com sucesso!");
            }
            else {
                Console.WriteLine($"O aplicativo {nomeApp} não está instalado no celular {Marca}");
            }

        }

        public void ListarApps() {
            if (apps.Any()) {
                Console.WriteLine($"Aplicativos instalados no {Marca} - {Modelo}:");

                foreach (string item in apps)
                {
                    Console.WriteLine($"- \"{item}\" -");
                }
            }
            else {
                Console.WriteLine($"Não tem aplicativo instalado no {Marca} - {Modelo}");
            }
        }
    }
}