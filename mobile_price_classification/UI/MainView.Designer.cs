
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
            this.BTNCharts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(1, 3);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(708, 309);
            this.DataGridView1.TabIndex = 0;
            // 
            // BTNOpen
            // 
            this.BTNOpen.Location = new System.Drawing.Point(1, 316);
            this.BTNOpen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNOpen.Name = "BTNOpen";
            this.BTNOpen.Size = new System.Drawing.Size(62, 19);
            this.BTNOpen.TabIndex = 1;
            this.BTNOpen.Text = "Open";
            this.BTNOpen.UseVisualStyleBackColor = true;
            this.BTNOpen.Click += new System.EventHandler(this.BTNOpen_Click);
            // 
            // CBColumns
            // 
            this.CBColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBColumns.FormattingEnabled = true;
            this.CBColumns.Location = new System.Drawing.Point(69, 316);
            this.CBColumns.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CBColumns.Name = "CBColumns";
            this.CBColumns.Size = new System.Drawing.Size(101, 21);
            this.CBColumns.TabIndex = 2;
            this.CBColumns.SelectedIndexChanged += new System.EventHandler(this.ColumnsCB_SelectedIndexChanged);
            // 
            // TBLowerBound
            // 
            this.TBLowerBound.Location = new System.Drawing.Point(69, 339);
            this.TBLowerBound.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TBLowerBound.Name = "TBLowerBound";
            this.TBLowerBound.Size = new System.Drawing.Size(59, 20);
            this.TBLowerBound.TabIndex = 3;
            this.TBLowerBound.Visible = false;
            this.TBLowerBound.Enter += new System.EventHandler(this.LowerBound_Enter);
            this.TBLowerBound.Leave += new System.EventHandler(this.LowerBound_Leave);
            // 
            // TBUpperBound
            // 
            this.TBUpperBound.Location = new System.Drawing.Point(133, 339);
            this.TBUpperBound.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TBUpperBound.Name = "TBUpperBound";
            this.TBUpperBound.Size = new System.Drawing.Size(59, 20);
            this.TBUpperBound.TabIndex = 4;
            this.TBUpperBound.Visible = false;
            this.TBUpperBound.Enter += new System.EventHandler(this.UpperBound_Enter);
            this.TBUpperBound.Leave += new System.EventHandler(this.UpperBound_Leave);
            // 
            // BTNSearchRange
            // 
            this.BTNSearchRange.Location = new System.Drawing.Point(69, 361);
            this.BTNSearchRange.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNSearchRange.Name = "BTNSearchRange";
            this.BTNSearchRange.Size = new System.Drawing.Size(62, 19);
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
            this.CBCategories.Location = new System.Drawing.Point(175, 316);
            this.CBCategories.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CBCategories.Name = "CBCategories";
            this.CBCategories.Size = new System.Drawing.Size(101, 21);
            this.CBCategories.TabIndex = 6;
            this.CBCategories.Visible = false;
            this.CBCategories.SelectedIndexChanged += new System.EventHandler(this.CBCategories_SelectedIndexChanged);
            // 
            // TBSearchEntry
            // 
            this.TBSearchEntry.Location = new System.Drawing.Point(69, 339);
            this.TBSearchEntry.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TBSearchEntry.Name = "TBSearchEntry";
            this.TBSearchEntry.Size = new System.Drawing.Size(84, 20);
            this.TBSearchEntry.TabIndex = 7;
            this.TBSearchEntry.Visible = false;
            // 
            // BTNSearchString
            // 
            this.BTNSearchString.Location = new System.Drawing.Point(69, 361);
            this.BTNSearchString.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNSearchString.Name = "BTNSearchString";
            this.BTNSearchString.Size = new System.Drawing.Size(62, 19);
            this.BTNSearchString.TabIndex = 8;
            this.BTNSearchString.Text = "Search";
            this.BTNSearchString.UseVisualStyleBackColor = true;
            this.BTNSearchString.Visible = false;
            this.BTNSearchString.Click += new System.EventHandler(this.BTNSearchString_Click);
            // 
            // BTNRestore
            // 
            this.BTNRestore.Location = new System.Drawing.Point(1, 338);
            this.BTNRestore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNRestore.Name = "BTNRestore";
            this.BTNRestore.Size = new System.Drawing.Size(62, 19);
            this.BTNRestore.TabIndex = 9;
            this.BTNRestore.Text = "Restore";
            this.BTNRestore.UseVisualStyleBackColor = true;
            this.BTNRestore.Visible = false;
            this.BTNRestore.Click += new System.EventHandler(this.BTNRestore_Click);
            // 
            // BTNCharts
            // 
            this.BTNCharts.Location = new System.Drawing.Point(1, 361);
            this.BTNCharts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNCharts.Name = "BTNCharts";
            this.BTNCharts.Size = new System.Drawing.Size(62, 19);
            this.BTNCharts.TabIndex = 13;
            this.BTNCharts.Text = "Charts";
            this.BTNCharts.UseVisualStyleBackColor = true;
            this.BTNCharts.Visible = false;
            this.BTNCharts.Click += new System.EventHandler(this.BTNCharts_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(712, 475);
            this.Controls.Add(this.BTNCharts);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainView";
            this.Text = "Mobile Price Classifier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainView_FormClosed);
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
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
        private System.Windows.Forms.Button BTNCharts;
    }
}

