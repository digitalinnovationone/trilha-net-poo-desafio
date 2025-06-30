namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string number, string model, string brand, string imei, int storage) 
            : base(number, model, brand, imei, storage)
        {
        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Instalando aplicativo nokia android: {appName}");
        }
    }
}