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
    //This page adds appointment adding functionality
    public partial class AddAppPage : Form
    {
        public AddAppPage()
        {
            InitializeComponent();
            AddAppEndBox.Value = AddAppEndBox.Value.AddHours(1); //This adds one hour to the appointment end box for easy appointment adding.
        }

        public DashboardPage dashPageAddAppButton; //Connects this page to the Add Appointment button on the dashboard page.

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

        private void AddApp_Click_1(object sender, EventArgs e) //Save button for Add Appointment page.
        {
            string timestamp = AppDatabase.LogTimeStamp();
            int userid = AppDatabase.GetUserId();
            string username = AppDatabase.GetUserName();
            DateTime startTime = AddAppStartBox.Value.ToUniversalTime();
            DateTime endTime = AddAppEndBox.Value.ToUniversalTime();

            try
            {
                if (TimeConflict(startTime, endTime)) //This exception handler will prevent meetings from being scheduled if the timing conflicts with another.
                    throw new AppException();

                else
                {
                    try
                    {
                        if (BusinessHourConflict(startTime, endTime)) //This exception handler will prevent meetings from being scheduled if the start or end times of the meeting falls outside of normal business hours.
                        {
                            throw new AppException();
                        }
                        else
                        {
                            AppDatabase.NewLog(timestamp, username, "appointment",
                                $"'{AddAppIDBox.Text}', '{AddAppStartBox.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}', '{AddAppEndBox.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}', '{AppTypeBox.Text}'", //Saves start and end dates in proper MySQL date format.
                                userid);
                            dashPageAddAppButton.DashCalUpdate(); //Updates dashboard calendar to reflect appointment changes.

                            MessageBox.Show("Appointment successfully created.", "Success");
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
