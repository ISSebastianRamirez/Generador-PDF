using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GenPDFItext.Models
{
    public class BDConexion
    {
       public static string conex = @"Data Source=SEBASTIAN; Initial Catalog=PDF; User ID=sa; Password=123";

        public SqlConnection conexion = new SqlConnection(conex);
        
    }
}