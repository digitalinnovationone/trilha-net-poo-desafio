using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // TODO: Adicionar lógica específica do construtor da classe Iphone, se necessário
        }

        // Sobrescrever o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone...");
            // TODO: Adicionar a lógica de instalação específica para o iPhone
        }
    }
}
