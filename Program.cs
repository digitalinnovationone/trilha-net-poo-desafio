using DesafioPOO.Models;

Smartphone cel1 = new Nokia("1234", "Nokia", "123456", 16);
cel1.Ligar();
cel1.InstalarAplicativo("Whatsapp");



Console.WriteLine("\n");

Smartphone cel2 = new Iphone("1234", "Iphone", "123456", 16);
cel2.ReceberLigacao();
cel2.InstalarAplicativo("Instagram");
