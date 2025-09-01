using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Tijolo", imei: "121212", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

//
Console.WriteLine("Smartphone IPhone:");
Smartphone iPhone = new Iphone(numero: "987654321", modelo: "iPhone 17", imei: "222444", memoria: 256);
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Instagram");
