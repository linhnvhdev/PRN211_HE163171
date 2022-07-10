using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(ProductObject product) => ProductDAO.Instance.AddNew(product);

        public void DeleteProduct(int productId) => ProductDAO.Instance.Remove(productId);

        public IEnumerable<ProductObject> GetAllProducts() => ProductDAO.Instance.GetProductList();

        public ProductObject GetProduct(int id) => ProductDAO.Instance.GetproductByID(id);

        public void UpdateProduct(ProductObject product) => ProductDAO.Instance.Update(product);
    }
}
