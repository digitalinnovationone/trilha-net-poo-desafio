using DesafioPOO.Models;

Console.WriteLine("Testando o Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "912345678", modelo: "Nokia G21", imei: "111111111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n-------------------\n");

Console.WriteLine("Testando o Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 15 Pro", imei: "222222222222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");