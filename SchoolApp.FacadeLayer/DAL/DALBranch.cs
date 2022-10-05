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
    public class DALBranch
    {
        public static List<Branch> BranchList()
        {
            DbConnection.connection.Open();

            List<Branch> branches = new List<Branch>();

            SqlCommand cmd = new SqlCommand("Select * from tblBranch", DbConnection.connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Branch branch = new Branch();
                branch.BranchID = Convert.ToByte(reader["BranchID"]);
                branch.BranchName = reader["BranchName"].ToString();
                branches.Add(branch);

            }

            DbConnection.connection.Close();

            return branches;
        }
        public static void AddBranch(string BranchName)
        {
            DbConnection.connection.Open();

            SqlCommand cmd = new SqlCommand("insert into tblBranch (BranchName) values (@p1)", DbConnection.connection);
            cmd.Parameters.AddWithValue("@p1", BranchName);
            cmd.ExecuteNonQuery();
            DbConnection.connection.Close();
        }
        public static void DeleteBranch(int id)
        {
            DbConnection.connection.Open();

            SqlCommand cmd = new SqlCommand("delete from tblBranch where BranchID = @p1", DbConnection.connection);
            cmd.Parameters.AddWithValue("@p1", id);
            cmd.ExecuteNonQuery();

            DbConnection.connection.Close();
        }
        public static void UpdateBranch(Branch branch)
        {
            DbConnection.connection.Open();

            SqlCommand cmd = new SqlCommand("Update tblBranch set BranchName = @p1 where BranchID = @p2", DbConnection.connection);
            cmd.Parameters.AddWithValue("@p1", branch.BranchName);
            cmd.Parameters.AddWithValue("@p2", branch.BranchID);
            cmd.ExecuteNonQuery();

            DbConnection.connection.Close();


        }
    }
}
