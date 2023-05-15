using DesafioPOO.Models;

Console.WriteLine("\nInicializando testes nos celulares\n");

Console.WriteLine("\nInicializando testes no MotoG\n");

Motorola celular1  = new Motorola("998877766");
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("Meu Fogão");

Console.WriteLine("\nInicializando testes no Iphone\n");

Iphone celular2 = new Iphone("959856525");
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Telegram");

Console.WriteLine("\nInicializando testes no Samsung\n");


Samsumg celular3 = new Samsumg("40028922");
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("COD");
