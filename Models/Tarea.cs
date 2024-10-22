namespace proyectoef.Models;

public class Tarea
{
    public Guid Id { get; set; }    
    public Guid CategoriaId { get; set; }
    public string Descripcion { get; set;}
    public Prioridad prioridadTarea { get; set; }
    public DateTime FechaCreacion { get; set; }
    public virtual Categoria Categoria { get; set; }

}

public enum Prioridad
{
    Baja,
    Media,
    Alta
}