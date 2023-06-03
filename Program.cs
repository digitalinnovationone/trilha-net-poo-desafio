using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new Nokia("(83) 2489442", "NokiaM1", "302492", 7);
Iphone i1 = new Iphone("(83) 20993442", "IphoneM1", "2340459234", 9);

n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("WhatsApp");

i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Facebook");