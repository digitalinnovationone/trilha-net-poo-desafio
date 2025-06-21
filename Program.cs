using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new Nokia("99-9999999", "k100", "XPTO9780", 512);
n1.ReceberLigacao();
n1.Ligar();
n1.InstalarAplicativo("WhatsApp");

Iphone i1 = new Iphone("88-88888888", "15 PRO", "KASLKSD234", 256);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Instagram");