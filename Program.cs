using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "810662", modelo: "Modelo 2", imei: "2222222222", memoria: 120);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");