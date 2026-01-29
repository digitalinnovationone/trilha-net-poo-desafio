using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

var celularIphone = new Iphone("98313247", "13", "435454", 46);

celularIphone.InstalarAplicativo("whatsapp");

var celularNokia = new Iphone("63050204", "versão 2009", "564533", 100);

celularNokia.InstalarAplicativo("agenda");


celularIphone.Ligar();

