using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedades da classe Smartphone
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }

        // Construtor da classe Smartphone
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        // Métodos da classe Smartphone
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato para instalar aplicativo
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
