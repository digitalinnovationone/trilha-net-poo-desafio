using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "Modelo 1", "11111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Xvidros");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("14356", "Modelo caro", "847583", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Zap");