using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            var Products = new List<Product>();
            try
            {
                using var context = new FStoreContext();
                Products = context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Products;
        }

        public Product GetProduct(int id)
        {
            Product product = null;
            try
            {
                using var context = new FStoreContext();
                product = context.Products.SingleOrDefault(m => m.ProductId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public void InsertProduct(Product product)
        {
            try
            {
                Product p = GetProduct(product.ProductId);
                if (p == null)
                {
                    using var context = new FStoreContext();
                    context.Products.Add(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                Product p = GetProduct(product.ProductId);
                if (p != null)
                {
                    using var context = new FStoreContext();
                    context.Products.Update(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveProduct(int id)
        {
            try
            {
                Product p = GetProduct(id);
                if (p != null)
                {
                    using var context = new FStoreContext();
                    context.Products.Remove(p);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
