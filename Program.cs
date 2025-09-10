using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");

Nokia nokia = new Nokia("11932252373", "Nokia 3310", "11111", 256);
nokia.Ligar();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("\nSmartphone Iphone:");
Iphone iphone = new Iphone("11971653989", "Iphone 17", "22222", 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");