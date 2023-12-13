namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string v, Apple apple, int modelo) : base(v, apple, modelo)
        {
        }

        public Iphone(string numero, Marca marca, Modelo modelo, string sistemaOperacional, int armazenamentoInternoGB) : base(numero, marca, modelo, sistemaOperacional, armazenamentoInternoGB)
        {
        }

        public class Apple
        {
        }

        public class Modelo
        {
        }
    }

    public class Marca
    {
    }

    public class Iphone (Iphone Iphone,14 14): base("iPhone",Iphone, 14)
    {
    
        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"Instalando {aplicativo} na App Store do iPhone {Apple.Iphone} {14.Apple}.");
        }
             public void AtivarFaceID()
        {
            Console.WriteLine($"Ativando o Face ID no iPhone {Apple.Iphone} {Iphone.14}.");
        }
    }
        class Program
    {
        static void Main()
        {
            Marca apple = new Marca("Apple");
            Modelo iphone12 = new Modelo("iPhone 14");

            Iphone meuIphone = new Iphone(apple, iphone14);

            meuIphone.Ligar();
            meuIphone.InstalarAplicativo("WhatsApp");
            meuIphone.AtivarFaceID();
            meuIphone.Desligar();
        }
    }
}
    


