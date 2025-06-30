namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        private string Model { get; set; }
        private string Brand { get; set; }
        private string IMEI { get; set; }
        private int Storage { get; set; }

        public Smartphone(string number, string model, string brand, string imei, int storage)
        {
            Number = number;
            Model = model;
            Brand = brand;
            IMEI = imei;
            Storage = storage;
        }

        public void Call()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstallApp(string appName);
    }
}