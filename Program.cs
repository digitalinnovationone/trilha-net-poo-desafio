using DesafioPOO.Models;

// Implementado!

Nokia Celular1 = new Nokia("1230", "Nokia Lumia 630", "8090", 120);
Iphone Celular2 = new Iphone("9010", "Iphone 17", "7650", 500);

Console.WriteLine("Qual App deseja instalar?: ");
string app = Console.ReadLine();


Console.WriteLine("Nokia--------------");

Celular1.Ligar();
Celular1.ReceberLigacao();
Celular1.InstalarAplicativo(app);

Console.WriteLine("Iphone--------------");

Celular2.Ligar();
Celular2.ReceberLigacao();
Celular2.InstalarAplicativo(app);