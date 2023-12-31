using DesafioPOO.Models;


Console.WriteLine("iPhone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "iphoneX", imei: "999999999", memoria: 128);
iphone.LigarAparelho();
iphone.InstalarAplicativo("Youtube");
iphone.InstalarAplicativo("Brave");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Teams");
iphone.DesligarAparelho();

Console.WriteLine("\n");

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "999997777", modelo: "Tijolão", imei: "111111111", memoria: 64);
nokia.LigarAparelho();
nokia.Ligar("Roberto");
nokia.InstalarAplicativo("Discord");
nokia.InstalarAplicativo("Bradesco");
iphone.ReceberLigacao();
nokia.InstalarAplicativo("Destiny Companion");
nokia.DesligarAparelho();



