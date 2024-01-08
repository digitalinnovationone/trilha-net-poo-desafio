using System.Diagnostics;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no celular Numero {Numero}\n{Modelo}, {IMEI} e sua capacidade de memoria é de {Memoria} GB de Mem.");
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
    // TODO: Sobrescrever o método "InstalarAplicativo"
    
}