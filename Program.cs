using DesafioPOO.Models;

Console.WriteLine("Testando criação de dispositivos");

Nokia nokia = new(numero: "11999990000", modelo: "Nokia 3310", imei: "86753090", memoria: 64);
Iphone iphone = new(numero: "11888887777", modelo: "iPhone 14", imei: "12345678", memoria: 128);

nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
