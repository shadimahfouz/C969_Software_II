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

    //Consultant report page that lists the appointments tied to each consultant.
    public partial class ConsultantReportPage : Form
    {
        public ConsultantReportPage()
        {
            InitializeComponent();
            ConScheduleGrid.DataSource = ConsultantReport();
        }

        public static Array ConsultantReport()
        {
            Dictionary<int, Hashtable> ConsultantReportStructure = AppDatabase.GetAppointments();

            var appList = from row in ConsultantReportStructure
                select new
                {
                    userName = row.Value["userName"], appType = row.Value["type"],
                    appStart = AppDatabase.TimezoneConversion(row.Value["start"].ToString()),
                    appEnd = AppDatabase.TimezoneConversion(row.Value["end"].ToString()), cust = row.Value["customerName"]
                };

            return appList.ToArray();
        }

        private void ConScheduleGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
