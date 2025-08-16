using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "982782428", modelo: "Experia Z", imei: "IN82534569QW", memoria: 1024);
nokia.Ligar();
nokia.InstalarAplicativo("whatsApp");

Console.WriteLine("\n");

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "992269956", modelo: "13 PRO", imei: "AB58925478IJ", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Petsitter");