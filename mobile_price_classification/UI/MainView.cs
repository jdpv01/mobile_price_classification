﻿using mobile_price_classification.Model;
using mobile_price_classification.UI;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace mobile_price_classification
{
    public partial class MainView : Form
    {
        private readonly DataAdmin DataAdmin;
        private ChartsView ChartsView;
        private SingleQueryView SingleQueryView;

        public MainView()
        {
            InitializeComponent();
            DataAdmin = new DataAdmin();
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
            {
                DataGridView1.DataSource = DataAdmin.SetDataBaseConnection(ofd.FileName);
            }
               
            try
            {
                DataTable dt = DataAdmin.GetDT;
                foreach (DataColumn column in dt.Columns)
                {
                    CBColumns.Items.Add(column.ColumnName);
                }
                BTNRestore.Visible = true;
                BTNCharts.Visible = true;
                BTNClassifyDT.Visible = true;
                BTNClassifyDT.Enabled = true;
                BTNClassifyML.Visible = true;
                BTNClassifyML.Enabled = true;
                LabelDT.Visible = true;
                LabelML.Visible = true;
            }
            catch (NullReferenceException)
            {
            }          
        }

        private void BTNCharts_Click(object sender, EventArgs e)
        {
            ChartsView = new ChartsView(this);
            ChartsView.Show();
            BTNCharts.Enabled = false;
        }

        public void EnableChartsButton()
        {
            BTNCharts.Enabled = true;
        }

        public void EnableSingleQueryButton()
        {
            BTNSingleQuery.Enabled = true;
        }

        private void BTNRestore_Click(object sender, EventArgs e)
        {
            DataAdmin.RestoreDataBase();
        }

        private void ColumnsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearStuff();
            DataTable dt = DataAdmin.GetDT;
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
            DataAdmin.FilterByValue(CBColumns.SelectedItem.ToString(),
                CBCategories.GetItemText(CBCategories.SelectedItem));
        }

        private void BTNSearchString_Click(object sender, EventArgs e)
        {
            try
            {
                DataAdmin.FilterByValue(CBColumns.SelectedItem.ToString(),
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
                    DataAdmin.FilterByNumericRange(CBColumns.SelectedItem.ToString(), lower, upper);
                else
                    MessageBox.Show("Upper bound should be higher than lower bound.", "Error", MessageBoxButtons.OKCancel);
                
            }catch (FormatException)
            {
                MessageBox.Show("Invalid entry.", "Error", MessageBoxButtons.OKCancel);
            }
        }

        private void ClassifyDTImplementation_Click(object sender, EventArgs e)
        {
            DataAdmin.BuildDecisionTree();
            LabelPrecisionValue.Text = DataAdmin.GetMLPrecision() + "%";
            LabelPrecision.Visible = true;
            LabelPrecisionValue.Visible = true;
            BTNSingleQuery.Visible = true;
        }

        private void ClassifyMLLibrary_Click(object sender, EventArgs e)
        {
            DataAdmin.ClassifyDataSetML();
            LabelPrecisionValue.Text = DataAdmin.GetMLPrecision() + "%";
            LabelPrecision.Visible = true;
            LabelPrecisionValue.Visible = true;
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

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ChartsView.Close();
                SingleQueryView.Close();
            }
            catch (NullReferenceException)
            {
            }
        }

        public DataAdmin GetDataAdmin => DataAdmin;

        private void BTNSingleQuery_Click(object sender, EventArgs e)
        {
            SingleQueryView = new SingleQueryView(this);
            SingleQueryView.Show();
            BTNSingleQuery.Enabled = false;
        }
    }
}
