using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile_price_classification.Model
{
    class DataAdmin
    {
        public const string BP = "battery_power", CS = "clock_speed", DSIM = "dual_sim",
            IM = "int_memory", NC = "n_cores", PH = "px_height", PW = "px_width", RAM = "ram",
            TS = "touch_screen", WF = "wifi", PR = "price_range";
        private DataSet DS;
        private OleDbConnection Connector;

        public DataAdmin() { } 

        public DataView SetDataBaseConnection(string line)
        {
            String connection = string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Extended Properties = 'Excel 12.0;'", line);
            Connector = new OleDbConnection(connection);
            Connector.Open();
            OleDbCommand query = new OleDbCommand("Select * from [Worksheet$]", Connector);
            OleDbDataAdapter adapter = new OleDbDataAdapter
            {
                SelectCommand = query
            };
            DS = new DataSet();
            adapter.Fill(DS);
            Connector.Close();
            return DS.Tables[0].DefaultView;
        }

        public void RestoreDataBase()
        {
            DataTable dt = DS.Tables[0];
            dt.DefaultView.RowFilter = string.Empty;
        }

        public void FilterByValue(String column, String value)
        {
            DataTable dt = DS.Tables[0];
            dt.DefaultView.RowFilter = column+" = "+value;
        }

        public void FilterByNumericRange(String column, Double lower, Double upper)
        {
            DataTable dt = DS.Tables[0];
            dt.DefaultView.RowFilter = column+ " >= "+lower+ " AND "+column+ " <= "+upper;
        }

        public DataSet GetDS => DS;
    }
}
