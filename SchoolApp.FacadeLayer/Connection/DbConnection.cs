using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.FacadeLayer.Connection
{
    public class DbConnection
    {
        public static SqlConnection connection = new SqlConnection("Data source = DESKTOP-7P3FIAH; initial catalog = dbSchool; integrated Security = true;");
    }
}
