using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ManageCategoriesApp
{
    public record Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }

    public class ManageCategories
    {
        SqlConnection connection;
        SqlCommand command;
        string ConnectionString = "Server=(local);uid=sa;pwd=Yotsugi123;database=MyStore;Encrypt=False";

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            connection = new SqlConnection(ConnectionString);
            string sql = "Select CategoryID, CategoryName From Categories";
            command = new SqlCommand(sql, connection);

            try
            {
                connection.Open();
                SqlDataReader sqlDataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        categories.Add(new Category
                        {
                            CategoryID = sqlDataReader.GetInt32("CategoryID"),
                            CategoryName = sqlDataReader.GetString("CategoryName")
                        });
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return categories;
        }

        public void InsertCategory(Category category)
        {
            connection = new SqlConnection(ConnectionString);
            command = new SqlCommand("Insert Categories values(@CategoryName)", connection);
            command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateCategory(Category category)
        {
            connection = new SqlConnection(ConnectionString);
            command = new SqlCommand("Update Categories Set CategoryName=@CategoryName where CategoryID = @CategoryID", connection);
            command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            command.Parameters.AddWithValue("@CategoryID", category.CategoryID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteCategory(Category category)
        {
            connection = new SqlConnection(ConnectionString);
            command = new SqlCommand("Delete Categories where CategoryID = @CategoryID", connection);
            command.Parameters.AddWithValue("@CategoryID", category.CategoryID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
