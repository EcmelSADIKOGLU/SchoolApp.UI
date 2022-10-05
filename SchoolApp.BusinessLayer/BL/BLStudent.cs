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
            return DALStudent.DALStudentList();
        }
        public static List<Student> BLStudentListByClass(string Class)
        {
            return DALStudent.DALStudentListByClass(Class);
        }
        public static List<Student> BLStudentListAll()
        {
            return DALStudent.DALStudentListAll();
        }
        public static void BLAddStudent(Student student)
        {
            DALStudent.DALAddStudent(student);
        }
    }
}
