using System.Security.Cryptography;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public List<IphoneAppStore> Apps {get; set;}

        public Iphone(string numero, string modelo, string imei, int memoria) 
        : base(numero, modelo, imei, memoria)
        {
        }

        public void InicializarLoja(List<IphoneAppStore> apps)
        {
            if(apps.Count > 0) 
            {
                Apps = apps; 
            }
        }        

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Buscando {nomeApp}...");

            if(Apps.Any(a => a.App == nomeApp)) 
            {
                Console.WriteLine($"{nomeApp} encontrado...");
                Console.WriteLine($"Instalando {nomeApp} ...");
                Console.WriteLine($"{nomeApp} instalado!");
            }
            else
            {
                Console.WriteLine($"Lamento, não consegui encontrar {nomeApp}.");
            }
        }
    }
}