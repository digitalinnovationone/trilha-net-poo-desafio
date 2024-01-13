using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine($"Recebendo dados de seu smartphone, aguarde...");
Smartphone iosMobile = new Iphone(numero: "998909050", modelo: "Iphone SE 1° Gen", imei: "i345d593un93ni12co" , memoria: 128);
Iphone.Ligar();
Iphone.InstalarAplicativo("Whatsapp");

console.WriteLine("-------------------------------------------------------- \n")

Console.WriteLine($"Recebendo dados de seu smartphone, aguarde...");
Smartphone msLumia = new Nokia(numero: "998909050", modelo: "Nokia Lumia 710", imei: "i345d593un93ni12co" , memoria: 64);
Iphone.Ligar();
Iphone.InstalarAplicativo("Z0mb13");
