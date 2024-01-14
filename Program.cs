using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("654321", "Modelo 1", "123456", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("---------------------------------------------");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("987654", "Modelo 2", "456789", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegran");