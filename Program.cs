using DesafioPOO.Models;

// Testando as classes Nokia e Iphone

// Criando instâncias
Smartphone iphone = new Iphone("1234-5678", "iPhone 15", "123456789012345", 256);
Smartphone nokia = new Nokia("8765-4321", "Nokia G42", "987654321098765", 128);

Console.WriteLine("=== Teste iPhone ===");
Console.WriteLine($"Número: {iphone.Numero}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("=== Teste Nokia ===");
Console.WriteLine($"Número: {nokia.Numero}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
