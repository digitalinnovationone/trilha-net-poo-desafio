using DesafioPOO.Models;

Console.WriteLine("Celular Nokia");
Smartphone nokia = new Nokia("123", "Modelo 1", "112345666491411", 64);

nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
nokia.Ligar();

Console.WriteLine("\n");

Console.WriteLine("Celular Iphone");
Smartphone iphone = new Iphone("122", "Iphone 6", "112345666491111", 256);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
iphone.Ligar();
// TODO: Realizar os testes com as classes Nokia e Iphone