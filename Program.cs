using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1234-5678", modelo: "Modelo 1", imei: "111111111", memoria: 64);

// Teste com número válido
nokia.Ligar("9987654321");
nokia.ReceberLigacao();

// Teste com número inválido
nokia.Ligar("123");
nokia.ReceberLigacao();

// Instalação de aplicativo
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n--------------------------------\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "9876-5432", modelo: "Modelo 2", imei: "222222222", memoria: 128);

// Teste com número válido
iphone.Ligar("9123456789");
iphone.ReceberLigacao();

// Teste com número inválido 
iphone.Ligar("");
iphone.ReceberLigacao();

// Instalação de aplicativo
iphone.InstalarAplicativo("WhatsApp");