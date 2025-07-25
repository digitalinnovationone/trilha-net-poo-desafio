using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "999887070", modelo: "Nokia 5.3", imei: "198300274839287", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Reddit");

Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone(numero: "999778080", modelo: "Iphone 14", imei: "375493764893209", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

// TODO: Realizar os testes com as classes Nokia e Iphone