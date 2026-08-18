namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Console.WriteLine($"Seu número é: {numero}, o modelo do seu celular é: {modelo}, o imei do seu celular é: {imei}, e memoria do seu celular é: {memoria}");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o App no Nokia {nomeApp}");
        }
        
    }
}