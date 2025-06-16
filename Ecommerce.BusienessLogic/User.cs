using System.Data;
using Ecommerce.DataAcess;

namespace Ecommerce.BusienessLogic
{

    public class User
    {
        DbContext context;
        public User(string connection)
        {
            context = new DbContext(connection);
        }


        public bool GetUserLogin(string username, string password)
        {

            string query = $"select UserName , Password from UserLoginInfo where UserName = '{username}' and Password = '{password}'";
            DataTable dt = context.ExcuteQuery(query);
            return dt.Rows.Count > 0;
        }

        public bool GetAdminLogin(string username, string password)
        {
            string query = $"select UserName , Password from AdminLoginInfo where UserName = '{username}' and Password = '{password}'";
            DataTable dt = context.ExcuteQuery(query);
            return dt.Rows.Count > 0;
        }
        public int AddUser(string usernName, string password, string email, int age, string address)
        {
            string query = $"insert into Users (UserName , Age , Password , Address , Email , Role) values('{usernName}', {age} ,'{password}' , '{address}' , '{email}' , 'User')";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }

        public DataTable GetAutUser(string username, string password)
        {

            string query = $"select * from Users where UserName = '{username}' and Password = '{password}'";
            DataTable dt = context.ExcuteQuery(query);
            return dt;
        }
        public DataTable SelectedUserById(int id)
        {
            string query = $"select * from Users where UserId = {id}";
            DataTable dt = context.ExcuteQuery(query);
            return dt;
        }

        public int updateUserProfile(int id, string userName, int age, string email, string address)
        {
            string query = $"update Users set UserName = '{userName}' , Age = {age} , Email = '{email}' , Address = '{address}' where UserId = {id}";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }
        public int updatePasswordForThisUser(int id, string password)
        {
            string query = $"update users set password = '{password}' where userId = {id}";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }

        public DataTable GetAllUser()
        {
            string query = "Select * from Users";
            DataTable dt = context.ExcuteQuery(query);
            return dt;
        }

        public DataTable GetAdminOrUser()
        {
            string query = "SELECT DISTINCT Role FROM Users WHERE Role IN ('Admin', 'User')";
            DataTable dt = context.ExcuteQuery(query);
            return dt;
        }
        public int AddNewUser(string userName, int age, string address, string role, string email, string password)
        {
            string query = $"insert into Users (UserName , Age ,Address ,Role ,Email , Password) values('{userName}' , {age} ,'{address}' ,'{role}','{email}' , '{password}')";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }
        public int updateUserRole(int id, string role)
        {
            string query = $"update User set role = '{role}' where userId = {id} ";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }

        public DataTable getUserById(int id)
        {
            string query = $"select * from Users where UserId = {id}";
            DataTable dt = context.ExcuteQuery(query);
            return dt;
        }
        public int UpdateRoleOfUserByAdmin(int id, string role)
        {
            string query = $"update Users set Role = '{role}' where userId = {id}";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }
        public int deleteUserByAdmin(int id)
        {
            string query = $"delete from Users where UserId = {id}";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }
    }
}
