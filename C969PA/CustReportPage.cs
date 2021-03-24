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
        //This page creates a report that shows customers with appointments and displays the number of appointments that each customer has.
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

            IEnumerable<string>
                y = numAppointments.Select(i => i.Value["customerName"].ToString())
                    .Distinct(); //Lambda function that will enumerate through and pick up distinct customers from the appointment table, much less code required and more efficient than a standard function to perform the same operation.

            foreach (string x in y)
            {
                DataRow row = custDataTable.NewRow();
                row["Customer Name"] = x;

                row["Number of Appointments"] = numAppointments
                    .Where(i => i.Value["customerName"].ToString() == x.ToString()).Count()
                    .ToString(); //Lambda function that will count the number of appointments each distinct customer has and display the count next to the customer's name, much less code required than a traditional function to perform this action.

                custDataTable.Rows.Add(row);
            }

            return custDataTable;
        }
    }
}
