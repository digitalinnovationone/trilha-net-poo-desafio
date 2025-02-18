using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
Nokia.Ligar();
Nokia.ReceberLigacao();
Nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone Iphone:");
Smartphone Iphone = new Iphone("987654321", "Iphone 12", "987654321", 128);
Iphone.Ligar();
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Instagram");

// TODO: Realizar os testes com as classes Nokia e Iphone