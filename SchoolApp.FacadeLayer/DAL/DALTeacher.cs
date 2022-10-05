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
    public class DALTeacher
    {
        public static List<Teacher> DALTeacherList()
        {
            List<Teacher> teachers = new List<Teacher>();
            SqlCommand cmd = new SqlCommand("select TeacherName, TeacherSurname, TeacherUserName, TeacherBranch, TeacherMainClass, TeacherMail from tblTeacher", DbConnection.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Teacher teacher = new Teacher();
                teacher.TeacherName = reader["TeacherName"].ToString();
                teacher.TeacherSurname = reader["TeacherSurname"].ToString();
                teacher.TeacherUserName = reader["TeacherUserName"].ToString();
                teacher.TeacherBranch = reader["TeacherBranch"].ToString();
                teacher.TeacherMainClass = reader["TeacherMainClass"].ToString();
                teacher.TeacherMail = reader["TeacherMail"].ToString();
                teachers.Add(teacher);
            }
            return teachers;
        }
        public static void DALAddTeacher(Teacher teacher)
        {
            Random random = new Random();
            string UserName = "T";
            for (int i = 0; i < 7; i++)
            {
                UserName += random.Next(0, 10);
            }

            DbConnection.connection.Open();
            SqlCommand cmd = new SqlCommand("insert into tblTeacher (TeacherName, TeacherSurname, TeacherUserName, TeacherBranch) values (@p1,@p2,@p3,@p4)", DbConnection.connection);

            cmd.Parameters.AddWithValue("@p1",teacher.TeacherName);
            cmd.Parameters.AddWithValue("@p2",teacher.TeacherSurname);
            cmd.Parameters.AddWithValue("@p3",UserName);
            cmd.Parameters.AddWithValue("@p4",teacher.TeacherBranch);

            DbConnection.connection.Close();
        }

    }
}
