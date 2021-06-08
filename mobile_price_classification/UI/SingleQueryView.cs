using System;
using System.Windows.Forms;

namespace mobile_price_classification.UI
{
    public partial class SingleQueryView : Form
    {
        private      MainView MainView;

        public SingleQueryView(MainView MainView)
        {
            InitializeComponent();
            this.MainView = MainView;
        }

        private void BTNML_Click(object sender, EventArgs e)
        {
            try
            {
                float.Parse(txtBattery.Text.ToString());
                float.Parse(txtClock.Text.ToString());
                float.Parse(txtMemory.Text.ToString());
                float.Parse(txtCores.Text.ToString());
                float.Parse(txtHeight.Text.ToString());
                float.Parse(txtWidth.Text.ToString());
                float.Parse(txtRam.Text.ToString());
                if (cmbSim.SelectedItem == null)
                {
                    MessageBox.Show("Please type a value for sim");
                }
                else if (cmbTouchScreen.SelectedItem == null)
                {
                    MessageBox.Show("Please type a value for touch screen");
                }
                else if (cmbWifi.SelectedItem == null)
                {
                    MessageBox.Show("Please type a value for wifi");
                }
                else
                {
                    string query = txtBattery.Text.ToString() + ";" + txtClock.Text.ToString() + ";" + 
                        cmbSim.SelectedIndex.ToString() + ";" + txtMemory.Text.ToString() + ";" + 
                        txtCores.Text.ToString() + ";" + txtHeight.Text.ToString() + ";" + txtWidth.Text.ToString() + ";" + 
                        txtRam.Text.ToString() + ";" + cmbTouchScreen.SelectedIndex.ToString() + ";" + 
                        cmbWifi.SelectedIndex.ToString();
                    if (sender.Equals(btnDT))
                    {
                        txtPriceRange.Text = MainView.GetDataAdmin.ClassifySingleQueryDT(query);
                    }
                    else
                    {
                        txtPriceRange.Text = MainView.GetDataAdmin.ClassifySingleQueryML(query);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please type numeric values only");
            }
        }

        private void BTNClear_Click(object sender, EventArgs e)
        {
            txtBattery.Text = "";
            txtClock.Text = "";
            txtCores.Text = "";
            txtHeight.Text = "";
            txtMemory.Text = "";
            txtPriceRange.Text = "";
            txtRam.Text = "";
            txtWidth.Text = "";
            cmbSim.Text = "";
            cmbTouchScreen.Text="";
            cmbWifi.Text = "";
        }

        private void SingleQueryView_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainView.EnableSingleQueryButton();
        }
    }
}
