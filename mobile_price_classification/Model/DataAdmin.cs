using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace mobile_price_classification.Model
{
    public class DataAdmin
    {
        public const string BP = "battery_power", CS = "clock_speed", DSIM = "dual_sim",
            IM = "int_memory", NC = "n_cores", PH = "px_height", PW = "px_width", RAM = "ram",
            TS = "touch_screen", WF = "wifi", PR = "price_range";
        private DataTable DT;

        public DataAdmin() { } 

        public DataView SetDataBaseConnection(string line)
        {
            String connection = string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Extended Properties = 'Excel 12.0;'", line);
            OleDbConnection Connector = new OleDbConnection(connection);
            Connector.Open();
            OleDbCommand query = new OleDbCommand("Select * from [Worksheet$]", Connector);
            OleDbDataAdapter adapter = new OleDbDataAdapter
            {
                SelectCommand = query
            };
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Connector.Close();
            DT = ds.Tables[0];
            return ds.Tables[0].DefaultView;
        }

        public void RestoreDataBase()
        {
            DT.DefaultView.RowFilter = string.Empty;
        }

        public void FilterByValue(String column, String value)
        {
            DT.DefaultView.RowFilter = column+" = "+value;
        }

        public void FilterByNumericRange(String column, Double lower, Double upper)
        {
            DT.DefaultView.RowFilter = column+" >= "+lower+" AND "+column+" <= "+upper;
        }

        public IDictionary<string, int> CountRows(String column)
        {
            IDictionary<string, int> counts = new Dictionary<string, int>();
            List<String> names = new List<string>();
            foreach (DataRow row in DT.Rows)
            {
                if (row[column] != DBNull.Value)
                    names.Add(row[column].ToString());                
            }
            names.Sort();
            foreach (string value in names)
            {
                if (!counts.ContainsKey(value))
                    counts.Add(value, 1);
                else
                    counts[value]++;
            }
            return counts;
        }

        public DataTable GetDT => DT;
    }
}
