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
    public class DALClass
    {
        public static List<Class> DALClassList()
        {
            DbConnection.connection.Open();

            List<Class> classes = new List<Class>();

            SqlCommand cmd = new SqlCommand("select * from tblClass", DbConnection.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Class cls = new Class();
                cls.ClassID = Convert.ToByte(reader["ClassID"]);
                cls.ClassName = reader["ClassName"].ToString();
                classes.Add(cls);
            }

            DbConnection.connection.Close();
            return classes;
        }
        public static void DALAddClass(string ClassName)
        {
            DbConnection.connection.Open();

            SqlCommand cmd = new SqlCommand("insert into tblClass (ClassName) values (@p1)", DbConnection.connection);
            cmd.Parameters.AddWithValue("@p1", ClassName);
            cmd.ExecuteNonQuery();
            DbConnection.connection.Close();
        }
        public static void DALDeleteClass(int id)
        {
            DbConnection.connection.Open();

            SqlCommand cmd = new SqlCommand("delete from tblClass where ClassID = @p1", DbConnection.connection);
            cmd.Parameters.AddWithValue("@p1", id);
            cmd.ExecuteNonQuery();
            DbConnection.connection.Close();
        }
        public static void DALUpdateClass(Class cls)
        {
            DbConnection.connection.Open();

            SqlCommand cmd = new SqlCommand("update tblClass set ClassName = @p1 where ClassID = @p2", DbConnection.connection);
            cmd.Parameters.AddWithValue("@p1", cls.ClassName);
            cmd.Parameters.AddWithValue("@p2", cls.ClassID);
            cmd.ExecuteNonQuery();
            DbConnection.connection.Close();
        }
    }
}
