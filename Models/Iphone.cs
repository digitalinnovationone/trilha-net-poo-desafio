using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // iPhone usa a App Store; chama a implementação base para efetivar a instalação
        public override void InstalarAplicativo(string nomeApp)
        {
            // supondo apps do iPhone possam ser um pouco maiores por padrão
            const int tamanhoPadraoMb = 15;
            if (InstalarAplicativoBase(nomeApp, tamanhoPadraoMb))
            {
                Console.WriteLine($"Instalando {nomeApp} pela App Store...");
            }
            else
            {
                Console.WriteLine($"Não foi possível instalar {nomeApp} no iPhone (memória insuficiente ou já instalado).");
            }
        }
    }
}