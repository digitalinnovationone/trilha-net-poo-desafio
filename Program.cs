using DesafioPOO.Models;

Iphone celular = new Iphone("(00)1234-5678", "Ïphone 13 plus", "001", 32);
Console.WriteLine(celular.numero);
celular.Ligar();
celular.ReceberLigacao();
celular.numero = "(11)5678-1234";
Console.WriteLine(celular.numero);
celular.InstalarAplicativo("Whatsapp");

Nokia celular2 = new Nokia("(00)1234-5678", "Nokia open camera", "002", 16);
Console.WriteLine(celular2.numero);
celular2.Ligar();
celular2.ReceberLigacao();
celular2.numero = "(11)5678-1234";
Console.WriteLine(celular.numero);
celular2.InstalarAplicativo("Telegram");
