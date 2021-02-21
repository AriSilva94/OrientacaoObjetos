using CursoOrientacaoObjetos.Data;
using CursoOrientacaoObjetos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoOrientacaoObjetos.Services
{
    public class DepartmentService
    {
        private readonly CursoOrientacaoObjetosContext _context;

        public DepartmentService(CursoOrientacaoObjetosContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(d => d.Name).ToListAsync();
        }
    }
}
