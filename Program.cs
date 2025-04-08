using DesafioPOO.Models;

Nokia n1 = new Nokia("99999-9999", "n21", "1234", 64);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Whatsapp");

Iphone i1 = new Iphone("99999-9999", "i11S", "5678", 128);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Whatsapp");