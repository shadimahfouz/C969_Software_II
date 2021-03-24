using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C969PA
{
    //Appointment report page that displays all appointments in database
    public struct AppReport
    {
        public string appMonth;
        public string appType;
        public int numApps;
    }
    public partial class AppReportPage : Form
    {
        public AppReportPage()
        {
            InitializeComponent();
            AppReportGrid.DataSource = AppReports();
        }

        public static Array AppReports()
        {
            List<AppReport> appList = new List<AppReport>();
            List<Hashtable> appType = new List<Hashtable>();
            SortedList appMonths = new SortedList();
            appMonths.Add(1, "January");
            appMonths.Add(2, "February");
            appMonths.Add(3, "March");
            appMonths.Add(4, "April");
            appMonths.Add(5, "May");
            appMonths.Add(6, "June");
            appMonths.Add(7, "July");
            appMonths.Add(8, "August");
            appMonths.Add(9, "September");
            appMonths.Add(10, "October");
            appMonths.Add(11, "November");
            appMonths.Add(12, "December");

            foreach (var appointment in AppDatabase.GetAppointments().Values)
            {
                int month = DateTime.Parse(appointment["start"].ToString()).Month;
                bool moreThanOne = false;

                foreach (AppReport app in appList)
                {
                    if (app.appMonth == appMonths[month].ToString() && app.appType == appointment["type"].ToString())
                    {
                        moreThanOne = true;
                    }
                }

                if (!moreThanOne)
                {
                    AppReport appReport = new AppReport();
                    appReport.appMonth = appMonths[month].ToString();
                    appReport.appType = appointment["type"].ToString();

                    //Lambda function to count distict types of appointments within the month and list how many of each type in the number column. 

                    appReport.numApps = AppDatabase.GetAppointments().Where(i =>
                        i.Value["type"].ToString() == appointment["type"].ToString() &&
                        DateTime.Parse(i.Value["start"].ToString()).Month == month).Count();

                    appList.Add(appReport);
                }
            }

            var appArray = from row in appList
                select new
                {
                    Month = row.appMonth,
                    Type = row.appType,
                    Number = row.numApps
                };

            return appArray.ToArray();
        }
    }
}
