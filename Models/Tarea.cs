using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoef.Models;

public class Tarea
{
    [Key]
    public Guid Id { get; set; }  
    [ForeignKey("CategoriaId")]  

    [Required]
    [MaxLength(200)]
    public Guid CategoriaId { get; set; }

    public string Descripcion { get; set;}

    public Prioridad prioridadTarea { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual Categoria Categoria { get; set; }

    [NotMapped]
    public string Resumen { get; set; }

}

public enum Prioridad
{
    Baja,
    Media,
    Alta
}