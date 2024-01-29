using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "123456789", memoriaInterna: 16);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "Iphone 12", imei: "987654321", memoriaInterna: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");


// TODO: Realizar os testes com as classes Nokia e Iphone