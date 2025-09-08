using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("12345", "Nokia Tijolão", "111111", 64);
Smartphone iphone = new Iphone("67890", "iPhone 14", "222222", 128);

Console.WriteLine("### Teste Nokia ###");
Console.WriteLine($"Modelo: {nokia.GetModelo()} | IMEI: {nokia.GetIMEI()} | Memória: {nokia.GetMemoria()}GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("### Teste iPhone ###");
Console.WriteLine($"Modelo: {iphone.GetModelo()} | IMEI: {iphone.GetIMEI()} | Memória: {iphone.GetMemoria()}GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");