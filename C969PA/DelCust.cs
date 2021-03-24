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

    //Page to delete customers
    public partial class DelCustPage : Form
    {
        public DelCustPage()
        {
            InitializeComponent();
        }

        public static Dictionary<string, string> custInfo = new Dictionary<string, string>();

        public bool DelCust() //Searches for and deletes customer based on Customer ID
        {
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();

            string logDeletion = $"DELETE FROM customer" +
                                 $" WHERE customerName = '{custInfo["customerName"]}'";
            MySqlCommand command = new MySqlCommand(logDeletion, s);
            int deletedCust = command.ExecuteNonQuery();

            logDeletion = $"DELETE FROM address" + $" WHERE address = '{custInfo["address"]}'";
            command = new MySqlCommand(logDeletion, s);
            int deletedAddress = command.ExecuteNonQuery();

            logDeletion = $"DELETE FROM city" + $" WHERE city = '{custInfo["city"]}'";
            command = new MySqlCommand(logDeletion, s);
            int deletedCity = command.ExecuteNonQuery();

            logDeletion = $"DELETE FROM country" + $" WHERE country = '{custInfo["country"]}'";
            command = new MySqlCommand(logDeletion, s);
            int deletedCountry = command.ExecuteNonQuery();

            s.Close();

            if (deletedCust != 0 && deletedAddress != 0 && deletedCity != 0 && deletedCountry != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void DelCustSearchButton_Click(object sender, EventArgs e) //Search button functionality, finds customer based on ID.
        {
            int custId = AppDatabase.LookupCustomer(DelCustSearchBox.Text);

            if (custId != 0)
            {
                custInfo = AppDatabase.GetCustInfo(custId);
                DelCustNameLabel.Text = custInfo["customerName"];
                DelCustPhoneLabel.Text = custInfo["phone"];
                DelCustAddressLabel.Text = custInfo["address"];
                DelCustCityLabel.Text = custInfo["city"];
                DelCustZipCode.Text = custInfo["postalCode"];
                DelCustCountryLabel.Text = custInfo["country"];

                if (custInfo["active"] == "True")
                {
                    DelCustActiveLabel.Text = "True";
                }
                else
                {
                    DelCustActiveLabel.Text = "False";
                }
            }
            else
            {
                MessageBox.Show("Customer could not be located in database. Please check ID and try again.", "Error");
            }
        }

        private void DelCustDelButton_Click(object sender, EventArgs e)
        {
            DialogResult delCustConfirm = MessageBox.Show("All customer appointments belonging to this customer must be deleted before you can delete this customer, have all appointments been deleted?",
                "Warning", MessageBoxButtons.YesNo);

            if (delCustConfirm == DialogResult.Yes)
            {
                DelCust();
                MessageBox.Show("Customer has been successfully deleted.", "Success");
            }
            else
            {
                MessageBox.Show($"{custInfo["customerName"]} could not be deleted.", "Error");
            }
        }

        private void DelCustCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
