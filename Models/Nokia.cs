namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        
        public List<NokiaAppStore> Apps {get; set;}

        public Nokia(string numero, string modelo, string imei, int memoria) 
        : base(numero, modelo, imei, memoria)
        {
        }

        public void InicializarLoja(List<NokiaAppStore> apps)
        {
            if(apps.Count > 0) 
            {
                Apps = apps; 
            }
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Localizando {nomeApp}...");
            
            if(Apps.Any(a => a.App == nomeApp)) 
            {
                Console.WriteLine($"{nomeApp} localizado...");
                Console.WriteLine($"Instalando {nomeApp} ...");
                Console.WriteLine($"{nomeApp} instalado!");
            }
            else
            {
                Console.WriteLine($"Não foi localizado o aplicativo {nomeApp}.");
            }
        }
    }
}