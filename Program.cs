using DesafioPOO.Models;

Smartphone apple = new Iphone("179981260313", "iPhone 13", "A123E", 128);
Console.WriteLine(apple);
apple.Ligar();
apple.InstalarAplicativo("zapzap");

Smartphone nokia = new Nokia("179981260313", "Lumia", "A5369", 64);
Console.WriteLine(nokia);
nokia.Ligar();
nokia.InstalarAplicativo("facetruque");