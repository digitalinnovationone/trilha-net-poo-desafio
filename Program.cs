using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia=new Nokia("123","1","2",4);

Smartphone iphone=new Iphone("321","412323","34545",4);

nokia.InstalarAplicativo("Whatsapp");
nokia.Ligar();
nokia.ReceberLigacao();


iphone.InstalarAplicativo("Whatsapp");
iphone.Ligar();
iphone.ReceberLigacao();