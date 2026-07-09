using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("1111111", "Iphone 17 Pro Max", "lala", 500);

Nokia nokia = new Nokia("2222222", "Vesper", "lele", 256);

Console.WriteLine("Iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Icloud\n");

Console.WriteLine("Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Contatos");