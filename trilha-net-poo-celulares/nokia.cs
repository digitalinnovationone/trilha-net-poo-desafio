// Models/Nokia.cs
using TrilhasPOO.Models.Interfaces;

namespace TrilhasPOO.Models;

public class Nokia : Smartphone, IReprodutorMusical, IAparelhoTelefonico, INavegadorInternet
{
    public Nokia(string numero, string imei, int memoria)
        : base(numero, "Nokia", imei, memoria) { }

    public void Ligar(string numero) =>
        Console.WriteLine("[Nokia] Ligando para " + numero + " via discador clássico...");

    public void Atender() => Console.WriteLine("[Nokia] Atendido (tecla verde).");

    public void IniciarCorreioVoz() =>
        Console.WriteLine("[Nokia] Correio de voz iniciado (voz).");

    public void Tocar() => Console.WriteLine("[Nokia] Tocando no player nativo.");
    public void Pausar() => Console.WriteLine("[Nokia] Música pausada.");
    public void SelecionarMusica(string musica) =>
        Console.WriteLine($"[Nokia] Música selecionada: {musica}");

    public void ExibirPagina(string url) =>
        Console.WriteLine("[Nokia] Navegador padrão abrindo: " + url);

    public void AdicionarNovaAba() =>
        Console.WriteLine("[Nokia] Nova aba adicionada.");

    public void AtualizarPagina() =>
        Console.WriteLine("[Nokia] Página atualizada.");
}
