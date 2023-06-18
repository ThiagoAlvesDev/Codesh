using MongoDB.Driver;
using ProjetoCodesh.Data.Configurations;
using ProjetoCodesh.Models;
using System.Collections.Generic;

namespace ProjetoCodesh.Data.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly IMongoCollection<Product> _Products;

        public ProductsRepository(IDatabaseConfig databaseConfig)
        {
            var client = new MongoClient(databaseConfig.ConnectionString);
            var database = client.GetDatabase(databaseConfig.DatabaseName);

            _Products = database.GetCollection<Product>("products");
        }
        public void Adicionar(Product product)
        {
            _Products.InsertOne(product);
            
        }

        public void Atualizar(long code, Product productUpdate)
        {
            _Products.ReplaceOne(x => x.Code == code, productUpdate);
        }

        public IEnumerable<Product> Buscar()
        {
            return _Products.Find(x => true).ToList();
        }

        public Product Buscar(long code)
        {
            return _Products.Find(x => x.Code == code).FirstOrDefault();
        }

        public void Delete(long code)
        {
            _Products.DeleteOne(x => x.Code == code);
        }
    }
}
