using DesafioPOO.Models;

Iphone iphone = new Iphone("11223344", "iPhone 15", "IMEI1234", 128);
Nokia nokia = new Nokia("55667788", "Nokia XR20", "IMEI5678", 128);

nokia.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Telegram");