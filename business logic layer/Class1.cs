using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using data__access_layer;
using entity_classes;
namespace business_logic_layer
{
    public class BLL
    {
        DAL ob = null;
        public BLL(string s)
        {
            ob = new DAL(s);
        }
        public SqlDataReader show(string pro_nAME)
        {
            SqlCommand cmd = ob.create();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cmd.Connection.Open();
            cmd.CommandText = pro_nAME;
            return ob.read(cmd);
        }
        public SqlDataReader search(string pro_nAME, int id)
        {
            SqlCommand cmd = ob.create();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cmd.Connection.Open();
            cmd.CommandText = pro_nAME;
            cmd.Parameters.AddWithValue("@id", id);
            return ob.read(cmd);
        }
        public void add(string proc, Entity emp)
        {
            SqlCommand cmd = ob.create();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cmd.Connection.Open();
            cmd.CommandText = proc;
            cmd.Parameters.AddWithValue("@name", emp.name);
            cmd.Parameters.AddWithValue("@dob", emp.dob);
            ob.execute(cmd);
        }
        public void delete(string proc,int id)
        {
            SqlCommand cmd = ob.create();
            if(cmd.Connection.State==ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cmd.Connection.Open();
            cmd.CommandText = proc;
            cmd.Parameters.AddWithValue("@id", id);
            ob.execute(cmd);
        }
        public void update(string proc, int id,string name,string dob)
        {
            SqlCommand cmd = ob.create();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cmd.Connection.Open();
            cmd.CommandText = proc;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@dob", dob);
            ob.execute(cmd);
        }

    }
}
