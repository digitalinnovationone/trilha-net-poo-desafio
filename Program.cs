using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "00-12345-6789", modelo: "A40", imei: "nokia@teste1.com", memoria: 240);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");


Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "00-12345-6789", modelo: "15C", imei: "iphone@teste2.com", memoria: 127);
iphone.Ligar();
iphone.InstalarAplicativo("Zoom");



