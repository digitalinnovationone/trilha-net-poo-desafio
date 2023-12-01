using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

class Program{
    static void Main(){
            Console.WriteLine("criando iphone");
            Iphone iphone = new Iphone("432423", "iphone 13", "3423423", 64);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("DIO");

            Console.WriteLine("criando NOKIA");
            Nokia nokia = new Nokia("2374322", "nokia avanade", "232556", 128);

            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("AVANADE");

 
    }
}