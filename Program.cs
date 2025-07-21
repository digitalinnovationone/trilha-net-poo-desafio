using DesafioPOO.Models;
Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "12345", modelo: "X", imei: "123456789", memoria: 512);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tasks");

Console.WriteLine("\n");

Console.WriteLine("iPhone");
Smartphone iphone = new Iphone(numero: "09876", modelo: "16", imei: "102938476", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");