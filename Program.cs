using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartpone Nokia");
Smartphone nokia = new Nokia("123456789","11111","Modelo 01",128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartpone iPhone");
Smartphone ipone = new Iphone("056789544","22222","Modelo 02",254);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegran");