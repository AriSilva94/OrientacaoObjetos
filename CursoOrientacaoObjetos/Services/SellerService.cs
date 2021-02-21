using CursoOrientacaoObjetos.Data;
using CursoOrientacaoObjetos.Models;
using System.Collections.Generic;
using System.Linq;

namespace CursoOrientacaoObjetos.Services
{
    public class SellerService
    {
        private readonly CursoOrientacaoObjetosContext _context;

        public SellerService(CursoOrientacaoObjetosContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Seller.Add(seller);

            _context.SaveChanges();
        }
    }
}
