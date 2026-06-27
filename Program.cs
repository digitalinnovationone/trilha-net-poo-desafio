using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia("2222-4356", "ssdssp", "987654321", 64);
nokia.Ligar();
nokia.InstalarAplicativo("whattsapp");

Console.WriteLine("\n--------------------------------------------------\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("4444-4567", "xbbore", "234789123", 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");