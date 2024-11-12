using DesafioPOO.Models;

Console.WriteLine("Smartphone: Iphone");
Iphone phone1 = new("(00)00000-1111", "Iphone 15 Pro", "123456789012345", 128);
phone1.Ligar();
Console.WriteLine($"Seu número é: {phone1.Numero}");
phone1.InstalarAplicativo("Telegram");

Console.WriteLine("\n---------------------------------------\n");

Console.WriteLine("Smartphone: Nokia");
Nokia phone2 = new("(00)11111-2222", "Nokia C21", "23413567890657432", 128);
phone2.ReceberLigacao();
Console.WriteLine($"Seu número é: {phone2.Numero}");
phone2.InstalarAplicativo("Whatsapp");