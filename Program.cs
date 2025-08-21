using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Testando Smartphone Nokia:");
// Instanciando um Nokia com número, modelo, IMEI e memória
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia G21", imei: "111111111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n---------------------------\n");

Console.WriteLine("Testando Smartphone iPhone:");
// Instanciando um iPhone com número, modelo, IMEI e memória
Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 15", imei: "222222222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
