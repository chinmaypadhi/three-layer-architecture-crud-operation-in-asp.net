using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace data__access_layer
{
   
    public class DAL
    {
        SqlConnection con=null;
        public DAL (string s)
        {
            con = new SqlConnection(s);
        }

        public SqlCommand create()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public SqlDataReader read(SqlCommand cmd)
        {
            return cmd.ExecuteReader();
        }

        public int execute(SqlCommand cmd)
        {
            return cmd.ExecuteNonQuery();
        }

        public object scaller(SqlCommand cmd)
        {
            return cmd.ExecuteScalar();
        }
    }
}
