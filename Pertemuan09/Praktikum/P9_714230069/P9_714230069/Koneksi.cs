using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace P9_714230069
{
    internal class Koneksi    
    {
        string conectionstring = "Server=localhost;Database=pemrog2ulbi;Uid=root;Pwd=";
        MySqlConnection kon;

        public void OpenConnection()
        {
            kon = new MySqlConnection(conectionstring);
            kon.Open();
        }
        public void CloseConnection() 
        {
            kon.Close();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, kon);
            command.ExecuteNonQuery();
        }

        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conectionstring);   
            DataSet data = new DataSet();

            adapter.Fill(data);
            Object datatable = data.Tables[0];
            return datatable;
        }
    }
}
