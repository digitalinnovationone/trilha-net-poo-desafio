using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedade pública para o número
        public string Numero { get; set; }

        // Propriedades privadas, inicializadas via construtor
        private double Versao { get; }
        private string Familia { get; }
        private long IMEI { get; }
        private int Tamanho { get; }
        private string Tipo { get; }


        // Propriedade privada, impedindo para acesso em subclasses
        private string Modelo => $"{Familia} {Versao}";
        private string Memoria => $"{Tamanho} {Tipo}";

        // Construtor completo
        public Smartphone(string numero, double versao, string familia, long imei, int tamanho, string tipo)
        {
            Numero = numero;
            Versao = versao;
            Familia = familia;
            IMEI = imei;
            Tamanho = tamanho;
            Tipo = tipo;
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
        }

        // Métodos para mostrar informações

        public void MostrarModelo()
        {
            Console.WriteLine(Modelo);
        }

        public void MostrarIMEI()
        {
            Console.WriteLine($"IMEI: {IMEI}");
        }

        public void MostrarMemoria()
        {
            Console.WriteLine($"Memória: {Memoria}");
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato para ser implementado nas subclasses
        public abstract void InstalarAplicativo(string nomeApp);
    }
}