using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
