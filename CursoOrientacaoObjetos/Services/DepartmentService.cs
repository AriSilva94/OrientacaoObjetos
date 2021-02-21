using CursoOrientacaoObjetos.Data;
using CursoOrientacaoObjetos.Models;
using System.Collections.Generic;
using System.Linq;

namespace CursoOrientacaoObjetos.Services
{
    public class DepartmentService
    {
        private readonly CursoOrientacaoObjetosContext _context;

        public DepartmentService(CursoOrientacaoObjetosContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(d => d.Name).ToList();
        }
    }
}
