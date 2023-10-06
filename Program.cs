using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia(numero: "12341234", modelo: "Modelo Nokia", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone(numero: "43214321", modelo: "Iphone 12", imei: "222222222", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");