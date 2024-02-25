using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando Nokia");
Nokia nokia = new("123456789", "123456789", "Nokia 3310", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Testando Iphone");
Iphone iphone = new("987654321", "987654321", "Iphone 12", 16);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

// Output esperado:
// Testando Nokia
// Ligar Nokia
// Recebendo ligação no Nokia
// Instalando aplicativo WhatsApp no Nokia
//
// Testando Iphone
// Ligar Iphone
// Recebendo ligação no Iphone
// Instalando aplicativo Instagram no Iphone
