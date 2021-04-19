﻿using mobile_price_classification.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace mobile_price_classification.UI
{
    public partial class ChartsView : Form
    {
        private readonly MainView MainView;

        public ChartsView(MainView MainView)
        {
            InitializeComponent();
            this.MainView = MainView;
            GenerateCharts();
        }

        private void GenerateCharts()
        {
            chart1.Series["Amount per cores count"].Points.Clear();
            chart1.Titles.Clear();
            chart2.Series["A"].Points.Clear();
            chart2.Titles.Clear();
            chart3.Series["Amount per clock speed class"].Points.Clear();
            chart3.Titles.Clear();
            chart4.Series["Battery per No cores"].Points.Clear();
            chart4.Titles.Clear();
            chart5.Series["Amount per ram"].Points.Clear();
            chart5.Titles.Clear();
            CreateChart1();
            CreateChart2();
            CreateChart3();
            CreateChart4();
            CreateChart5();
        }

        private void CreateChart1()
        {
            chart1.Visible = true;
            chart1.Titles.Add("Amount of Mobile phones per core count");
            IDictionary<string, int> counts = MainView.GetDataAdmin.CountRows(DataAdmin.NC);
            foreach (string value in counts.Keys)
                chart1.Series["Amount per cores count"].Points.AddXY(value, counts[value]);
        }

        private void CreateChart2()
        {
            chart2.Visible = true;
            chart2.Titles.Add("Percentage of mobile phones with dual sim");
            IDictionary<string, int> counts = MainView.GetDataAdmin.CountRows(DataAdmin.DSIM);
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
            List<double[]> intervals = MainView.GetDataAdmin.CreateIntervalsClockSpeed();
            foreach (double[] interval in intervals)
            {
                chart3.Series["Amount per clock speed class"].Points.AddXY(interval[0]+"-"+interval[1],
                    interval[2]);
            }
        }
        private void CreateChart4()
        {
            chart4.Visible = true;
            chart4.Titles.Add("Range of battery acording with cores");
            for(int i = 1; i <= 8; i++)
            {
                String[] maxMin = MainView.GetDataAdmin.MaxMinValue(DataAdmin.BP, DataAdmin.NC, i.ToString());
                chart4.Series["Battery per No cores"].Points.AddXY(i.ToString(), int.Parse(maxMin[1]), int.Parse(maxMin[2]));
            }
        }
        private void CreateChart5()
        {
            chart5.Visible = true;
            chart5.Titles.Add("Amount of mobiles per ram intervals");
            List<int[]> intervals = MainView.GetDataAdmin.CreateIntervalsRam();
            foreach(int[] interval in intervals)
            {
                chart5.Series["Amount per ram"].Points.AddXY(interval[0] + "-" + interval[1], interval[2]);
            }
            chart5.Series["Amount per ram"].IsValueShownAsLabel = true;
        }

        public void ChartsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainView.EnableChartsButton();
        }
    }
}
