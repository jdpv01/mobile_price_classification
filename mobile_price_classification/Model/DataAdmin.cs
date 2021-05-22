﻿//using mobile_price_classification.DTree;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Statistics.Filters;
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
            TS = "touch_screen", WF = "wifi", PR = "price_range", PRML = "price_range using ML";
        public const int TRAININGSET_SIZE = 499;
        private DataTable DT;
        private DecisionTree DecisionTree;

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
            return DT.DefaultView;
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

        public void BuildDecisionTree()
        {
            string[] trainingSet = BuildTrainingSetFromData();
            DataTable data = new DataTable();
            data.Columns.Add(BP);
            data.Columns.Add(CS);
            data.Columns.Add(DSIM);
            data.Columns.Add(IM);
            data.Columns.Add(NC);
            data.Columns.Add(PH);
            data.Columns.Add(PW);
            data.Columns.Add(RAM);
            data.Columns.Add(TS);
            data.Columns.Add(WF);
            data.Columns.Add(PR);
            for (int i = 0; i < trainingSet.Length; i++)
            {
                string[] values = trainingSet[i].Split(';');
                data.Rows.Add(values);
            }
            var codebook = new Codification()
            {
                DefaultMissingValueReplacement = Double.NaN
            };
            codebook.Learn(data);
            DataTable symbols = codebook.Apply(data);
            string[] columns = new[] { BP, CS, DSIM, IM, NC, PH, PW, RAM, TS, WF };
            int[][] inputs = symbols.ToJagged<int>(columns);
            int[] outputs = symbols.ToArray<int>(PR);
            var C45 = new C45Learning()
            {
                Attributes = DecisionVariable.FromCodebook(codebook, columns)
            };
            DecisionTree = C45.Learn(inputs, outputs);
            ClassifyDataSet(codebook, DecisionTree);
        }

        private void ClassifyDataSet(Codification codebook, DecisionTree DecisionTree)
        {
            string[] queries = BuildDataSetFromData();
            try
            {
                DT.Columns.Remove(PRML);
            }
            catch (ArgumentException)
            {
            }

            DT.Columns.Add(PRML, typeof(string));
            int i = 0;
            foreach (DataRow row in DT.Rows)
            {
                string[] values = queries[i].Split(';');
                Console.WriteLine(codebook.Columns.Count);
                int[] query = codebook.Transform(values);
                int output = DecisionTree.Decide(query);
                row[PRML] = codebook.Revert(PR, output);
                i++;
            }
        }

        //public void BuildDecisionTree()
        //{
        //    Datarow[] trainingSet = Datarow.GetDatarowsFromStringArray(BuildTrainingSetFromData());
        //    DecisionTree = new DecisionTree(trainingSet);
        //    DecisionTree.BuildTree();
        //    ClassifyDataSet();
        //}

        //private void ClassifyDataSet()
        //{
        //    string[] queries = BuildDataSetFromData();
        //    try
        //    {
        //        DT.Columns.Remove(PRML);
        //    }
        //    catch (ArgumentException)
        //    {
        //    }

        //    DT.Columns.Add(PRML, typeof(string));
        //    int i = 0;
        //    foreach (DataRow row in DT.Rows)
        //    {
        //        row[PRML] = DecisionTree.Classify(new Datarow(queries[i])).ToString();
        //        i++;
        //    }
        //}

        private string[] BuildTrainingSetFromData()
        {
            String[] trainingSet = new string[TRAININGSET_SIZE];
            int i = 0;
            foreach (DataRow row in DT.Rows)
            {
                string line = "";
                foreach (DataColumn column in DT.Columns)
                {
                    if (column == DT.Columns[DT.Columns.Count - 1])
                        line += row[column].ToString();
                    else
                        line += row[column].ToString() + ";";
                }
                trainingSet[i] = line;
                if (i == TRAININGSET_SIZE - 1) break;
                i++;
            }
            return trainingSet;
        }

        private string[] BuildDataSetFromData()
        {
            String[] dataset = new string[DT.Rows.Count];
            int i = 0;
            foreach (DataRow row in DT.Rows)
            {
                string line = "";
                foreach (DataColumn column in DT.Columns)
                {
                    if (column == DT.Columns[DT.Columns.Count - 2])
                        line += row[column].ToString();
                    else if (column != DT.Columns[DT.Columns.Count - 1])
                        line += row[column].ToString() + ";";
                }
                dataset[i] = line;
                i++;
            }
            return dataset;
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
            List<double[]> intervals = new List<double[]>
            {
                interval1,
                interval2,
                interval3,
                interval4,
                interval5
            };
            return intervals;
        }

        public List<int[]> CreateIntervalsRam()
        {
            int[] interval1 = { 256, 880, 0 }; int[] interval2 = { 880, 1504, 0 };
            int[] interval3 = { 1504, 2128, 0 }; int[] interval4 = { 2128, 2752, 0 };
            int[] interval5 = { 2752, 3376, 0 }; int[] interval6 = { 3376, 4000, 0 };
            foreach(DataRow row in DT.Rows)
            {
                if(row[RAM] != DBNull.Value)
                {
                    double value = Convert.ToDouble(row[RAM]);
                    if (value >= interval1[0] && value < interval1[1])
                        interval1[2]++;
                    else if (value >= interval2[0] && value < interval2[1])
                        interval2[2]++;
                    else if (value >= interval3[0] && value < interval3[1])
                        interval3[2]++;
                    else if (value >= interval4[0] && value < interval4[1])
                        interval4[2]++;
                    else if (value >= interval5[0] && value < interval5[1])
                        interval5[2]++;
                    else if (value >= interval6[0] && value < interval6[1])
                        interval6[2]++;
                }
            }
            List<int[]> intervals = new List<int[]>
            {
                interval1,
                interval2,
                interval3,
                interval4,
                interval5,
                interval6
            };
            return intervals;
        }

        public DataTable GetDT => DT;
    }
}
