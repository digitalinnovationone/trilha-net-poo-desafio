using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone(numero: "654321", modelo: "iPhone 15", imei: "222222222", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

// Output esperado:
// Smartphone Nokia:
// Ligando...
// Recebendo ligação...
// Instalando o aplicativo WhatsApp no Nokia através da Nokia Store...

// Smartphone iPhone:
// Ligando...
// Recebendo ligação...
// Instalando o aplicativo Telegram no iPhone através da App Store...