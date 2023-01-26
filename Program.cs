using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
class Program
    {
    static void Main(string[] args)
            {
            Nokia nokia = new Nokia("12345678");
            nokia.Modelo = "Nokia 3310";
            nokia.IMEI = "1234567890";
            nokia.Memoria = 64;
            nokia.InstalarAplicativo("WhatsApp");
            nokia.Ligar();
            nokia.ReceberLigacao();
            
                    Iphone iphone = new Iphone("87654321");
                    iphone.Modelo = "Iphone X";
                    iphone.IMEI = "0987654321";
                    iphone.Memoria = 512;
                    iphone.InstalarAplicativo("Spotify");
                    iphone.Ligar();
                    iphone.ReceberLigacao();
            }
    }
}