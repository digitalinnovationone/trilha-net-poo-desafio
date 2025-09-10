using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokiaTijolao = new Nokia("9.1234-5678", "Nokia 3310", "0101010101", 4);
Smartphone iphoneMaxPro = new Iphone("9.9999-9999", "iPhone 4S", "1010101010", 256);

nokiaTijolao.Ligar(iphoneMaxPro.Numero);
nokiaTijolao.ReceberLigacao(iphoneMaxPro.Numero);
nokiaTijolao.InstalarAplicativo("MSN Messenger");

iphoneMaxPro.Ligar(nokiaTijolao.Numero);
iphoneMaxPro.ReceberLigacao(nokiaTijolao.Numero);
iphoneMaxPro.InstalarAplicativo("iTunes");