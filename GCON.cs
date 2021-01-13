using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace three_layer_architecture_in_asp.net
{
    public class GCON
    {
        public static string str;
        static GCON()
        {
            str = ConfigurationManager.ConnectionStrings["DBCS"].ToString();
        }
    }
}