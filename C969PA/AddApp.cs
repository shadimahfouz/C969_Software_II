using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C969PA
{
    public partial class AddAppPage : Form
    {
        public AddAppPage()
        {
            InitializeComponent();
            AddAppEndBox.Value = AddAppEndBox.Value.AddHours(1);
        }

        public DashboardPage dashboardCalendar;

        public static bool TimeConflict(DateTime starTime, DateTime endTime)
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

        public static bool BusinessHourConflict(DateTime starTime, DateTime endTime)
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

        private void AddApp_Click_1(object sender, EventArgs e)
        {
            string timestamp = AppDatabase.LogTimeStamp();
            int userid = AppDatabase.GetUserId();
            string username = AppDatabase.GetUserName();
            DateTime startTime = AddAppStartBox.Value.ToUniversalTime();
            DateTime endTime = AddAppEndBox.Value.ToUniversalTime();

            try
            {
                if (TimeConflict(startTime, endTime))
                    throw new AppException();

                else
                {
                    try
                    {
                        if (BusinessHourConflict(startTime, endTime))
                        {
                            throw new AppException();
                        }
                        else
                        {
                            AppDatabase.NewLog(timestamp, username, "appointment",
                                $"'{AddAppIDBox.Text}', '{AddAppStartBox.Value.ToUniversalTime().ToString("u")}', '{AddAppEndBox.Value.ToUniversalTime().ToString("u")}', '{AppTypeBox.Text}'",
                                userid);
                            dashboardCalendar.UpdateCalendar();
                            Close();
                        }
                    }
                    catch (AppException ex)
                    {
                        ex.BusinessHours();
                    }
                }
            }
            catch (AppException ex)
            {
                ex.AppTimeConflict();
            }
        }

        private void CancelAddApp_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddAppPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
