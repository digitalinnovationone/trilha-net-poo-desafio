using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");

Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");

Smartphone iphone = new Iphone(numero: "54321", modelo: "Modelo 14", imei: "1234555", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Youtube");