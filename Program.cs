using CelularPOO.Models;

Smartphone nokia = new Nokia("986598658", "Lumia", "N74859632", 32);
Console.WriteLine("Nokia");
nokia.Ligar();
nokia.InstalarAplicativo("Navegador");

Console.WriteLine();

Smartphone apple = new Iphone("968596859", "IPhone 13 PRO", "I74875896", 256);
Console.WriteLine("Apple");
apple.ReceberLigacao();
apple.InstalarAplicativo("FaceCall");