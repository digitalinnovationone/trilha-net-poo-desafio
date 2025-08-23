// Models/Interfaces/IAparelhoTelefonico.cs
namespace TrilhasPOO.Models.Interfaces;
public interface IAparelhoTelefonico
{
    void Ligar(string numero);
    void Atender();
    void IniciarCorreioVoz();
}
