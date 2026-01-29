namespace DesafioPOO.Models

{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            if (nomeApp != null)
            {
                Console.WriteLine($"{nomeApp} foi instalado por completo");
                return;
            }
            throw new ArgumentException("Nenhum valor encontrado referente ao nome ");
        }
    }
}