using DesafioPOO.Models;
using System;


// TODO: Realizar os testes com as classes Nokia e Iphone





Console.WriteLine("SmartPhone Iphone");
Iphone ip1 = new Iphone(numero:"159979823",modelo: "Modelo 1", iMEI: "92839273817",memoria: 64);
ip1.Ligar();
ip1.ReceberLigacao();
ip1.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");
Nokia nk1 = new Nokia(numero:"1597261723",modelo: "Modelo 3", iMEI: "22312323223",memoria: 128);
Console.WriteLine("SmartPhone Nokia");
nk1.Ligar();
nk1.ReceberLigacao();
nk1.InstalarAplicativo("Telegram");







