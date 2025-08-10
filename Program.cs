using DesafioPOO.Models;

//Testando as classes Nokia e Iphone

Nokia nokia = new Nokia("11999999999", 14.5, "Nokia N", 123456789012345, 64, "GB");
Iphone iphone = new Iphone("11988888888", 15.0, "Iphone 15 Pro", 987654321098765, 128, "GB");

nokia.MostrarModelo();
nokia.MostrarIMEI();
nokia.MostrarMemoria();
nokia.InstalarAplicativo("Nokia APK");

Console.WriteLine(new string('-', 50));

iphone.MostrarModelo();
iphone.MostrarIMEI();
iphone.MostrarMemoria();
iphone.InstalarAplicativo("IP System");