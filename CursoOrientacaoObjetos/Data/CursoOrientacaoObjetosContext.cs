using CursoOrientacaoObjetos.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoOrientacaoObjetos.Data
{
    public class CursoOrientacaoObjetosContext : DbContext
    {
        public CursoOrientacaoObjetosContext (DbContextOptions<CursoOrientacaoObjetosContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }
    }
}
