using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969PA
{
    public partial class DashboardPage : Form
    {

        public LoginPage loginPage;
        public DashboardPage()
        {
            InitializeComponent();
            DashboardAppGrid.DataSource = DashAppCalendar(DashboardWeekRadio.Checked);
            AppReminder(DashboardAppGrid);
        }

        public static void AppReminder(DataGridView dashCalendar)
        {
            foreach (DataGridViewRow row in dashCalendar.Rows)
            {
                DateTime currentTime = DateTime.UtcNow;
                DateTime startTime = DateTime.Parse(row.Cells[2].Value.ToString()).ToUniversalTime();
                TimeSpan timeUntilApp = currentTime - startTime;

                if (timeUntilApp.TotalMinutes >= -15 && timeUntilApp.TotalMinutes < 1)
                {
                    MessageBox.Show(
                        $"You have an appointment coming up with {row.Cells[4].Value} at {row.Cells[2].Value}");
                }
            }
        }

        public static Array DashAppCalendar(bool week)
        {
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();

            string query =
                $"SELECT customerId, type, start, end, appointmentId, userId FROM appointment WHERE userId = '{AppDatabase.GetUserId()}'";
            MySqlCommand command = new MySqlCommand(query, s);
            MySqlDataReader reader = command.ExecuteReader();

            Dictionary<int, Hashtable> appointments = new Dictionary<int, Hashtable>();

            while (reader.Read())
            {
                Hashtable apps = new Hashtable();
                apps.Add("customerId", reader[0]);
                apps.Add("type", reader[1]);
                apps.Add("start", reader[2]);
                apps.Add("end", reader[3]);
                apps.Add("userId", reader[5]);
                
                appointments.Add(Convert.ToInt32(reader[4]), apps);
            }
            reader.Close();

            foreach (var app in appointments.Values)
            {
                query = $"SELECT userName FROM user WHERE userId = '{app["userId"]}'";
                command = new MySqlCommand(query, s);
                reader = command.ExecuteReader();
                reader.Read();
                app.Add("userName", reader[0]);
                reader.Close();
            }

            foreach (var app in appointments.Values)
            {
                query = $"SELECT customerName FROM customer WHERE customerId = '{app["customerId"]}'";
                command = new MySqlCommand(query, s);
                reader = command.ExecuteReader();
                reader.Read();
                app.Add("customerName", reader[0]);
                reader.Close();
            }

            Dictionary<int, Hashtable> addedApps = new Dictionary<int, Hashtable>();

            foreach (var app in appointments)
            {
                DateTime starTime = DateTime.Parse(app.Value["start"].ToString());
                DateTime endTime = DateTime.Parse(app.Value["end"].ToString());
                DateTime currDateTime = DateTime.UtcNow;

                if (week)
                {
                    DateTime sunday = currDateTime.AddDays(-(int) currDateTime.DayOfWeek);
                    DateTime saturday = currDateTime.AddDays(-(int) currDateTime.DayOfWeek + (int) DayOfWeek.Saturday);

                    if (starTime >= sunday && endTime < saturday)
                    {
                        addedApps.Add(app.Key, app.Value);
                    }
                }

                else
                {
                    DateTime firstOfMonth = new DateTime(currDateTime.Year, currDateTime.Month, 1);
                    DateTime lastOfMonth = firstOfMonth.AddMonths(1).AddDays(-1);

                    if (starTime >= firstOfMonth && endTime < lastOfMonth)
                    {
                        addedApps.Add(app.Key, app.Value);
                    }
                }
            }

            AppDatabase.SetAppointments(appointments);

            var appList = from row in addedApps
                select new
                {
                    appId = row.Key, appType = row.Value["type"],
                    appStart = AppDatabase.TimezoneConversion(row.Value["start"].ToString()),
                    appEnd = AppDatabase.TimezoneConversion(row.Value["end"].ToString()), cust = row.Value["customerName"]
                };

            s.Close();

            return appList.ToArray();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        public void DashCalUpdate()
        {
            DashboardAppGrid.DataSource = DashAppCalendar(DashboardWeekRadio.Checked);
        }

        private void DashboardAddCustButton_Click(object sender, EventArgs e)
        {
            AddCustPage addCust = new AddCustPage();
            addCust.Show();
        }

        private void DashboardModCustButton_Click(object sender, EventArgs e)
        {
            ModCustPage modCust = new ModCustPage();
            modCust.Show();
        }

        private void DashboardDelCustButton_Click(object sender, EventArgs e)
        {
            DelCustPage deleteCust = new DelCustPage();
            deleteCust.Show();
        }

        private void DashboardPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginPage.Close();
        }

        private void DashboardWeekRadio_CheckedChanged(object sender, EventArgs e)
        {
            DashCalUpdate();
        }

        private void DashboardAddAppButton_Click(object sender, EventArgs e)
        {
            AddAppPage addApp = new AddAppPage();
            addApp.dashPageAddAppButton = this;
            addApp.Show();
        }

        private void DashboardModAppButton_Click(object sender, EventArgs e)
        {
            ModAppPage modApp = new ModAppPage();
            modApp.modappButton = this;
            modApp.Show();
        }

        private void DashboardDelAppButton_Click(object sender, EventArgs e)
        {
            DelAppPage deleteApp = new DelAppPage();
            deleteApp.dashDelButton = this;
            deleteApp.Show();
        }

        private void DashboardAppReportButton_Click(object sender, EventArgs e)
        {
            AppReportPage appReport = new AppReportPage();
            appReport.Show();
        }

        private void DashboardConReportButton_Click(object sender, EventArgs e)
        {
            ConsultantReportPage conReports = new ConsultantReportPage();
            conReports.Show();
        }

        private void DashboardCustReportButton_Click(object sender, EventArgs e)
        {
            CustReportPage custReports = new CustReportPage();
            custReports.Show();
        }
    }

}
