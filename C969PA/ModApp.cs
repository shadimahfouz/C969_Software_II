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
    public partial class ModAppPage : Form
    {
        public ModAppPage()
        {
            InitializeComponent();
        }

        public DashboardPage modappButton;
        public static Dictionary<string, string> modApp = new Dictionary<string, string>();

        public static bool ModifiedApp(Dictionary<string, string> modForm)
        {
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();

            string logUpdate = $"UPDATE appointment" +
                               $"SET customerId = '{modForm["customerId"]}', start = '{modForm["start"]}', end = '{modForm["end"]}', type = '{modForm["type"]}', lastUpdate = '{AppDatabase.LogTimeStamp()}', lastUpdateBy = '{AppDatabase.LogTimeStamp()}'" +
                               $"WHERE appointmentId = '{modApp["appointmentId"]}'";
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

        private void ModAppSearchButton_Click(object sender, EventArgs e)
        {
            string appId = ModAppSearchBox.Text;
            modApp = AppDatabase.GetAppInfo(appId);
            ModAppIDBox.Text = modApp["customerId"];
            ModAppTypeBox.Text = modApp["type"];
            ModAppStartBox.Value = DateTime.Parse(AppDatabase.TimezoneConversion(modApp["start"]));
            ModAppEndBox.Value = DateTime.Parse(AppDatabase.TimezoneConversion(modApp["end"]));
        }

        private void ModAppSaveButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> saveMods = new Dictionary<string, string>();
            saveMods.Add("customerId", ModAppIDBox.Text);
            saveMods.Add("type", ModAppTypeBox.Text);
            saveMods.Add("start", ModAppStartBox.Value.ToUniversalTime().ToString("u"));
            saveMods.Add("end", ModAppEndBox.Value.ToUniversalTime().ToString("u"));

            if (ModifiedApp(saveMods))
            {
                modappButton.DashCalUpdate();
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
