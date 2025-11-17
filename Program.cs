using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1234", modelo: "z1", imei: "999999999", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("---------------");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "5896", modelo: "mod.2", imei: "8888888888", memoria:64);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");