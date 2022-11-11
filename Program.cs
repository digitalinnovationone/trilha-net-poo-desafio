using DesafioPOO.Models;

Console.WriteLine("Celular Nokia:");
var nokia = new Nokia(numero: "123456", modelo: "Nokia 110", imei: "00001111", memoria: 64);

nokia.Ligar("16982320577");
nokia.InstalarAplicativo("Whatsapp");
nokia.ListarAplicativos();
nokia.DesinstalarAplicativo("Whatsapp");
nokia.ListarAplicativos();


Console.Write("\n");

Console.WriteLine("Celular Iphone:");
var iphone = new Iphone(numero: "789456", modelo: "Iphone 4", imei: "22223333", memoria: 32);
iphone.ReceberLigacao();
iphone.ListarAplicativos();
iphone.InstalarAplicativo("Telegram");
iphone.InstalarAplicativo("Tiktok");
iphone.ListarAplicativos();