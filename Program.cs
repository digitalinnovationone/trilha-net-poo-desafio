using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia("11999999999", "Nokia X20", "Nokia", "1234567890", 128);
        nokia.Call();
        nokia.ReceiveCall();
        nokia.InstallApp("WhatsApp");

        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone("11988888888", "iPhone 13", "Apple", "0987654321", 256);
        iphone.Call();
        iphone.ReceiveCall();
        iphone.InstallApp("Telegram");
    }
}