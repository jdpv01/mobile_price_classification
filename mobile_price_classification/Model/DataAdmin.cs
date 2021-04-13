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
        private DataSet DS;

        public DataAdmin()
        {
        } 

        public DataView SetDataBaseConnection(string line)
        {
            String connection = string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Extended Properties = 'Excel 12.0;'", line);
            OleDbConnection connector = new OleDbConnection(connection);
            connector.Open();
            OleDbCommand query = new OleDbCommand("Select * from [Worksheet$]", connector);
            OleDbDataAdapter adapter = new OleDbDataAdapter
            {
                SelectCommand = query
            };
            DS = new DataSet();
            adapter.Fill(DS);
            connector.Close();
            return DS.Tables[0].DefaultView;
        }

        public DataSet GetDS => DS;
    }
}
