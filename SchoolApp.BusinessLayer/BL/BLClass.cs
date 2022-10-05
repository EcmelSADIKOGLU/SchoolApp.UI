using SchoolApp.EntityLayer.Entities;
using SchoolApp.FacadeLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.BusinessLayer.BL
{
    public class BLClass
    {
        public static List<Class> BLClassList()
        {
            return DALClass.DALClassList();
        }
        public static void BLAddClass(string ClassName)
        {
            DALClass.DALAddClass(ClassName);
        }
        public static void BLDeleteClass(int id)
        {
            DALClass.DALDeleteClass(id);
        }
        public static void BLUpdateClass(Class cls)
        {
            DALClass.DALUpdateClass(cls);
        }
    }
}
