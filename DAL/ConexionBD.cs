using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConexionBD
    {
        public IDbConnection Cadena()
        {
            return new SqlConnection("Data Source=ALEAGUILON\\SQLEXPRESS; Initial Catalog=Proyecto; Persist Security Info=True; Encrypt=false; User ID=sa;Password=Guatemala2002");
        }
    }
}
