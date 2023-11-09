using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia");
Nokia nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "555555", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine('\n');

Console.WriteLine("Iphone");
Iphone iphone = new Iphone(numero: "456789", modelo: "Modelo 2", imei: "222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");