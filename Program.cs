using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone iphone:");
Iphone iphone = new Iphone(numero: "1", modelo: "A", imei: "1",memoria: 9);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Clash Royale");

Console.WriteLine("----------------------------------------------------------");

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "2", modelo: "B", imei: "2",memoria: 15);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Clash of Clans");


