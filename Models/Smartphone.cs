using System;

namespace Celulares
{
    // Classe abstrata
    public abstract class Smartphone
    {
        // Propriedades
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

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
            Console.WriteLine("Realizando ligação...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato
        public abstract void InstalarAplicativo(string nome);
    }
