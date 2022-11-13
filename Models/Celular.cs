namespace DesafioPOO.Models
{
    public abstract class Celular
    {
        public string Marca { get; set; }
        public string Numero { get; set; }
        public string Modelo { get; private set; }
        public string Imei { get; private set; }
        public int Memoria { get; private set; }
        public List<string> AplicativosInstalados { get; set; }

        protected Celular(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            AplicativosInstalados = new List<string>();
        }

        public void Ligar(string numero)
        {
            var divisoes = new[] { 2, 1, 8 };
            var partes = new string[divisoes.Length];
            string[] digitosSeparados = { numero };

            foreach (string line in digitosSeparados)
            {
                int posicaoInicial = 0;
                for (int i = 0; i < divisoes.Length; i++)
                {
                    partes[i] = line.Substring(posicaoInicial, divisoes[i]);
                    posicaoInicial += divisoes[i];
                }
            }

            Console.WriteLine($"Ligando para +55 ({partes[0]}) {partes[1]} {partes[2]}");
        }

        public void ReceberLigacao()
        {
            Random rnd = new Random();
            long dddAleatorio = rnd.Next(11, 99);
            long numeroAleatorio = rnd.Next(60000000, 99999999);
            Console.WriteLine($"Recebendo ligação de +55 ({dddAleatorio}) 9 {numeroAleatorio}");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public void DesinstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Desinstalando aplicativo no {this.GetType().Name}");
            AplicativosInstalados.Remove(AplicativosInstalados.Find(listaNome => listaNome == nomeApp));
            Thread.Sleep(2000);
            Console.WriteLine($"Aplicativo {nomeApp} desinstalado!!!");
        }

        public void ListarAplicativos()
        {
            Console.WriteLine($"Aplicativos instalados no {this.GetType().Name}:");

            foreach (string app in AplicativosInstalados)
            {
                Console.WriteLine(app);
            }
        }
    }
}