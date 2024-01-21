using DesafioPOO.Models;


Nokia nokia = new Nokia("199334781", "Nokia Lumia", "120987635487352", 50);
Iphone iphone = new Iphone ("199685930", "Iphone 12", "156273847394850", 120);

nokia.InstalarAplicativo("Google Play");
nokia.Ligar();
nokia.ReceberLigacao();

iphone.InstalarAplicativo("App Store");
iphone.Ligar();
iphone.ReceberLigacao();