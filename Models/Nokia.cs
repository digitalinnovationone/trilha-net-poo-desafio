namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : 
        base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o {nomeApp} - Acesse a Play Store para baixar mais aplicativos do seu Nokia");
        }

    }
}