using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        // Propriedades faltantes do diagrama
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        // Construtor
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Métodos concretos
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
