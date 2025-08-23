// Models/Interfaces/IReprodutorMusical.cs
namespace TrilhasPOO.Models.Interfaces;
public interface IReprodutorMusical
{
    void Tocar();
    void Pausar();
    void SelecionarMusica(string musica);
}
