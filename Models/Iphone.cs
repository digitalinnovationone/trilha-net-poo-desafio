namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
             Console.WriteLine($"Seu número é: {numero}, o modelo do seu celular é: {modelo}, o imei do seu celular é: {imei}, e memoria do seu celular é: {memoria}");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone");
        }
    }
}