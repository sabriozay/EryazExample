using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DAL.Adonet
{
   public class Context
    {
        public static string Conn { get; set; }
        public Context()
        {
            //Conn = ConfigurationManager.ConnectionStrings["CalismaDbConnectionString"].ConnectionString;
        }
    }
}
