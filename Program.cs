using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone - CHECK
Iphone IPPhone = new Iphone("+55 555777555", "New model", "123456789", 16);
Nokia NKPhone = new Nokia("+55 555777555", "New model", "123456789", 16);

Console.Write("Iphone Number: " + IPPhone.Number + "\n");
IPPhone.Ligar();
IPPhone.ReceberLigacao();
IPPhone.Number = ("+1 111222333");
IPPhone.Ligar();
IPPhone.InstalarAplicativo("Image Editor");

Console.Write("Nokia Number: " + NKPhone.Number + "\n");
NKPhone.Ligar();
NKPhone.ReceberLigacao();
NKPhone.Number = ("+1 111222333");
IPPhone.Ligar();
NKPhone.InstalarAplicativo("Notepad");