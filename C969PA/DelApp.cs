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

    //Page where you can delete appointments
    public partial class DelAppPage : Form
    {
        public DelAppPage()
        {
            InitializeComponent();
        }

        public DashboardPage dashDelButton; //Connects the page to the Delete Appointment button on dashboard page.
        public static Dictionary<string, string> appInfo = new Dictionary<string, string>();

        public static bool DelApp() //Searches for and deletes appointment
        {
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();

            string logDeletion = $"DELETE FROM appointment" + 
                                 $" WHERE appointmentId = '{appInfo["appointmentId"]}'";
            MySqlCommand command = new MySqlCommand(logDeletion, s);
            int deletedApp = command.ExecuteNonQuery();
            s.Close();

            if (deletedApp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void DelAppIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DelAppSearchButton_Click(object sender, EventArgs e)
        {
            string appId = DelAppIDBox.Text;
            appInfo = AppDatabase.GetAppInfo(appId);
            DelAppTypeLabel.Text = appInfo["type"];
            DelAppCIDLabel.Text = appInfo["customerId"];
        }

        private void DelAppDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult delAppConfirm = MessageBox.Show("Are you sure you want to delete this appointment?",
                "Confirmation", MessageBoxButtons.YesNo);
            if (delAppConfirm == DialogResult.Yes)
            {
                if (DelApp())
                {
                    dashDelButton.DashCalUpdate();
                }
                else
                {
                    MessageBox.Show($"Customer appointment {appInfo["type"]} could not be deleted.", "Error");
                }
            }
            Close();
        }

        private void DelAppCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
