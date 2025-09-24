namespace DesafioPOO.Models
{
	public class Iphone : Smartphone
	{
		public Iphone(int numero, string modelo, string cor, int tamanho) : base(numero, modelo, cor, tamanho)
		{
		}

		public override void InstalarAplicativo(string nomeApp)
		{
			Console.WriteLine($"Instalado o aplicativo \"{nomeApp}\" no IPhone");
		}
	}
}