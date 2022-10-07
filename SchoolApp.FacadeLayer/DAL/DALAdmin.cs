using SchoolApp.EntityLayer.Entities;
using SchoolApp.FacadeLayer.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.FacadeLayer.DAL
{
    public class DALAdmin
    {
        public static bool DALisAdmin(string UserName, string Password)
        {
            bool isAdmin = false;
            DbConnection.connection.Open();
            SqlCommand cmd = new SqlCommand("select * from tblAdmin where AdminUserName = @p1 and AdminPassword =  @p2", DbConnection.connection);
            cmd.Parameters.AddWithValue("@p1", UserName);
            cmd.Parameters.AddWithValue("@p2", Password);
            SqlDataReader reader = cmd.ExecuteReader();
            isAdmin = reader.HasRows;
            DbConnection.connection.Close();
            return isAdmin;
        }
        public static Admin DALGetAdmin(string UserName)
        {
            Admin admin = new Admin();
            DbConnection.connection.Open();
            SqlCommand cmd = new SqlCommand("select * from tblAdmin where AdminUserName = @p1",DbConnection.connection); 
            cmd.Parameters.AddWithValue("@p1", UserName);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Admin adminn = new Admin();
                adminn.AdminUserName = reader["AdminUserName"].ToString();
                adminn.AdminName = reader["AdminName"].ToString();
                adminn.AdminSurname = reader["AdminSurname"].ToString();
                admin = adminn;
            }
    
            DbConnection.connection.Close();

            return admin;
        }

        
    }
}
