using DesafioPOO.Models;

Console.WriteLine("Testando Nokia:");
Nokia nokia = new Nokia("11999999999", "Nokia 3310", "123456789012345", 512);
Console.WriteLine($"Número: {nokia.Numero}\nModelo: {nokia.Modelo}\nIMEI: {nokia.Imei}\nMemória: {nokia.Memoria}.");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();

Console.WriteLine();
Console.WriteLine("Testando iPhone:");
Iphone iphone = new Iphone("11988888888", "iPhone 13", "987654321098765", 128);
Console.WriteLine($"Número: {iphone.Numero}\nModelo: {iphone.Modelo}\nIMEI: {iphone.Imei}\nMemória: {iphone.Memoria}.");
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();