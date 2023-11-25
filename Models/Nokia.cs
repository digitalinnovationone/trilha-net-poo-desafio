using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // TODO: Adicionar lógica específica do construtor da classe Nokia, se necessário
        }

        // Sobrescrever o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");
            // TODO: Adicionar a lógica de instalação específica para a Nokia
        }
    }
}