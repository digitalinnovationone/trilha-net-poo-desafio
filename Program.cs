using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "8888-8888", modelo: "Pro", imei: "9999999", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Dio");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "7777-7777", modelo: "K", imei: "6666666", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Github");
