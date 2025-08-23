// Models/Samsung.cs
using TrilhasPOO.Models.Interfaces;

namespace TrilhasPOO.Models;

public class Samsung : Smartphone, IReprodutorMusical, IAparelhoTelefonico, INavegadorInternet
{
    public Samsung(string numero, string imei, int memoria)
        : base(numero, "Samsung", imei, memoria) { }

    public void Ligar(string numero) =>
        Console.WriteLine("[Samsung] Ligando via discador OneUI para " + numero);

    public void Atender() => Console.WriteLine("[Samsung] Atendido (gesto/tocar).");

    public void IniciarCorreioVoz() =>
        Console.WriteLine("[Samsung] Correio de voz - Caixa postal.");

    public void Tocar() => Console.WriteLine("[Samsung] Tocando no YouTube Music.");
    public void Pausar() => Console.WriteLine("[Samsung] Pausado.");
    public void SelecionarMusica(string musica) =>
        Console.WriteLine($"[Samsung] Tocando: {musica}");

    public void ExibirPagina(string url) =>
        Console.WriteLine("[Samsung] Abrindo no Samsung Internet: " + url);

    public void AdicionarNovaAba() =>
        Console.WriteLine("[Samsung] Nova aba aberta.");

    public void AtualizarPagina() =>
        Console.WriteLine("[Samsung] Atualizando página.");
}
