namespace Core.Interfaces;
public interface IUnitOfWork
{
    IPais Paises { get; }
    /* ITipoPersona TipoPersonas { get; } */
    Task<int> SaveAsync();
}