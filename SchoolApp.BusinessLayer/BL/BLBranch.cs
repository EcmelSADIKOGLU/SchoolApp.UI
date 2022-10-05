using SchoolApp.EntityLayer.Entities;
using SchoolApp.FacadeLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.BusinessLayer.BL
{
    public class BLBranch
    {
        public static List<Branch> BLBranchList()
        {
            //yetkisi var mı?
            return DALBranch.BranchList();
        }

        public static void BLAddBranch(String BranchName)
        {
            if(BranchName.Length<=20 && BranchName.Trim() != "")
            {
                DALBranch.AddBranch(BranchName);
            }
            else
            {
                //hata mesajları
            }
        }

        public static void BLDeleteBranch(int id)
        {
            if (true)
            {
                DALBranch.DeleteBranch(id);
            }
            else
            {
                //hata mesajları
            }
        }

        public static void BLUpdateBranch(Branch branch)
        {
            if (true)
            {
                DALBranch.UpdateBranch(branch);
            }
            else
            {
                //hata mesajları
            }

        }
    }
}
