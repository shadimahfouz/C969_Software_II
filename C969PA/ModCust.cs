using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969PA
{

    //This page allows the user to modify customer information.
    public partial class ModCustPage : Form
    {
        public ModCustPage()
        {
            InitializeComponent();
        }

        public static Dictionary<string, string> modCustomer = new Dictionary<string, string>();

        public bool ModifiedCustomer(Dictionary<string, string> modForm) //Updates all tables containing customer information.
        {
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();

            string logUpdate = $"UPDATE customer" +
                               $" SET customerName = '{modForm["customerName"]}', active = '{modForm["active"]}', lastUpdate = '{AppDatabase.LogTimeStamp()}', lastUpdateBy = '{AppDatabase.GetUserName()}'" +
                               $" WHERE customerName = '{modCustomer["customerName"]}'";
            MySqlCommand command = new MySqlCommand(logUpdate, s);
            int moddedCust = command.ExecuteNonQuery();

            logUpdate = $"UPDATE address" +
                        $" SET address = '{modForm["address"]}', postalCode = '{modForm["postalCode"]}', phone = '{modForm["phone"]}', lastUpdate = '{AppDatabase.LogTimeStamp()}', lastUpdateBy = '{AppDatabase.GetUserName()}'" +
                        $" WHERE address = '{modCustomer["address"]}'";
            command = new MySqlCommand(logUpdate, s);
            int moddedAddress = command.ExecuteNonQuery();

            logUpdate = $"UPDATE city" +
                        $" SET city = '{modForm["city"]}', lastUpdate = '{AppDatabase.LogTimeStamp()}', lastUpdateBy = '{AppDatabase.GetUserName()}'" +
                        $" WHERE city = '{modCustomer["city"]}'";
            command = new MySqlCommand(logUpdate, s);
            int moddedCity = command.ExecuteNonQuery();

            logUpdate = $"UPDATE country" +
                        $" SET country = '{modForm["country"]}', lastUpdate = '{AppDatabase.LogTimeStamp()}', lastUpdateBy = '{AppDatabase.GetUserName()}'" +
                        $" WHERE country = '{modCustomer["country"]}'";
            command = new MySqlCommand(logUpdate, s);
            int moddedCountry = command.ExecuteNonQuery();
            s.Close();

            if (moddedCust != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModCustSearchButton_Click(object sender, EventArgs e) //Allows user to search customer by ID and returns all customer data.
        {
            int custId = AppDatabase.LookupCustomer(ModCustIDBox.Text);

            if (custId != 0)
            {
                modCustomer = AppDatabase.GetCustInfo(custId);
                ModCustNameBox.Text = modCustomer["customerName"];
                ModCustPhoneBox.Text = modCustomer["phone"];
                ModCustStreetBox.Text = modCustomer["address"];
                ModCustCityBox.Text = modCustomer["city"];
                ModCustZipBox.Text = modCustomer["postalCode"];
                ModCustCountryBox.Text = modCustomer["country"];

                if (modCustomer["active"] == "True")
                {
                    ActiveYesRadio.Checked = true;
                }
                else
                {
                    ActiveNoRadio.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Customer could not be located.", "Error");
            }
        }

        private void ModCustSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModCustNameBox.Text) || string.IsNullOrEmpty(ModCustPhoneBox.Text) ||
                string.IsNullOrEmpty(ModCustStreetBox.Text) || string.IsNullOrEmpty(ModCustCityBox.Text) ||
                string.IsNullOrEmpty(ModCustZipBox.Text) || string.IsNullOrEmpty(ModCustCountryBox.Text) ||
                (ActiveYesRadio.Checked == false && ActiveNoRadio.Checked == false))
            {
                MessageBox.Show("Fields cannot be left blank.", "Error");
            }
            else
            {
                Dictionary<string, string> saveMods = new Dictionary<string, string>();

                saveMods.Add("customerName", ModCustNameBox.Text);
                saveMods.Add("phone", ModCustPhoneBox.Text);
                saveMods.Add("address", ModCustStreetBox.Text);
                saveMods.Add("city", ModCustCityBox.Text);
                saveMods.Add("postalCode", ModCustZipBox.Text);
                saveMods.Add("country", ModCustCountryBox.Text);
                saveMods.Add("active", ActiveYesRadio.Checked ? "1" : "0");

                ModifiedCustomer(saveMods);
                MessageBox.Show("Customer information has been successfully modified.", "Success");
                Close();
            }
        }

        private void ModCustCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
