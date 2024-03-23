using DesafioPOO.Models;

var nokia = new Nokia("27981272158");
var numero = nokia.Numero;
nokia.Memoria = 6;
nokia.IMEI = "123321456";
nokia.Modelo ="Flip";
var memoria = nokia.Memoria;
var imei = nokia.IMEI;
var modelo = nokia.Modelo;





Console.WriteLine();
Console.WriteLine("------------------xxxxxxxxxxxxxxxxxxxx--------------");
Console.WriteLine("Informações sobre o aparelho Nokia");
Console.WriteLine();
Console.WriteLine($"Número do celular nokia: {numero} ");
Console.WriteLine($"Memória do celular nokia: {memoria} GB");
Console.WriteLine($"Modelo do celular nokia: {modelo} ");
Console.WriteLine($"IMEI do celular nokia: {imei} ");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("watsApp");
Console.WriteLine();
Console.WriteLine("O aparelho está funcionando perfeitamente");
Console.WriteLine("------------------xxxxxxxxxxxxxxxxxxxx--------------");
Console.WriteLine();


var iphone = new Iphone("27981272158");
var numeroiphone = nokia.Numero;
iphone.Memoria = 6;
iphone.IMEI = "123321456";
iphone.Modelo ="Flip";
var memoriaiphone = iphone.Memoria;
var imeiiphone = iphone.IMEI;
var modeloiphone = iphone.Modelo;
Console.WriteLine();
Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
Console.WriteLine("Informações sobre o aparelho Iphone");
Console.WriteLine();
Console.WriteLine($"Número do celular iphone: {numeroiphone} ");
Console.WriteLine($"Memória do celular iphone: {memoriaiphone} GB");
Console.WriteLine($"Modelo do celular iphone: {modeloiphone} ");
Console.WriteLine($"IMEI do celular iphone: {imeiiphone} ");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("watsApp");
Console.WriteLine();
Console.WriteLine("O aparelho está funcionando perfeitamente");
Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");


