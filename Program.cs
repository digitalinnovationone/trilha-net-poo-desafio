using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo1", imei: "1111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo2", imei: "2222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");