using DesafioPOO.Models;

public class Program
{
    public static void Main()
    {
        try{
        Nokia nokia = new Nokia("123456789", "Nokia 3310", "IMEI123456789", 16);
        nokia.Ligar();
        nokia.InstalarAplicativo("Snake");
        nokia.ReceberLigacao();
        Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI987654321", 128);
        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");
        iphone.ReceberLigacao();}
        catch(Exception ex){
            Console.WriteLine($"Erro: {ex.Message}");
            return;
        }
        Console.WriteLine("Testes concluídos com sucesso.");

    }
}
// TODO: Realizar os testes com as classes Nokia e Iphone