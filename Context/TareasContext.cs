using Microsoft.EntityFrameworkCore;
using proyectoef.Models;

namespace proyectoef.Context;

public class TareasContext: DbContext
{
    public DbSet<Categoria> categorias { get; set; }
    public DbSet<Tarea> Tareas { get; set; }
    public TareasContext(DbContextOptions<TareasContext> options): base(options){}
}