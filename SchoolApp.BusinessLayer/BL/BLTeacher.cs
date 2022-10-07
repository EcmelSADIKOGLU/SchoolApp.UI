using SchoolApp.EntityLayer.Entities;
using SchoolApp.FacadeLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.BusinessLayer.BL
{
    public class BLTeacher
    {
        public static bool BLisTeacher(string UserName, string Password)
        {
            if (true)
            {
                return DALTeacher.DALisTeacher(UserName, Password);
            }
        }
        public static List<Teacher> BLTeacherList()
        {
            if (true)
            {
                return DALTeacher.DALTeacherList();
            }
            
        }
        public static void BLAddTeacher(Teacher teacher)
        {
            if (true)
            {
                DALTeacher.DALAddTeacher(teacher);
            }
        }
    }
}
