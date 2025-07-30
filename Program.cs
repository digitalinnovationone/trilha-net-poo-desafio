using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "1111", modelo: "bbbbb", imei: "hshshshs", memoria: 124);
Smartphone ipone = new Iphone(numero: "2222", modelo: "ccccc", imei: "x-x-x-x-", memoria: 256);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tinder");
//
ipone.Ligar();
ipone.ReceberLigacao();
ipone.InstalarAplicativo("Zapzap");