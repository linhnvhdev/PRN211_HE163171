using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class ProductDAO : BaseDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
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

        public IEnumerable<ProductObject> GetProductList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT [ProductId]" +
                               "   ,[CategoryId]" +
                               "   ,[ProductName]" +
                              "    ,[Weight]" +
                              "    ,[UnitPrice]" +
                              "    ,[UnitsInStock]" +
                              "FROM[dbo].[Product]";
            var products = new List<ProductObject>();
            try
            {
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        Id = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        Name = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return products;
        }

        public ProductObject GetproductByID(int productId)
        {
            IDataReader dataReader = null;
            ProductObject product = null;
            string SQLSelect = "SELECT [ProductId]" +
                               "   ,[CategoryId]" +
                               "   ,[ProductName]" +
                              "    ,[Weight]" +
                              "    ,[UnitPrice]" +
                              "    ,[UnitsInStock]" +
                              "FROM[dbo].[Product] WHERE [ProductId] = @ProductId";
            try
            {
                var param = DataProvider.CreateParameter("@ProductId", 4, productId, DbType.Int32);
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    product = new ProductObject
                    {
                        Id = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        Name = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return product;
        }

        public void AddNew(ProductObject product)
        {
            try
            {
                ProductObject pro = GetproductByID(product.Id);
                if (pro == null)
                {
                    string SQLInsert = "INSERT INTO [dbo].[Product]" +
                                       "        ([ProductId]" +
                                       "   ,[CategoryId]" +
                                        "   ,[ProductName]" +
                                        "    ,[Weight]" +
                                      "    ,[UnitPrice]" +
                                      "    ,[UnitsInStock]" +
                                       "  VALUES" +
                                       "        (@ProductId" +
                                       "        ,@CategoryId" +
                                       "        ,@ProductName" +
                                       "        ,@Weight" +
                                       "        ,@UnitPrice" +
                                       "        ,@UnitsInStock)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@ProductId", 4, product.Id, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@CategoryId", 4, product.CategoryId, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@ProductName", 40, product.Name, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Weight", 20, product.Weight, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@UnitPrice", 50, product.UnitPrice, DbType.Decimal));
                    parameters.Add(DataProvider.CreateParameter("@UnitsInStock", 4, product.UnitsInStock, DbType.Int32));
                    DataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The product is already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(ProductObject product)
        {
            try
            {
                ProductObject pro = GetproductByID(product.Id);
                if (pro != null)
                {
                    string SQLUpdate = "Update Product set CategoryId = @CategoryId,"
                                      + "ProductName = @ProductName, Weight = @Weight, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock "
                                      + " where ProductId = @ProductId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@ProductId", 4, product.Id, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@CategoryId", 4, product.CategoryId, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@ProductName", 40, product.Name, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Weight", 20, product.Weight, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@UnitPrice", 50, product.UnitPrice, DbType.Decimal));
                    parameters.Add(DataProvider.CreateParameter("@UnitsInStock", 4, product.UnitsInStock, DbType.Int32));
                    DataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The product does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Remove(int productId)
        {
            try
            {
                ProductObject pro = GetproductByID(productId);
                if (pro != null)
                {
                    string SQLDelete = "Delete Product where ProductId = @ProductId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@ProductId", 4, productId, DbType.Int32));
                    DataProvider.Delete(SQLDelete, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The product does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

        }
    }
}
