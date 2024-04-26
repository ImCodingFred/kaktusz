using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace kaktuszGUI
{
    internal class db
    {
        string server = "SERVER=linsql.verebely.dc;DATABASE=diak36;UID=diak36;PASSWORD=BXGERT;";
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public MySqlDataReader Dr { get => dr; set => dr = value; }

        public db(string query) 
        {
            con = new MySqlConnection(server);
            cmd = new MySqlCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
        }
        ~db() 
        {
            con.Close();
        }
        public void close() 
        {
            con.Close();
        }
    }
}
