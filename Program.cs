using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "654321", modelo: "Modelo 1", imei: "121212121", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone(numero: "7890", modelo: "Modelo 2", imei: "232323232", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");