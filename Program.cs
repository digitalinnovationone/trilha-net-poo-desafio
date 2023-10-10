using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("123456789", "iPhone 12", "123456789", 256);
Nokia nokia = new Nokia("987654321", "Nokia 3310", "987654321", 64);

iphone.Ligar();
iphone.ReceberLigacao();
nokia.Ligar();
nokia.ReceberLigacao();

iphone.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Instagram");