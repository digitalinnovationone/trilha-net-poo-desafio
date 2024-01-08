using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

class program
{
static void Main()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Smartphone modelo: Iphone");
        Smartphone iphone = new Iphone("81 9999-8888","XR-13", "123654", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        //Console.WriteLine("\n");
        Console.WriteLine("-----------------------------------------------------");
        //Console.WriteLine("\n");

        Console.WriteLine("Smartphone modelo: Nokia");
        Smartphone nokia = new Nokia("81 99989-9898", "Patchland", "365423", 8);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("FaceBook");
        Console.WriteLine("\n");
    }


}

