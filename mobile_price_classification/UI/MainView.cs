using mobile_price_classification.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobile_price_classification
{
    public partial class MainView : Form
    {
        private readonly DataAdmin DM;

        public MainView()
        {
            InitializeComponent();
            DM = new DataAdmin();
        }

        private void Open(object sender, EventArgs e)
        {
            CBColumns.Items.Clear();
            ClearStuff();
            BTNRestore.Visible = true;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Excel | *.xls;*.xlsx;",
                Title = "Select File"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataGridView1.DataSource = DM.SetDataBaseConnection(ofd.FileName);
            }

            DataTable DT = DM.GetDS.Tables[0];
            foreach (DataColumn column in DT.Columns)
            {
                CBColumns.Items.Add(column.ColumnName);
            }
            GenerateCharts();
        }

        private void BTNRestore_Click(object sender, EventArgs e)
        {
            DM.RestoreDataBase();
        }

        private void GenerateCharts()
        {
            
        }

        private void ColumnsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearStuff();
            DataTable dt = DM.GetDS.Tables[0];
            string column = CBColumns.GetItemText(CBColumns.SelectedItem);

            if (column == DataAdmin.DSIM || column == DataAdmin.TS 
                || column == DataAdmin.WF || column == DataAdmin.PR)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row[column] != DBNull.Value)
                        if (!CBCategories.Items.Contains(row[column].ToString()))
                            CBCategories.Items.Add(row[column].ToString());
                }
                CBCategories.Visible = true;
            }
            else if (column == DataAdmin.IM || column == DataAdmin.NC)
            {
                TBSearchEntry.Visible = true;
                BTNSearchString.Visible = true;
            }
            else
            {
                TBLowerBound.Visible = true;
                TBUpperBound.Visible = true;
                BTNSearchRange.Visible = true;
            }
        }

        private void ClearStuff()
        {
            CBCategories.Visible = false;
            CBCategories.Items.Clear();
            TBSearchEntry.Visible = false;
            TBSearchEntry.Clear();
            BTNSearchString.Visible = false;
            TBLowerBound.Visible = false;
            TBLowerBound.Clear();
            TBUpperBound.Visible = false;
            TBUpperBound.Clear();
            BTNSearchRange.Visible = false;
        }

        private void CBCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            DM.FilterByValue(CBColumns.SelectedItem.ToString(),
                CBCategories.GetItemText(CBCategories.SelectedItem));
        }

        private void BTNSearchString_Click(object sender, EventArgs e)
        {
            DM.FilterByValue(CBColumns.SelectedItem.ToString(),
                CBCategories.GetItemText(TBSearchEntry.Text));
        }

        private void BTNSearchRange_Click(object sender, EventArgs e)
        {
            try
            {
                Double lower = Convert.ToDouble(TBLowerBound.Text);
                Double upper = Convert.ToDouble(TBUpperBound.Text);
                if (lower < upper)
                {
                    DM.FilterByNumericRange(CBColumns.SelectedItem.ToString(), lower, upper);
                }
                else
                {
                    MessageBox.Show("Upper bound should be higher than lower bound.", "Error", MessageBoxButtons.OKCancel);
                }
            }catch (FormatException)
            {
                MessageBox.Show("Incorrect entry.", "Error", MessageBoxButtons.OKCancel);
            }
        }

        private void LowerBound_Enter(object sender, EventArgs e)
        {
            if (TBLowerBound.Text == "from")
            {
                TBLowerBound.Text = "";
                TBLowerBound.ForeColor = Color.Black;
            }

        }

        private void LowerBound_Leave(object sender, EventArgs e)
        {
            if (TBLowerBound.Text == "")
            {
                TBLowerBound.Text = "from";
                TBLowerBound.ForeColor = Color.Gray;
            }
        }

        private void UpperBound_Enter(object sender, EventArgs e)
        {
            if (TBUpperBound.Text == "to")
            {
                TBUpperBound.Text = "";
                TBUpperBound.ForeColor = Color.Black;
            }
        }

        private void UpperBound_Leave(object sender, EventArgs e)
        {
            if (TBUpperBound.Text == "")
            {
                TBUpperBound.Text = "to";
                TBUpperBound.ForeColor = Color.Gray;
            }
        }
    }
}
