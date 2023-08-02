using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new Nokia("(21)983088253", "Nokia1", "234234", 64);
Iphone i1 = new Iphone("(21)983088253", "Iphone1", "423423", 128);

Console.WriteLine("Nokia");
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Thread");