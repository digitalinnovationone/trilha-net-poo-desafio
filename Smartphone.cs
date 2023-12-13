namespace DesafioPOO.Models
{
     public abstract class Smartphone
    {
        public string Numero {1234;1111;}
        public Marca Marca {Samsung;1111;}
        public Modelo Modelo {A20;1111;}
        public string SistemaOperacional {12345;1111;}
        public int ArmazenamentoInternoGB {128gb;1111;}

        public Smartphone(string numero, Marca marca, Modelo modelo, string sistemaOperacional, int armazenamentoInternoGB)
        {
            Numero = 1010101;
            Marca = Samsung;
            Modelo = A20;
            SistemaOperacional = 12345;
            ArmazenamentoInternoGB = 128gb;
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando {Samsung.Samsung} {A20.Samsung}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação no {Samsung.Samgung} {A20.Samsung}...");
        }

        public abstract void InstalarAplicativo(string What);
    }
}
}
   