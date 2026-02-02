using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

System.Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("123456", "Modelo 1", "11111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("4987", "Modelo 2", "2222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");