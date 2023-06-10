using GerenciadorNegocios.Context;
using GerenciadorNegocios.Models;
using GerenciadorNegocios.Repositories.Interfaces;

namespace GerenciadorNegocios.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext dbContext)
        {
            _context= dbContext;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
