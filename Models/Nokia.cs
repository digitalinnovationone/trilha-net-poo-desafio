using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Construtor da classe filha
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrita do método abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no Nokia via loja oficial da Microsoft...");
        }
    }
}
