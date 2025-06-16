using System.Data;
using Ecommerce.DataAcess;

namespace Ecommerce.BusienessLogic
{
    public class Category
    {
        DbContext context;
        public Category(string connection)
        {
            context = new DbContext(connection);
        }

        public DataTable GetDataCategory()
        {
            string query = "select * from Categories";
            DataTable dt = context.ExcuteQuery(query);
            return dt;
        }
        public int AddCategoryByAdmin(string categoryName)
        {
            string query = $"insert into Categories (CategoryName) values ('{categoryName}')";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }

        public int EditCategoryByAdmin(int id, string categoryName)
        {
            string query = $"update  Categories set CategoryName = '{categoryName}' where CategoryId = {id}";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }

        public int DeleteCategoryByAdmin(int id)
        {
            string query = $"Delete  Categories where CategoryId = {id}";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }
    }
}
