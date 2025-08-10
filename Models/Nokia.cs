using System.Runtime.CompilerServices;

namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, double versao, string familia, long imei, int tamanho, string tipo) 
            : base(numero, versao, familia, imei, tamanho, tipo)
        {
        }

        //Sobrescrevendo o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia...");
        }
    }
}