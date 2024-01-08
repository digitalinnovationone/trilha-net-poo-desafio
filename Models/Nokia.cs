namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia (string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
          {

          }
          public override void InstalarAplicativo(string nomeApp)
          {
            Console.WriteLine($"Instalando {nomeApp} no celular Numero {Numero}\n{Modelo}, {IMEI} e sua capacidade é de {Memoria} GB Mem.");
          }
            // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}