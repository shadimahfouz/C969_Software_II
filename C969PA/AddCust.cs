using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C969PA
{
    public partial class AddCustPage : Form
    {
        public AddCustPage()
        {
            InitializeComponent();
        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AddCustSave_Click(object sender, EventArgs e)
        {
            string timestamp = AppDatabase.LogTimeStamp();
            string userName = AppDatabase.GetUserName();
            if (string.IsNullOrEmpty(AddCustNameBox.Text) || string.IsNullOrEmpty(AddCustPhoneBox.Text) ||
                string.IsNullOrEmpty(AddCustStreetBox.Text) || string.IsNullOrEmpty(AddCustCityBox.Text) ||
                string.IsNullOrEmpty(AddCustZipBox.Text) || string.IsNullOrEmpty(AddCustCountryBox.Text) ||
                (ActiveYesRadio.Checked == false && ActiveNoRadio.Checked == false))
            {
                MessageBox.Show("Fields cannot be left blank.", "Error");
            }
            else
            {
                int countryId = AppDatabase.NewLog(timestamp, userName, "country", $"'{AddCustCountryBox.Text}'");
                int cityId = AppDatabase.NewLog(timestamp, userName, "city", $"'{AddCustCityBox.Text}', '{countryId}'");
                int strAddressId = AppDatabase.NewLog(timestamp, userName, "address",
                    $"'{AddCustStreetBox.Text}', '', '{cityId}', '{AddCustZipBox.Text}', '{AddCustPhoneBox.Text}'");
                AppDatabase.NewLog(timestamp, userName, "customer",
                    $"'{AddCustNameBox.Text}', '{strAddressId}', '{(ActiveYesRadio.Checked ? 1 : 0)}'");

                Close();
            }
        }

        private void AddCustCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
