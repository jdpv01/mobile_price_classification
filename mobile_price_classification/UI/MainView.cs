using mobile_price_classification.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace mobile_price_classification
{
    public partial class MainView : Form
    {
        private readonly DataAdmin DA;

        public MainView()
        {
            InitializeComponent();
            DA = new DataAdmin();
        }

        private void BTNOpen_Click(object sender, EventArgs e)
        {
            CBColumns.Items.Clear();
            ClearStuff();
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Excel | *.xls;*.xlsx;",
                Title = "Select File"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
                DataGridView1.DataSource = DA.SetDataBaseConnection(ofd.FileName);
            try
            {
                DataTable dt = DA.GetDT;
                foreach (DataColumn column in dt.Columns)
                {
                    CBColumns.Items.Add(column.ColumnName);
                }
                BTNRestore.Visible = true;
                GenerateCharts();
            }
            catch (NullReferenceException)
            {
            }          
        }

        private void GenerateCharts()
        {
            chart1.Series["Amount per cores count"].Points.Clear();
            chart1.Titles.Clear();
            chart2.Series["A"].Points.Clear();
            chart2.Titles.Clear();
            chart3.Series["Amount per clock speed class"].Points.Clear();
            chart3.Titles.Clear();
            CreateChart1();
            CreateChart2();
            CreateChart3();
        }

        private void CreateChart1()
        {
            chart1.Visible = true;
            chart1.Titles.Add("Mobile phones per core count");
            IDictionary<string, int> counts = DA.CountRows(DataAdmin.NC);
            foreach (string value in counts.Keys)
                chart1.Series["Amount per cores count"].Points.AddXY(value, counts[value]);
        }

        private void CreateChart2()
        {
            chart2.Visible = true;
            chart2.Titles.Add("Percentage of mobile phones with dual sim");
            IDictionary<string, int> counts = DA.CountRows(DataAdmin.DSIM);
            int i = 0;
            foreach (string value in counts.Keys)
            {
                chart2.Series["A"].Points.AddXY(value, counts[value]);
                chart2.Series["A"].Points[i].LegendText = value;
                i++;
            }
        }

        private void CreateChart3()
        {
            
        }

        private void BTNRestore_Click(object sender, EventArgs e)
        {
            DA.RestoreDataBase();
        }

        private void ColumnsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearStuff();
            DataTable dt = DA.GetDT;
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
            DA.FilterByValue(CBColumns.SelectedItem.ToString(),
                CBCategories.GetItemText(CBCategories.SelectedItem));
        }

        private void BTNSearchString_Click(object sender, EventArgs e)
        {
            try
            {
                DA.FilterByValue(CBColumns.SelectedItem.ToString(),
                CBCategories.GetItemText(TBSearchEntry.Text));
            }catch (Exception)
            {
                MessageBox.Show("Invalid entry.", "Error", MessageBoxButtons.OKCancel);
            }
        }

        private void BTNSearchRange_Click(object sender, EventArgs e)
        {
            try
            {
                Double lower = Convert.ToDouble(TBLowerBound.Text);
                Double upper = Convert.ToDouble(TBUpperBound.Text);
                if (lower < upper)
                    DA.FilterByNumericRange(CBColumns.SelectedItem.ToString(), lower, upper);
                else
                    MessageBox.Show("Upper bound should be higher than lower bound.", "Error", MessageBoxButtons.OKCancel);
                
            }catch (FormatException)
            {
                MessageBox.Show("Invalid entry.", "Error", MessageBoxButtons.OKCancel);
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
