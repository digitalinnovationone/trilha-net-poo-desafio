using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {
            // Inicializar propriedades específicas de iPhone, se necessário
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone...");
            // Implementação específica para a instalação de aplicativos em um iPhone
        }
    }
}
