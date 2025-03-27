using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

var nokia1 = new Nokia("99555954", "Nokia 3310", "12345", 16);
var iphone1 = new Iphone("99555954", "Iphone 12", "54321", 128);


nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo();

iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo();