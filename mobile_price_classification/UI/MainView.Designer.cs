
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
            this.OpenBTN = new System.Windows.Forms.Button();
            this.ColumnsCB = new System.Windows.Forms.ComboBox();
            this.LowerBoundTB = new System.Windows.Forms.TextBox();
            this.UpperBoundTB = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(1, 3);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(796, 334);
            this.DataGridView1.TabIndex = 0;
            // 
            // OpenBTN
            // 
            this.OpenBTN.Location = new System.Drawing.Point(1, 343);
            this.OpenBTN.Name = "OpenBTN";
            this.OpenBTN.Size = new System.Drawing.Size(75, 23);
            this.OpenBTN.TabIndex = 1;
            this.OpenBTN.Text = "Open";
            this.OpenBTN.UseVisualStyleBackColor = true;
            this.OpenBTN.Click += new System.EventHandler(this.Open);
            // 
            // ColumnsCB
            // 
            this.ColumnsCB.FormattingEnabled = true;
            this.ColumnsCB.Location = new System.Drawing.Point(83, 344);
            this.ColumnsCB.Name = "ColumnsCB";
            this.ColumnsCB.Size = new System.Drawing.Size(121, 21);
            this.ColumnsCB.TabIndex = 2;
            this.ColumnsCB.SelectedIndexChanged += new System.EventHandler(this.ColumnsCB_SelectedIndexChanged);
            // 
            // LowerBoundTB
            // 
            this.LowerBoundTB.Location = new System.Drawing.Point(83, 371);
            this.LowerBoundTB.Name = "LowerBoundTB";
            this.LowerBoundTB.Size = new System.Drawing.Size(71, 20);
            this.LowerBoundTB.TabIndex = 3;
            // 
            // UpperBoundTB
            // 
            this.UpperBoundTB.Location = new System.Drawing.Point(160, 371);
            this.UpperBoundTB.Name = "UpperBoundTB";
            this.UpperBoundTB.Size = new System.Drawing.Size(71, 20);
            this.UpperBoundTB.TabIndex = 4;
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(83, 397);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(75, 23);
            this.SearchBTN.TabIndex = 5;
            this.SearchBTN.Text = "Search";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.Search);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.UpperBoundTB);
            this.Controls.Add(this.LowerBoundTB);
            this.Controls.Add(this.ColumnsCB);
            this.Controls.Add(this.OpenBTN);
            this.Controls.Add(this.DataGridView1);
            this.Name = "MainView";
            this.Text = "Mobile Price Classifier";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button OpenBTN;
        private System.Windows.Forms.ComboBox ColumnsCB;
        private System.Windows.Forms.TextBox LowerBoundTB;
        private System.Windows.Forms.TextBox UpperBoundTB;
        private System.Windows.Forms.Button SearchBTN;
    }
}

