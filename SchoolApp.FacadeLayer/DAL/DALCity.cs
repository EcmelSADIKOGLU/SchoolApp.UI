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
    public class DALCity
    {
        public static List<City> DALCityList()
        {
            DbConnection.connection.Open();

            List<City> cities = new List<City>();
            SqlCommand cmd = new SqlCommand("select * from tblCity",DbConnection.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                City city = new City();
                city.CityID = Convert.ToByte(reader["CityID"]);
                city.CityName = reader["CityName"].ToString();
                cities.Add(city);
            }reader.Close();

            DbConnection.connection.Close();

            return cities;
        }
        
        
    }
}
