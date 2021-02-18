using Microsoft.EntityFrameworkCore;

namespace CursoOrientacaoObjetos.Data
{
    public class CursoOrientacaoObjetosContext : DbContext
    {
        public CursoOrientacaoObjetosContext (DbContextOptions<CursoOrientacaoObjetosContext> options)
            : base(options)
        {
        }

        public DbSet<CursoOrientacaoObjetos.Models.Department> Department { get; set; }
    }
}
