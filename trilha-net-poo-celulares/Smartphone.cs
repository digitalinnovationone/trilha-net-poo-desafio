// Models/Smartphone.cs
namespace TrilhasPOO.Models;

public abstract class Smartphone
{
    public string Numero { get; set; }
    public string Modelo { get; }
    public string IMEI { get; }
    public int Memoria { get; } // em GB

    protected Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }

    public virtual void LigarAparelho() =>
        Console.WriteLine($"[{Modelo}] Iniciando...");

    public virtual void DesligarAparelho() =>
        Console.WriteLine($"[{Modelo}] Desligando...");

    public virtual void ReceberLigacao() =>
        Console.WriteLine($"[{Modelo}] Recebendo ligação em {Numero}...");
}
