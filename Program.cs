using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia: ");
Smartphone nokia1 = new Nokia("11994443332", "Modelo Nokia1", "12351513", 128);

nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("GitHub");

Console.WriteLine("\n\n");

Console.WriteLine("iPhone: ");
Smartphone iphone1 = new Iphone("1194411144332", "Modelo iPhone1", "234772347", 256);

iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("LinkedIn");