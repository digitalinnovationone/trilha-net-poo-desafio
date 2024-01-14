using DesafioPOO.Models;
using System;

namespace DesafioPOO.Models
{


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nokia");
            Smartphone nokia = new Nokia("1", "Nokia 1", "1234", 246810);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Pou");


            Console.WriteLine("\n\nIphone");

            Smartphone iphone = new Iphone("2", "Iphone 1", "245", 2141);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Safari");

        }
    }
}