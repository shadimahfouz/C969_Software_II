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
    public partial class CustReportPage : Form
    {
        public CustReportPage()
        {
            InitializeComponent();
            CustReportGrid.DataSource = CustomerReport();
        }

        public static DataTable CustomerReport()
        {
            Dictionary<int, Hashtable> numAppointments = AppDatabase.GetAppointments();

            DataTable custDataTable = new DataTable();

            custDataTable.Clear();
            custDataTable.Columns.Add("Customer Name");
            custDataTable.Columns.Add("Number of Appointments");

            IEnumerable<string> y = numAppointments.Select(i => i.Value["customerName"].ToString()).Distinct(); //Lambda

            foreach (string x in y)
            {
                DataRow row = custDataTable.NewRow();
                row["Customer Name"] = y;

                row["Number of Appointments"] = numAppointments
                    .Where(i => i.Value["customerName"].ToString() == y.ToString()).Count().ToString(); //Lambda

                custDataTable.Rows.Add(row);
            }

            return custDataTable;
        }
    }
    public struct CustomerReportStructure
    {
        public string custName;
        public int numApps;
    }
}
