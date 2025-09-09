using DesafioPOO.Models;

Nokia nokia = new Nokia("1020304050", "Nokia", "1020304050", 100);    
Console.WriteLine($"Nokia número: {nokia.Numero}\nModelo: {nokia.Modelo}\nIMEI: {nokia.Imei}\nMemória: {nokia.Memoria}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Dio-Nokia");

Console.WriteLine();
Iphone iphone = new Iphone("123456789", "Iphone", "123456789", 200);   
Console.WriteLine($"Iphone número: {iphone.Numero}\nModelo: {iphone.Modelo}\nIMEI: {iphone.Imei}\nMemória: {iphone.Memoria}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Dio-Iphone");
