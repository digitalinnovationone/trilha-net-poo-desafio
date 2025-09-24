using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone meuIphone = new Iphone("99999-0000", "iPhone 14", "Preto");
Nokia meuNokia = new Nokia("88888-0000", "Nokia 3310", "Azul");

meuIphone.Ligar();
meuIphone.InstalarAplicativo("WhatsApp");

meuNokia.Ligar();
meuNokia.InstalarAplicativo("TeamfightTatics");
