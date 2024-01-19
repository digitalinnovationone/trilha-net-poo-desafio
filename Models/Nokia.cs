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

            Console.WriteLine("Informe o nome do app que você deseja instalar:");
            string nomeApp = Console.ReadLine();

            if (!apps.Contains(nomeApp)) {

                if (Memoria >= 1) {

                    apps.Add(nomeApp);
                    --Memoria;
                    Console.WriteLine($" Aplicativo {nomeApp} instalado com sucesso!");

                    return false;
                   
                } else {

                    Console.WriteLine($"Seu Nokia - {Modelo} não possui memória suficiente para instalar o app {nomeApp}");                    
                    return true;
                    
                }                
            }
            else {
                Console.WriteLine($"O app {nomeApp} já existe em seu Nokia");
                return false; 
            }
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