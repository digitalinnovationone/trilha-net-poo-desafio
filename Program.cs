using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("1", "Nokia", "imei", "128gb");
Iphone iphone = new Iphone("2", "Iphone", "imei", "128gb");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Subway Surfers");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Subway Surfers");