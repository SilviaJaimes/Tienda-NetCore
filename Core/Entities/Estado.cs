namespace Core.Entities;
public class Estado
{
    public int Id { get; set; }
    public string NombreEstado { get; set; }
    public int IdPaisFk { get; set; }
    public Pais Pais { get; set; }
    public ICollection<Region> Regiones { get; set; }
}