using DesafioPOO.Models;

Nokia celular1 = new Nokia("940028922", "K15", "8765432123", 128);
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("WhatsApp");
Console.WriteLine("---------------");

Iphone celular2 = new Iphone("912345678", "12", "123456789", 128);
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Telegram");
