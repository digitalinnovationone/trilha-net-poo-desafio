using DesafioPOO.Models;

Smartphone iphone = new Iphone("1111-2222", "iPhone 12", "000111222333444", 128);
Smartphone nokia = new Nokia("3333-4444", "Nokia 3310", "555666777888999", 32);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake EV");