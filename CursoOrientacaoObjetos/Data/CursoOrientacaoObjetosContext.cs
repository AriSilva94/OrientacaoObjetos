using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CursoOrientacaoObjetos.Models;

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
