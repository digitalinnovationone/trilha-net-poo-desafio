using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "981818181", modelo: "Modelo A", imei: "88888888", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n--------------------------\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "984848484", modelo: "Modelo B", imei: "99999999", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
