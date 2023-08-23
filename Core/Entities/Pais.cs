namespace Core.Entities;
public class Pais
{
    public int Id { get; set; }
    public string NombrePais { get; set; }
    public ICollection<Estado> Estados { get; set; }
}