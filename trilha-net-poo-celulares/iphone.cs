// Models/Iphone.cs
using TrilhasPOO.Models.Interfaces;

namespace TrilhasPOO.Models;

public class Iphone : Smartphone, IReprodutorMusical, IAparelhoTelefonico, INavegadorInternet
{
    public Iphone(string numero, string imei, int memoria)
        : base(numero, "iPhone", imei, memoria) { }

    // IAparelhoTelefonico
    public void Ligar(string numero) =>
        Console.WriteLine("[iPhone] Chamando via FaceTime (áudio) para " + numero);

    public void Atender() =>
        Console.WriteLine("[iPhone] Atendendo com gesto deslizante...");

    public void IniciarCorreioVoz() =>
        Console.WriteLine("[iPhone] Correio de voz visual iniciado.");

    // IReprodutorMusical
    public void Tocar() => Console.WriteLine("[iPhone] Música tocando no Apple Music.");
    public void Pausar() => Console.WriteLine("[iPhone] Música pausada.");
    public void SelecionarMusica(string musica) =>
        Console.WriteLine($"[iPhone] Selecionada: {musica}");

    // INavegadorInternet
    public void ExibirPagina(string url) =>
        Console.WriteLine("[iPhone] Safari abrindo: " + url);

    public void AdicionarNovaAba() =>
        Console.WriteLine("[iPhone] Nova aba no Safari.");

    public void AtualizarPagina() =>
        Console.WriteLine("[iPhone] Atualizando página no Safari.");
}
