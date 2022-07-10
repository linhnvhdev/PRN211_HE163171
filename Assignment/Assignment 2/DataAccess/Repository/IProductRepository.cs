using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<ProductObject> GetAllProducts();
        void AddProduct(ProductObject product);
        void UpdateProduct(ProductObject product);
        void DeleteProduct(int productId);
        ProductObject GetProduct(int id);
    }
}
