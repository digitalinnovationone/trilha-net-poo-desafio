using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("999555362", "G60", "1234567M996", 6000);
Smartphone iPhone = new Iphone("9876547890", "XR", "14758H1234", 128000);

Console.WriteLine("=============== Testing Nokia ===============");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tinder");
Console.WriteLine("=============================================");

Console.WriteLine("");

Console.WriteLine("=============== Testing IPhone ===============");
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Zé Delivey");
Console.WriteLine("=============================================");
