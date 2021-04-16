using System;
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
        public String[] MaxMinValue(String column, String column2, String valueC2)
        {
            String[] result = new string[3];
            List<String> names = new List<string>();
            foreach(DataRow row in DT.Rows)
            {
                if (row[column] != DBNull.Value && row[column2].ToString()==valueC2)
                    names.Add(row[column].ToString());
            }
            int max = 0;
            int min = 100000;
            foreach (string value in names)
            {
                if(int.Parse(value) > max)
                {
                    max = int.Parse(value);
                }
                if (int.Parse(value) < min)
                {
                    min = int.Parse(value);
                }
            }
            result[0] = valueC2;
            result[1] = min.ToString();
            result[2] = max.ToString();
            return result;
        }
        public List<double[]> CreateIntervalsClockSpeed()
        {
            double[] interval1 = { 0.5, 1.0, 0 }; double[] interval2 = { 1.0, 1.5, 0 };
            double[] interval3 = { 1.5, 2.0, 0 }; double[] interval4 = { 2.0, 2.5, 0 };
            double[] interval5 = { 2.5, 3.0, 0 };
            foreach (DataRow row in DT.Rows)
            {
                if (row[CS] != DBNull.Value)
                {
                    double value = Convert.ToDouble(row[CS]);
                    if (value >= interval1[0] && value < interval1[1])
                        interval1[2]++;
                    else if (value >= interval2[0] && value < interval2[1])
                        interval2[2]++;
                    else if (value >= interval3[0] && value < interval3[1])
                        interval3[2]++;
                    else if (value >= interval4[0] && value < interval4[1])
                        interval4[2]++;
                    else if (value >= interval5[0] && value <= interval5[1])
                        interval5[2]++;
                } 
            }
            List<double[]> intervals = new List<double[]>();
            intervals.Add(interval1);
            intervals.Add(interval2);
            intervals.Add(interval3);
            intervals.Add(interval4);
            intervals.Add(interval5);
            return intervals;
        }

        public DataTable GetDT => DT;
    }
}
