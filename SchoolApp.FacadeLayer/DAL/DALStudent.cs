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
    public class DALStudent
    {
        public static List<Student> DALStudentList()
        {
            DbConnection.connection.Open();
            List<Student> students = new List<Student>();
            SqlCommand cmd = new SqlCommand("select StudentUserName , StudentName , StudentSurname , ClassName from tblStudent inner join tblClass on tblStudent.StudentClass = tblClass.ClassID", DbConnection.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student student = new Student();
                student.StudentUserName = reader["StudentUserName"].ToString();
                student.StudentName = reader["StudentName"].ToString();
                student.StudentSurname = reader["StudentSurname"].ToString();
                student.StudentClass = reader["ClassName"].ToString();
                students.Add(student);

            }
            DbConnection.connection.Close();
            return students;
        }
        public static List<Student> DALStudentListByClass(string Class)
        {
            DbConnection.connection.Open();
            List<Student> students = new List<Student>();
            SqlCommand cmd = new SqlCommand("select StudentUserName , StudentName , StudentSurname , ClassName from tblStudent inner join tblClass on tblStudent.StudentClass = tblClass.ClassID where ClassName = @p1", DbConnection.connection);
            cmd.Parameters.AddWithValue("@p1", Class);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student student = new Student();
                student.StudentUserName = reader["StudentUserName"].ToString();
                student.StudentName = reader["StudentName"].ToString();
                student.StudentSurname = reader["StudentSurname"].ToString();
                student.StudentClass = reader["ClassName"].ToString();
                students.Add(student);

            }
            DbConnection.connection.Close();
            return students;
        }

        public static List<Student> DALStudentListAll()
        {
            DbConnection.connection.Open();
            List<Student> students = new List<Student>();
            SqlCommand cmd = new SqlCommand("select StudentUserName , StudentName , StudentSurname , ClassName, CityName, StudentMail from tblStudent inner join tblClass on tblStudent.StudentClass = tblClass.ClassID inner join tblCity on tblStudent.StudentCity = tblCity.CityID", DbConnection.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student student = new Student();
                student.StudentUserName = reader["StudentUserName"].ToString();
                student.StudentName = reader["StudentName"].ToString();
                student.StudentSurname = reader["StudentSurname"].ToString();
                student.StudentClass = reader["ClassName"].ToString();
                student.StudentCity = reader["CityName"].ToString();
                student.StudentMail = reader["StudentMail"].ToString();

                students.Add(student);

            }
            DbConnection.connection.Close();
            return students;
        }
        public static void DALAddStudent(Student student)
        {
            Random random = new Random();
            string UserName = "S";
            for (int i = 0; i < 7; i++)
            {
                UserName += random.Next(0, 10);
            }

            DbConnection.connection.Open();
            SqlCommand cmd = new SqlCommand("insert into tblStudent (StudentName,StudentSurname,StudentUserName,StudentClass) values (@p1,@p2,@p3,@p4)", DbConnection.connection);
            cmd.Parameters.AddWithValue("@p1", student.StudentName);
            cmd.Parameters.AddWithValue("@p2", student.StudentSurname);
            cmd.Parameters.AddWithValue("@p3", UserName);
            cmd.Parameters.AddWithValue("@p4", student.StudentClass);
            DbConnection.connection.Close();
        }
    }
}
