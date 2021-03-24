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

        public static bool TimeConflict(DateTime starTime, DateTime endTime) //Defines the time conflict exception that prevents appointment from being added if time conflicts with another appointment.
        {
            foreach (var app in AppDatabase.GetAppointments().Values)
            {
                if (starTime < DateTime.Parse(app["end"].ToString()) &&
                    DateTime.Parse(app["start"].ToString()) < endTime)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool BusinessHourConflict(DateTime starTime, DateTime endTime) //Defines business hour exception that prevents appointment from being added if start or end times fall outside of business hours.
        {
            starTime = starTime.ToLocalTime();
            endTime = endTime.ToLocalTime();
            DateTime openTime = DateTime.Today.AddHours(8);
            DateTime closeTime = DateTime.Today.AddHours(17);

            if (starTime.TimeOfDay > openTime.TimeOfDay && starTime.TimeOfDay < closeTime.TimeOfDay &&
                endTime.TimeOfDay > openTime.TimeOfDay && endTime.TimeOfDay < closeTime.TimeOfDay)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ModAppSaveButton_Click(object sender, EventArgs e)
        {
            /*Dictionary<string, string> saveMods = new Dictionary<string, string>();
            saveMods.Add("customerId", ModAppIDBox.Text);
            saveMods.Add("type", ModAppTypeBox.Text);
            saveMods.Add("start", ModAppStartBox.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"));
            saveMods.Add("end", ModAppEndBox.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"));*/

            string timestamp = AppDatabase.LogTimeStamp();
            int userid = AppDatabase.GetUserId();
            string username = AppDatabase.GetUserName();
            DateTime startTime = ModAppStartBox.Value.ToUniversalTime();
            DateTime endTime = ModAppEndBox.Value.ToUniversalTime();

            if (BusinessHourConflict(startTime, endTime))
            {
                //modappButton.DashCalUpdate();
                //MessageBox.Show("Appointment successfully modified.", "Success");
                //Close();
                MessageBox.Show(
                    "Appointment times fall out of normal business hours, please adjust start and/or end times and try again.",
                    "Error");
            }
            else if (TimeConflict(startTime, endTime))
            {
                MessageBox.Show(
                    "Appointment times conflict with another appointment, please adjust start and/or end times and try again.",
                    "Error");
            }
            else
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
            }
        }

        private void ModAppCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}
