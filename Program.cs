using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia3000", imei: "AGHAKS5467Y32A", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("\n Smartphone Iphone:");
Smartphone ihpone = new Nokia(numero: "123456", modelo: "Iphone 12 Pro Max", imei: "8348UHADN7137YW", memoria: 128);
ihpone.ReceberLigacao();
ihpone.InstalarAplicativo("Instagram");