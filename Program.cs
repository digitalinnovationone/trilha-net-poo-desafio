using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 16);
nokia.Ligar();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("\nSmartphone Iphone:");
Iphone iphone = new Iphone("987654321", "iPhone 13", "987654321098765", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram"); 
