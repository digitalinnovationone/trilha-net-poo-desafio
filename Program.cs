using DesafioPOO.Models;

// Realizando testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
var nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram Android");

Console.WriteLine(); // Linha em branco

Console.WriteLine("Smartphone iPhone:");
var iphone = new Iphone(numero: "654321", modelo: "iPhone 14", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram IOS");