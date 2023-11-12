using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//IMPLEMENTADO
Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia(numero: "159612", modelo: "Modelo-g5", "255468", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo(" Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone: ");
Smartphone iphone = new Iphone(numero: "156842",modelo: "Iphone-Pro", imei: "158236", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo(" Telegram");