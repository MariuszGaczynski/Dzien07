using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{ 
    static class GlobalData
    {
        public static MySqlConnection connection = null;



        public static DataTable DataTableFiller(string sql, string parameter)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string newSql;

            newSql = string.Format(sql, parameter);

            adapter.SelectCommand = new MySqlCommand(sql, GlobalData.connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        //MySqlDataAdapter adapter = new MySqlDataAdapter();
        //sql = string.Format(sql, CarId);
        //adapter.SelectCommand = new MySqlCommand(sql, GlobalData.connection);

        //DataTable dt = new DataTable();
        //adapter.Fill(dt);



    }
}
