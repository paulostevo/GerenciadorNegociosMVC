using GerenciadorNegocios.Models;

namespace GerenciadorNegocios.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
