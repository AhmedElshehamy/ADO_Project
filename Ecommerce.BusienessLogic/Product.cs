using System.Data;
using Ecommerce.DataAcess;

namespace Ecommerce.BusienessLogic
{

    public class Product
    {
        DbContext context;
        public Product(string connection)
        {
            context = new DbContext(connection);
        }

        // select

        public DataTable GetProductData()
        {
            string query = "select * from Products";
            DataTable dt = context.ExcuteQuery(query);
            return dt;
        }
        public DataTable GetProductToAddFav(int id)
        {
            string query = $"Select * from Products where ProductId = {id}";
            DataTable dt = context.ExcuteQuery(query);
            return dt;
        }

        // insert , update , delete ()

        public int AddProductByAdmin(string productName, int price, int categoryId)
        {
            string query = $"insert into Products (ProductName , Price , CategoryId ) values ('{productName}' , {price} , {categoryId})";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }

        public int updateProductByAdmin(int id, string productName, int price, int categoryId)
        {
            string query = $"update Products set ProductName = '{productName}' , Price = {price}  , CategoryId = {categoryId} where ProductId = {id}";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }
        public int deleteProductByAdmin(int id)
        {
            string query = $"delete from Products where ProductId = {id}";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }


    }
}
