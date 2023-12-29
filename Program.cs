using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "9999", modelo: "M1", imei: "010101010", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("--------------------------------------------");

Console.WriteLine("IPhone:");
Smartphone iphone = new Iphone(numero: "0000", modelo: "M2", imei: "020202020", memoria: 256);
iphone.InstalarAplicativo("Twitter");
iphone.Ligar();
iphone.ReceberLigacao();