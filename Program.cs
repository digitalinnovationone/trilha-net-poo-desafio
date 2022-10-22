using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "333456789", modelo: "Modelo 1", imei: "123123123", memoria: 82);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "777456321", modelo: "Modelo 2", imei: "321654987", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

