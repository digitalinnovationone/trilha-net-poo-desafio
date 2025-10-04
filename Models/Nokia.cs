namespace DesafioPOO.Models
{
    // Implementado!
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) 
        : base( numero,  modelo,  imei,  memoria)
        {
            
        }
        // Implementado!
        public override void InstalarAplicativo(string nomeApp)
        {

            Console.WriteLine($"Instalando {nomeApp}, na Windows Store.");
            
        }
    }
}