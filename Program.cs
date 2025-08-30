using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone

// Testando Nokia
Nokia nokia = new Nokia("11999999999", "Nokia Tijolão", "111111111111111", 64);
Console.WriteLine("=== Testando Nokia ===");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

// Linha em branco para separar
Console.WriteLine();

// Testando Iphone
Iphone iphone = new Iphone("11988888888", "iPhone 15 Pro", "222222222222222", 512);
Console.WriteLine("=== Testando iPhone ===");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
