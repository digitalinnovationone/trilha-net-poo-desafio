namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei,int memoria): base(numero,modelo,imei,memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp){
                Console.WriteLine($"{nomeApp} instalado no Iphone");
        }
    }
}