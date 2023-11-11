using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia("123456009", "ModeloNokia", "IMEINokia", 32);

            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Iphone iphone = new Iphone("987677321", "ModeloIphone", "IMEIIphone", 64);

            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}