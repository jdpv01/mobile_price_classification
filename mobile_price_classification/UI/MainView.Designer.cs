
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
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
            this.BTNClassify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(2, 4);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 62;
            this.DataGridView1.Size = new System.Drawing.Size(991, 450);
            this.DataGridView1.TabIndex = 0;
            // 
            // BTNOpen
            // 
            this.BTNOpen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNOpen.Location = new System.Drawing.Point(2, 460);
            this.BTNOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNOpen.Name = "BTNOpen";
            this.BTNOpen.Size = new System.Drawing.Size(87, 28);
            this.BTNOpen.TabIndex = 1;
            this.BTNOpen.Text = "Open";
            this.BTNOpen.UseCompatibleTextRendering = true;
            this.BTNOpen.UseVisualStyleBackColor = true;
            this.BTNOpen.Click += new System.EventHandler(this.BTNOpen_Click);
            // 
            // CBColumns
            // 
            this.CBColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBColumns.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBColumns.FormattingEnabled = true;
            this.CBColumns.Location = new System.Drawing.Point(95, 461);
            this.CBColumns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBColumns.Name = "CBColumns";
            this.CBColumns.Size = new System.Drawing.Size(140, 31);
            this.CBColumns.TabIndex = 2;
            this.CBColumns.SelectedIndexChanged += new System.EventHandler(this.ColumnsCB_SelectedIndexChanged);
            // 
            // TBLowerBound
            // 
            this.TBLowerBound.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBLowerBound.Location = new System.Drawing.Point(96, 494);
            this.TBLowerBound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBLowerBound.Name = "TBLowerBound";
            this.TBLowerBound.Size = new System.Drawing.Size(81, 31);
            this.TBLowerBound.TabIndex = 3;
            this.TBLowerBound.Visible = false;
            this.TBLowerBound.Enter += new System.EventHandler(this.LowerBound_Enter);
            this.TBLowerBound.Leave += new System.EventHandler(this.LowerBound_Leave);
            // 
            // TBUpperBound
            // 
            this.TBUpperBound.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUpperBound.Location = new System.Drawing.Point(183, 494);
            this.TBUpperBound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBUpperBound.Name = "TBUpperBound";
            this.TBUpperBound.Size = new System.Drawing.Size(81, 31);
            this.TBUpperBound.TabIndex = 4;
            this.TBUpperBound.Visible = false;
            this.TBUpperBound.Enter += new System.EventHandler(this.UpperBound_Enter);
            this.TBUpperBound.Leave += new System.EventHandler(this.UpperBound_Leave);
            // 
            // BTNSearchRange
            // 
            this.BTNSearchRange.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSearchRange.Location = new System.Drawing.Point(96, 525);
            this.BTNSearchRange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNSearchRange.Name = "BTNSearchRange";
            this.BTNSearchRange.Size = new System.Drawing.Size(87, 28);
            this.BTNSearchRange.TabIndex = 5;
            this.BTNSearchRange.Text = "Search";
            this.BTNSearchRange.UseVisualStyleBackColor = true;
            this.BTNSearchRange.Visible = false;
            this.BTNSearchRange.Click += new System.EventHandler(this.BTNSearchRange_Click);
            // 
            // CBCategories
            // 
            this.CBCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategories.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCategories.FormattingEnabled = true;
            this.CBCategories.Location = new System.Drawing.Point(241, 461);
            this.CBCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBCategories.Name = "CBCategories";
            this.CBCategories.Size = new System.Drawing.Size(140, 31);
            this.CBCategories.TabIndex = 6;
            this.CBCategories.Visible = false;
            this.CBCategories.SelectedIndexChanged += new System.EventHandler(this.CBCategories_SelectedIndexChanged);
            // 
            // TBSearchEntry
            // 
            this.TBSearchEntry.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSearchEntry.Location = new System.Drawing.Point(96, 494);
            this.TBSearchEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBSearchEntry.Name = "TBSearchEntry";
            this.TBSearchEntry.Size = new System.Drawing.Size(99, 31);
            this.TBSearchEntry.TabIndex = 7;
            this.TBSearchEntry.Visible = false;
            // 
            // BTNSearchString
            // 
            this.BTNSearchString.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSearchString.Location = new System.Drawing.Point(96, 525);
            this.BTNSearchString.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNSearchString.Name = "BTNSearchString";
            this.BTNSearchString.Size = new System.Drawing.Size(87, 28);
            this.BTNSearchString.TabIndex = 8;
            this.BTNSearchString.Text = "Search";
            this.BTNSearchString.UseCompatibleTextRendering = true;
            this.BTNSearchString.UseVisualStyleBackColor = true;
            this.BTNSearchString.Visible = false;
            this.BTNSearchString.Click += new System.EventHandler(this.BTNSearchString_Click);
            // 
            // BTNRestore
            // 
            this.BTNRestore.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRestore.Location = new System.Drawing.Point(2, 492);
            this.BTNRestore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNRestore.Name = "BTNRestore";
            this.BTNRestore.Size = new System.Drawing.Size(87, 28);
            this.BTNRestore.TabIndex = 9;
            this.BTNRestore.Text = "Restore";
            this.BTNRestore.UseCompatibleTextRendering = true;
            this.BTNRestore.UseVisualStyleBackColor = true;
            this.BTNRestore.Visible = false;
            this.BTNRestore.Click += new System.EventHandler(this.BTNRestore_Click);
            // 
            // BTNCharts
            // 
            this.BTNCharts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCharts.Location = new System.Drawing.Point(2, 525);
            this.BTNCharts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNCharts.Name = "BTNCharts";
            this.BTNCharts.Size = new System.Drawing.Size(87, 28);
            this.BTNCharts.TabIndex = 13;
            this.BTNCharts.Text = "Charts";
            this.BTNCharts.UseCompatibleTextRendering = true;
            this.BTNCharts.UseVisualStyleBackColor = true;
            this.BTNCharts.Visible = false;
            this.BTNCharts.Click += new System.EventHandler(this.BTNCharts_Click);
            // 
            // BTNClassify
            // 
            this.BTNClassify.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNClassify.Location = new System.Drawing.Point(2, 559);
            this.BTNClassify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNClassify.Name = "BTNClassify";
            this.BTNClassify.Size = new System.Drawing.Size(87, 28);
            this.BTNClassify.TabIndex = 14;
            this.BTNClassify.Text = "Classify";
            this.BTNClassify.UseCompatibleTextRendering = true;
            this.BTNClassify.UseVisualStyleBackColor = true;
            this.BTNClassify.Visible = false;
            this.BTNClassify.Click += new System.EventHandler(this.Classify_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(997, 600);
            this.Controls.Add(this.BTNClassify);
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
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainView";
            this.Text = "Mobile Price Classifier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainView_FormClosed);
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
        private System.Windows.Forms.Button BTNClassify;
    }
}

