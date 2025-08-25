using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("9999-1111", "Nokia Tijolão", "123456789", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iPhone = new Iphone("9999-2222", "iPhone 14 Pro", "987654321", 256);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Instagram");