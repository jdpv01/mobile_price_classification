using mobile_price_classification.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace mobile_price_classification.UI
{
    public partial class ChartsView : Form
    {
        private readonly MainView MainView;
        private readonly DataAdmin DataAdmin;

        public ChartsView(MainView MainView, DataAdmin DataAdmin)
        {
            InitializeComponent();
            this.DataAdmin = DataAdmin;
            this.MainView = MainView;
            GenerateCharts();
            String[] asw = DataAdmin.MaxMinValue(DataAdmin.BP, DataAdmin.NC, "1");
            MessageBox.Show(asw[0]+" "+ asw[1]+" "+ asw[2]);
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
            chart1.Titles.Add("Amount of Mobile phones per core count");
            IDictionary<string, int> counts = DataAdmin.CountRows(DataAdmin.NC);
            foreach (string value in counts.Keys)
                chart1.Series["Amount per cores count"].Points.AddXY(value, counts[value]);
        }

        private void CreateChart2()
        {
            chart2.Visible = true;
            chart2.Titles.Add("Percentage of mobile phones with dual sim");
            IDictionary<string, int> counts = DataAdmin.CountRows(DataAdmin.DSIM);
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
            chart3.Visible = true;
            chart3.Titles.Add("Amount of mobile phones by clock speed");
            List<double[]> intervals = DataAdmin.CreateIntervalsClockSpeed();
            foreach (double[] interval in intervals)
            {
                chart3.Series["Amount per clock speed class"].Points.AddXY(interval[0]+"-"+interval[1],
                    interval[2]);
                Console.WriteLine(interval[2]);
            }
        }

        public void ChartsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainView.EnableChartsButton();
        }
    }
}
