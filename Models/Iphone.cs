namespace DesafioPOO.Models
{
    // DONE: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        public Iphone() {}
        public Iphone(
            string numero, 
            string marca, 
            string modelo, 
            string imei, 
            int memoria, 
            int memoriaRam, 
            string operadora
        ) : base(numero, marca, modelo, imei, memoria, memoriaRam, operadora)
        {

        }
        // DONE: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo() {
                       
            Console.WriteLine("Informe o nome do app que você deseja instalar:");
            string nomeApp = Console.ReadLine();

            if (!apps.Contains(nomeApp)) {

                if (Memoria >= 1) {

                    apps.Add(nomeApp);
                    --Memoria;
                    Console.WriteLine($" Aplicativo {nomeApp} instalado com sucesso!");

                } else {

                    Console.WriteLine($"Seu Iphone - {Modelo} não possui memória suficiente para instalar o app {nomeApp}" + "\n"
                    + "Caso deseje instalar o app, você pode desinstalar um app já existente em seu Ophone");

                }
                
            }
            else {
                Console.WriteLine($"O app {nomeApp} já existe em seu Iphone");
            }
        }
    }
}