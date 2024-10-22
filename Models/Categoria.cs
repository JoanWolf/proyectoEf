using System.ComponentModel.DataAnnotations;

namespace proyectoef.Models;

public class Categoria
{
    [Key]
    public Guid Id { get; set; }

    [Required] // Pone como regla que sea u natributo requerido
    [MaxLength(150)] // Pone como regla que pueda usar maximo 150 caracteres
    public string Nombre{ get; set; }
    public string Descripcion { get; set; }
    public virtual ICollection<Tarea> Tareas { get; set; }
}