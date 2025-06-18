using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

public class Program
{
    public static void Main(string[] args)
    {
        Iphone iphone = new Iphone("84999999", "16", "023012001239", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        
        iphone.InstalarAplicativo("Whatsapp");
        
        Nokia nokia = new Nokia("84999999", "ASHA", "023012001239", 128);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Whatsapp");
        

    }
}