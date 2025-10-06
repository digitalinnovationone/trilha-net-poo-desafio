using DesafioPOO.Models;

// Teste com Nokia
Smartphone nokia = new Nokia(numero: "11999999999", modelo: "Nokia 3310", imei: "1234567890", memoria: 64);
Console.WriteLine("=== Teste Nokia ===");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();
Console.WriteLine($"Modelo: {nokia.Modelo} | IMEI: {nokia.IMEI} | Memória: {nokia.Memoria}GB");
Console.WriteLine();

// Teste com iPhone
Smartphone iphone = new Iphone(numero: "11988888888", modelo: "iPhone 15", imei: "0987654321", memoria: 256);
Console.WriteLine("=== Teste iPhone ===");
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();
Console.WriteLine($"Modelo: {iphone.Modelo} | IMEI: {iphone.IMEI} | Memória: {iphone.Memoria}GB");
