using DesafioPOO.Models;

// Teste com Nokia
Smartphone nokia = new Nokia("11999999999", "Nokia 3310", "123456789012345", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

// Teste com iPhone
Smartphone iphone = new Iphone("11988888888", "iPhone 13", "987654321098765", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");