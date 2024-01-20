using System.Linq.Expressions;

namespace DesafioPOO.Models
{
    // DONE: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(
            string numero, 
            string marca, 
            string modelo, 
            string imei, 
            int memoria, 
            string operadora,
            int total
        ) : base(numero, marca, modelo, imei, memoria, operadora, total)
        { }

        // DONE: Sobrescrever o método "InstalarAplicativo"
        public override bool InstalarAplicativo(){

            if (Memoria == 0) {
                Console.WriteLine($"Seu Nokia - {Modelo} não possui memória suficiente para instalar um novo app");                    
                return true;
            }

            Console.WriteLine("Informe o nome do app que você deseja instalar:");
            string nomeApp = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nomeApp)){
                Console.WriteLine("Nome do aplicativo não pode ser vazio ou conter apenas espaços em branco.");
                return false;
            }
            else if (!apps.Contains(nomeApp)) {
                apps.Add(nomeApp);
                --Memoria;
                Console.WriteLine($" Aplicativo {nomeApp} instalado com sucesso!");
                return false;                
            }   

            Console.WriteLine($"O app {nomeApp} já existe em seu Nokia");
            return false;             
        }

        public override void Comprar () {
            if(Credito>0) {
                --Credito;
                DateTime data = DateTime.Now; 
                historico.Add($"-$1,00 em {data}");
                ++Memoria;
                Console.WriteLine("Memória adicionada ao seu Nokia com sucesso!");
            } else {
                Console.WriteLine("Você não tem créditos :(");
            }
        }
    }
}