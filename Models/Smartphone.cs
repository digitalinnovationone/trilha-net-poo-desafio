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
        protected List<string> apps = new();
        protected List<string> chamadas = new();

        public Smartphone(decimal credito=0) : base(credito)
        {
        }
        public Smartphone(
            string numero, 
            string marca, 
            string modelo, 
            string imei, 
            int memoria,
            decimal credito
        ) : base (credito)
        {
            Numero = numero;
            // DONE: Passar os parâmetros do construtor para as propriedades
            Marca = marca;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Detalhes() {
            Console.WriteLine("Informações do celular: " + "\n" 
            + $" - Marca: {Marca}, " + "\n"
            + $" - Número de telefone: {Numero} " + "\n" 
            + $" - Modelo: {Modelo} " + "\n" 
            + $" - Imei: {Imei}, " + "\n" 
            + $" - Memória interna: {Memoria}"+ "\n"
            + $" - Carteira: ${Credito.ToString("F")}");
        }

        public void Ligar()
        {
            Console.WriteLine($"{Marca} está iniciando...");
        }

        public void FazerLigacao()
        {
            DateTime data = DateTime.Now; 
            Random rnd = new();
            string telefone = rnd.Next(90000000, 999999999).ToString();
            chamadas.Add($"Realizou uma ligação para {telefone} em {data}");
            Console.WriteLine($"Ligando para {telefone}...");
        }

        public void ReceberLigacao()
        {
            DateTime data = DateTime.Now; 
            Random rnd = new();
            string telefone = rnd.Next(90000000, 999999999).ToString();
            chamadas.Add($"Recebeu uma ligação de {telefone} em {data}");
            Console.WriteLine($"Recebendo uma ligação de {telefone}...");
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

        public bool ListarApps() {
            if (apps.Any()) {
                Console.WriteLine($"Aplicativos instalados no {Marca} - {Modelo}:");

                foreach (string item in apps)
                {
                    Console.WriteLine($"- \"{item}\" -");
                }
                return true;
            }
            else {
                Console.WriteLine($"Não tem aplicativo instalado no {Marca} - {Modelo}");
                return false;
            }
        }
        public void DesinstalarApp(){
            bool cheque = ListarApps();
            if (cheque)
            {
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
        }
    }
}