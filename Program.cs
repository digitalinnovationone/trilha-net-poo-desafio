using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "98888888", modelo: "Tijolo", imei: "999999", memoria: 10);
nokia.Ligar();
nokia.InstalarAplicativo("X");

Console.WriteLine('\n');

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "22222228", modelo: "Estevão Trabalhos", imei: "000000", memoria: 30);
iphone.Ligar();
iphone.InstalarAplicativo("Twitter");