using DesafioPOO.Models;

Console.Clear();
Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone(numero: 654321, modelo: "15 pro", tamanho: 24, cor: "branco");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Grindr");
iphone.DadosSmartphone();
Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: 123546, modelo: "Tijolão", tamanho: 15, cor: "cinza");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tinder");
nokia.DadosSmartphone();
Console.WriteLine("\n");