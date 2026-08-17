using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone iphone = new Iphone(numero: "11945390755", modelo: "Iphone 17", imei: "111222333444", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("iMovie");

Console.WriteLine("--------------------------");

Smartphone nokia = new Nokia(numero: "11983901223", modelo: "X30", imei: "444333222111", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");