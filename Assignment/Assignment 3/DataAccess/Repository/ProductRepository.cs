using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(int id) => ProductDAO.Instance.RemoveProduct(id);

        public Product GetProduct(int id) => ProductDAO.Instance.GetProduct(id);

        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProducts();

        public void InsertProduct(Product member) => ProductDAO.Instance.InsertProduct(member);

        public void UpdateProduct(Product member) => ProductDAO.Instance.UpdateProduct(member);
    }
}
