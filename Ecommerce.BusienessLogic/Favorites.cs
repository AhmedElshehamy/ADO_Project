using System.Data;
using Ecommerce.DataAcess;


namespace Ecommerce.BusienessLogic
{
    public class Favorites
    {
        DbContext context;

        public Favorites(string connection)
        {
            context = new DbContext(connection);
        }

        public int AddProductToFavorite(int userId, int productId)
        {
            string query = $"insert into Favorites (UserId , ProductId) values ({userId} , {productId})";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }

        public DataTable getFavProduct(int id)
        {
            string query = $"select username , ProductName from Favorites f inner join Users u on f.UserId = u.UserId inner join Products  p on f.ProductId = p.ProductId  where u.UserId = {id}";
            DataTable dt = context.ExcuteQuery(query);
            return dt;
        }

        public int getFavProductByName(string productName)
        {
            string query = $"SELECT ProductId FROM Products WHERE ProductName = '{productName}'";
            DataTable dt = context.ExcuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["ProductId"]);
            }
            return 0;
        }

        public int removeProductFromFav(int userrId, int productId)
        {
            string query = $"delete from Favorites where UserId = {userrId} and ProductId = {productId}";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }
    }
}
