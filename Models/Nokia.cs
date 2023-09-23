using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero)
        {
            // Inicializar propriedades específicas de Nokia, se necessário
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na Nokia...");
            // Implementação específica para a instalação de aplicativos em um Nokia
        }
    }
}
