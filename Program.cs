using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"987654", modelo:"G60", imei:"2552", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Duolingo");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"564737", modelo:"Iphone 14", imei:"8998", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");