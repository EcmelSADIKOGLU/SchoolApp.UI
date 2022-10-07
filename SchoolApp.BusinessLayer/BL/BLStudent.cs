using SchoolApp.EntityLayer.Entities;
using SchoolApp.FacadeLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.BusinessLayer.BL
{
    public class BLStudent
    {
        public static List<Student> BLStudentList()
        {
            if (true)
            {
                return DALStudent.DALStudentList();
            }
            
        }
        public static List<Student> BLStudentListByClass(string Class)
        {
            if (true)
            {
                return DALStudent.DALStudentListByClass(Class);
            }
            
        }
        public static List<Student> BLStudentListAll()
        {
            if (true)
            {
                return DALStudent.DALStudentListAll();
            }
            
        }
        public static void BLAddStudent(Student student)
        {
            if (true)
            {
                DALStudent.DALAddStudent(student);
            }
            
        }
        public static Student BLGetStudentByUserName(string Username)
        {

            if (true)
            {
                return DALStudent.DALGetStudentByUserName(Username);
            }
            
        }
        public static void BLUpdateStudent(Student student)
        {
            if (true)
            {
                DALStudent.DALUpdateStudent(student);
            }
        }
        public static void BLDeleteStudent(string Username)
        {
            if (true)
            {
                DALStudent.DALDeleteStudent(Username);
            }
        }
    }
}
