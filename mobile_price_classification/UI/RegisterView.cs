using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobile_price_classification.UI
{
    public partial class RegisterView : Form
    {
        private readonly MainView MainView;

        public RegisterView(MainView MainView)
        {
            InitializeComponent();
            this.MainView = MainView;
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            string query = "";
            btnDT.Enabled = false;
            btnML.Enabled = false;
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
                    MessageBox.Show("Please select a value for sim");
                }
                else if(cmbTouchScreen.SelectedItem==null)
                {
                    MessageBox.Show("Please select a value for touch screen");
                }
                else if (cmbWifi.SelectedItem == null)
                {
                    MessageBox.Show("Please select a value for wifi");
                }
                else
                {
                    query = txtBattery.Text.ToString() + txtClock.Text.ToString() + cmbSim.SelectedIndex.ToString()
                        + txtMemory.Text.ToString() + txtCores.Text.ToString() + txtHeight.Text.ToString()
                        + txtWidth.Text.ToString() + txtRam.Text.ToString() + cmbTouchScreen.SelectedIndex.ToString()
                        + cmbWifi.SelectedIndex.ToString();
                    txtPriceRange.Text = MainView.GetDataAdmin.ClassifySingleQueryDT(query);
                    btnDT.Enabled = true;
                    btnML.Enabled = true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please digit numeric values");
                btnDT.Enabled = true;
                btnML.Enabled = true;
            }
        }

        private void btnML_Click(object sender, EventArgs e)
        {
            string query = "";
            btnDT.Enabled = false;
            btnML.Enabled = false;
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
                    MessageBox.Show("Please select a value for sim");
                }
                else if (cmbTouchScreen.SelectedItem == null)
                {
                    MessageBox.Show("Please select a value for touch screen");
                }
                else if (cmbWifi.SelectedItem == null)
                {
                    MessageBox.Show("Please select a value for wifi");
                }
                else
                {
                    query = txtBattery.Text.ToString() + txtClock.Text.ToString() + cmbSim.SelectedIndex.ToString()
                        + txtMemory.Text.ToString() + txtCores.Text.ToString() + txtHeight.Text.ToString()
                        + txtWidth.Text.ToString() + txtRam.Text.ToString() + cmbTouchScreen.SelectedIndex.ToString()
                        + cmbWifi.SelectedIndex.ToString();
                    txtPriceRange.Text = MainView.GetDataAdmin.ClassifySingleQueryML(query);
                    btnDT.Enabled = true;
                    btnML.Enabled = true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please digit numeric values");
                btnDT.Enabled = true;
                btnML.Enabled = true;
            }
        }
    }
}
