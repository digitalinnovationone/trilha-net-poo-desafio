using DesafioPOO.Models;

Console.WriteLine("Smartphone Desafio - DIO");
// TODO: Realizar os testes com as classes Nokia e Iphone
var nokia1 = new Nokia("11999999999", "Nokia 6.1", "1234567890", 64);
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("WhatsApp");

var iphone1 = new Iphone("61987654321", "iPhone 12", "0987654321", 128);
iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Telegram");

var nokia2 = new Nokia("11988888888", "Nokia 7.2", "1122334455", 128);
nokia2.Ligar();
nokia2.ReceberLigacao();
nokia2.InstalarAplicativo("Facebook");

var iphone2 = new Iphone("61912345678", "iPhone 13", "2233445566", 256);
iphone2.Ligar();
iphone2.ReceberLigacao();
iphone2.InstalarAplicativo("Instagram");

List<Smartphone> smartphones = new List<Smartphone>
{
    nokia1,
    iphone1,
    nokia2,
    iphone2
};

Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Lista de Smartphones:");
foreach (var smartphone in smartphones)
{
    Console.WriteLine($"Modelo: {smartphone.ModeloPublico}, IMEI: {smartphone.IMEIPublico}, Memória: {smartphone.MemoriaPublica}GB");
}