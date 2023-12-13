using DesafioPOO.Models;

class Program
{
    // TODO: Realizar os testes com as classes Nokia e Iphone
    static void Main() 
    {
        // Exemplo de uso
        Nokia nokiaPhone = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "IMEI123", memoria: 128);
        nokiaPhone.Ligar();
        nokiaPhone.ReceberLigacao();
        nokiaPhone.InstalarAplicativo("WhatsApp");

        Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI456", 64);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }

}

