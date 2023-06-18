using ProjetoCodesh.Models;
using System.Collections.Generic;

namespace ProjetoCodesh.Data.Repositories
{
    public interface IProductsRepository
    {
        void Adicionar(Product product);

        void Atualizar(long code, Product productUpdate);

        IEnumerable<Product> Buscar();

        Product Buscar(long code);

        void Delete(long code);

    }
}
