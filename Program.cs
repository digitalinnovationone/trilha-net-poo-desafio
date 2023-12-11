using DesafioPOO.Models;

class Program{
    static void Main(){

            //teste Nokia
            Nokia nokiaTijolao = new Nokia("85859467", "Nokia Tijolão", "#6485", 32);
            nokiaTijolao.Ligar();
            nokiaTijolao.ReceberLigacao();
            nokiaTijolao.InstalarAplicativo("Flappy Bird");

            Console.WriteLine("----------------------------------------------");

            //teste iphone
            Iphone iphoneCapenga = new Iphone("01060309", "Iphone 6", "#0101", 16);
            iphoneCapenga.Ligar();
            iphoneCapenga.ReceberLigacao();
            iphoneCapenga.InstalarAplicativo("YouTube");

    }
}