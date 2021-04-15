
namespace mobile_price_classification
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTNOpen = new System.Windows.Forms.Button();
            this.CBColumns = new System.Windows.Forms.ComboBox();
            this.TBLowerBound = new System.Windows.Forms.TextBox();
            this.TBUpperBound = new System.Windows.Forms.TextBox();
            this.BTNSearchRange = new System.Windows.Forms.Button();
            this.CBCategories = new System.Windows.Forms.ComboBox();
            this.TBSearchEntry = new System.Windows.Forms.TextBox();
            this.BTNSearchString = new System.Windows.Forms.Button();
            this.BTNRestore = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(1, 3);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(850, 365);
            this.DataGridView1.TabIndex = 0;
            // 
            // BTNOpen
            // 
            this.BTNOpen.Location = new System.Drawing.Point(1, 373);
            this.BTNOpen.Name = "BTNOpen";
            this.BTNOpen.Size = new System.Drawing.Size(75, 23);
            this.BTNOpen.TabIndex = 1;
            this.BTNOpen.Text = "Open";
            this.BTNOpen.UseVisualStyleBackColor = true;
            this.BTNOpen.Click += new System.EventHandler(this.BTNOpen_Click);
            // 
            // CBColumns
            // 
            this.CBColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBColumns.FormattingEnabled = true;
            this.CBColumns.Location = new System.Drawing.Point(83, 374);
            this.CBColumns.Name = "CBColumns";
            this.CBColumns.Size = new System.Drawing.Size(121, 21);
            this.CBColumns.TabIndex = 2;
            this.CBColumns.SelectedIndexChanged += new System.EventHandler(this.ColumnsCB_SelectedIndexChanged);
            // 
            // TBLowerBound
            // 
            this.TBLowerBound.Location = new System.Drawing.Point(83, 401);
            this.TBLowerBound.Name = "TBLowerBound";
            this.TBLowerBound.Size = new System.Drawing.Size(70, 20);
            this.TBLowerBound.TabIndex = 3;
            this.TBLowerBound.Visible = false;
            this.TBLowerBound.Enter += new System.EventHandler(this.LowerBound_Enter);
            this.TBLowerBound.Leave += new System.EventHandler(this.LowerBound_Leave);
            // 
            // TBUpperBound
            // 
            this.TBUpperBound.Location = new System.Drawing.Point(160, 401);
            this.TBUpperBound.Name = "TBUpperBound";
            this.TBUpperBound.Size = new System.Drawing.Size(70, 20);
            this.TBUpperBound.TabIndex = 4;
            this.TBUpperBound.Visible = false;
            this.TBUpperBound.Enter += new System.EventHandler(this.UpperBound_Enter);
            this.TBUpperBound.Leave += new System.EventHandler(this.UpperBound_Leave);
            // 
            // BTNSearchRange
            // 
            this.BTNSearchRange.Location = new System.Drawing.Point(83, 427);
            this.BTNSearchRange.Name = "BTNSearchRange";
            this.BTNSearchRange.Size = new System.Drawing.Size(75, 23);
            this.BTNSearchRange.TabIndex = 5;
            this.BTNSearchRange.Text = "Search";
            this.BTNSearchRange.UseVisualStyleBackColor = true;
            this.BTNSearchRange.Visible = false;
            this.BTNSearchRange.Click += new System.EventHandler(this.BTNSearchRange_Click);
            // 
            // CBCategories
            // 
            this.CBCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategories.FormattingEnabled = true;
            this.CBCategories.Location = new System.Drawing.Point(210, 374);
            this.CBCategories.Name = "CBCategories";
            this.CBCategories.Size = new System.Drawing.Size(121, 21);
            this.CBCategories.TabIndex = 6;
            this.CBCategories.Visible = false;
            this.CBCategories.SelectedIndexChanged += new System.EventHandler(this.CBCategories_SelectedIndexChanged);
            // 
            // TBSearchEntry
            // 
            this.TBSearchEntry.Location = new System.Drawing.Point(83, 401);
            this.TBSearchEntry.Name = "TBSearchEntry";
            this.TBSearchEntry.Size = new System.Drawing.Size(100, 20);
            this.TBSearchEntry.TabIndex = 7;
            this.TBSearchEntry.Visible = false;
            // 
            // BTNSearchString
            // 
            this.BTNSearchString.Location = new System.Drawing.Point(83, 427);
            this.BTNSearchString.Name = "BTNSearchString";
            this.BTNSearchString.Size = new System.Drawing.Size(75, 23);
            this.BTNSearchString.TabIndex = 8;
            this.BTNSearchString.Text = "Search";
            this.BTNSearchString.UseVisualStyleBackColor = true;
            this.BTNSearchString.Visible = false;
            this.BTNSearchString.Click += new System.EventHandler(this.BTNSearchString_Click);
            // 
            // BTNRestore
            // 
            this.BTNRestore.Location = new System.Drawing.Point(2, 398);
            this.BTNRestore.Name = "BTNRestore";
            this.BTNRestore.Size = new System.Drawing.Size(75, 23);
            this.BTNRestore.TabIndex = 9;
            this.BTNRestore.Text = "Restore";
            this.BTNRestore.UseVisualStyleBackColor = true;
            this.BTNRestore.Visible = false;
            this.BTNRestore.Click += new System.EventHandler(this.BTNRestore_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(337, 373);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Amount per cores count";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(301, 185);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(644, 374);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Label = "#PERCENT";
            series2.Legend = "Legend1";
            series2.Name = "A";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(207, 185);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(865, 3);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Amount per clock speed class";
            series3.YValuesPerPoint = 2;
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(207, 185);
            this.chart3.TabIndex = 12;
            this.chart3.Text = "chart3";
            this.chart3.Visible = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BTNRestore);
            this.Controls.Add(this.BTNSearchString);
            this.Controls.Add(this.TBSearchEntry);
            this.Controls.Add(this.CBCategories);
            this.Controls.Add(this.BTNSearchRange);
            this.Controls.Add(this.TBUpperBound);
            this.Controls.Add(this.TBLowerBound);
            this.Controls.Add(this.CBColumns);
            this.Controls.Add(this.BTNOpen);
            this.Controls.Add(this.DataGridView1);
            this.Name = "MainView";
            this.Text = "Mobile Price Classifier";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button BTNOpen;
        private System.Windows.Forms.ComboBox CBColumns;
        private System.Windows.Forms.TextBox TBLowerBound;
        private System.Windows.Forms.TextBox TBUpperBound;
        private System.Windows.Forms.Button BTNSearchRange;
        private System.Windows.Forms.ComboBox CBCategories;
        private System.Windows.Forms.TextBox TBSearchEntry;
        private System.Windows.Forms.Button BTNSearchString;
        private System.Windows.Forms.Button BTNRestore;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}

