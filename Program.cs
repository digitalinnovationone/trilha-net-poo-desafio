using DesafioPOO.Models;

Iphone i = new Iphone("333333333", "IX30", "2345", 86);
i.Ligar();
i.InstalarAplicativo("Telegram");

Console.WriteLine("-------------------------");

Nokia n = new Nokia("444444444", "GALAXY", "5647", 96);
n.ReceberLigacao();
n.InstalarAplicativo("Waze");