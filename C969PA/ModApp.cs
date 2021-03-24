using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;

namespace C969PA
{

    //This page allows user to modify appointments based on appointment ID.
    public partial class ModAppPage : Form
    {
        public ModAppPage()
        {
            InitializeComponent();
        }

        public DashboardPage modappButton; //Connects this page to Modify Appointment button on dashboard page.
        public static Dictionary<string, string> modApp = new Dictionary<string, string>();

        public static bool ModifiedApp(Dictionary<string, string> modForm)
        {
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();

            string logUpdate = $"UPDATE appointment" +
                               $" SET customerId = '{modForm["customerId"]}', type = '{modForm["type"]}', start = '{modForm["start"]}', end = '{modForm["end"]}', lastUpdate = '{AppDatabase.LogTimeStamp()}', lastUpdateBy = '{AppDatabase.LogTimeStamp()}'" +
                               $" WHERE appointmentId = '{modApp["appointmentId"]}'";
            MySqlCommand command = new MySqlCommand(logUpdate, s);
            int moddedApp = command.ExecuteNonQuery();

            if (moddedApp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ModAppSearchButton_Click(object sender, EventArgs e) //Allows user to look up appointment by ID, linked customer ID and appointment type are then pre-filled.
        {
            string appId = ModAppSearchBox.Text;
            modApp = AppDatabase.GetAppInfo(appId);
            ModAppIDBox.Text = modApp["customerId"];
            ModAppTypeBox.Text = modApp["type"];
        }

        private void ModAppSaveButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> saveMods = new Dictionary<string, string>();
            saveMods.Add("customerId", ModAppIDBox.Text);
            saveMods.Add("type", ModAppTypeBox.Text);
            saveMods.Add("start", ModAppStartBox.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"));
            saveMods.Add("end", ModAppEndBox.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"));

            if (ModifiedApp(saveMods))
            {
                modappButton.DashCalUpdate();
                MessageBox.Show("Appointment successfully modified.", "Success");
                Close();
            }
            else
            {
                MessageBox.Show("Could not update appointment.", "Error");
            }
        }

        private void ModAppCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}
