namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, string brand, string imei, int storage) 
            : base(number, model, brand, imei, storage)
        {
        }
    
        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Instalando aplicativo iphone:{appName}");
        }
    }
}