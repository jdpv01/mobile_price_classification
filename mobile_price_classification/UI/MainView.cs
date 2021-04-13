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
                ColumnsCB.Items.Add(column.ColumnName);
            }
            GenerateCharts();
        }

        private void GenerateCharts()
        {
            
        }

        private void ColumnsCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search(object sender, EventArgs e)
        {

        }

        private void lowerBound_Enter(object sender, EventArgs e)
        {
            if (LowerBoundTB.Text == "from")
            {
                LowerBoundTB.Text = "";
                LowerBoundTB.ForeColor = Color.Black;
            }

        }

        private void lowerBound_Leave(object sender, EventArgs e)
        {
            if (LowerBoundTB.Text == "")
            {
                LowerBoundTB.Text = "from";
                LowerBoundTB.ForeColor = Color.Gray;
            }
        }

        private void upperBound_Enter(object sender, EventArgs e)
        {
            if (UpperBoundTB.Text == "to")
            {
                UpperBoundTB.Text = "";
                UpperBoundTB.ForeColor = Color.Black;
            }
        }

        private void upperBound_Leave(object sender, EventArgs e)
        {
            if (UpperBoundTB.Text == "")
            {
                UpperBoundTB.Text = "to";
                UpperBoundTB.ForeColor = Color.Gray;
            }
        }
    }
}
