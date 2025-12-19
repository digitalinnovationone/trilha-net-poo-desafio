using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Nokia usa sua loja; chama a implementação base para efetivar a instalação
        public override void InstalarAplicativo(string nomeApp)
        {
            const int tamanhoPadraoMb = 10;
            if (InstalarAplicativoBase(nomeApp, tamanhoPadraoMb))
            {
                Console.WriteLine($"Instalando {nomeApp} pela loja do Android...");
            }
            else
            {
                Console.WriteLine($"Não foi possível instalar {nomeApp} no Nokia (memória insuficiente ou já instalado).");
            }
        }
    }
}