using SchoolApp.EntityLayer.Entities;
using SchoolApp.FacadeLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.BusinessLayer.BL
{
    public class BLAdmin
    {
        public static bool BLisAdmin(string UserName, string Password)
        {
            return DALAdmin.DALisAdmin(UserName, Password);
        }
        public static Admin BLGetAdmin(string UserName)
        {
            return DALAdmin.DALGetAdmin(UserName);
        }
    }
}
