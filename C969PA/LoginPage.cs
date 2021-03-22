using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969PA
{
    public partial class LoginPage : Form
    {

        public string loginError = "Username and/or password do not match our records.";
        public LoginPage()
        {
            InitializeComponent();

            if (CultureInfo.CurrentUICulture.LCID == 2058)
            {
                label3.Text = "Bienvenido!";
                UserLabel.Text = "Nombre De Usario:";
                PassLabel.Text = "Contraseña:";
                LoginButton.Text = "Acceso";
                LoginCancelButton.Text = "Cancelar";
                loginError = "El nombre de usuario y / o la contraseña no coinciden con nuestros registros.";
            }
        }

        public static int VerifyLogin(string username, string password)
        {
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();
            MySqlCommand command =
                new MySqlCommand($"SELECT userId FROM user WHERE userName = '{username}' AND password = '{password}'",
                    s);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                AppDatabase.SetUserId(Convert.ToInt32(reader[0]));
                AppDatabase.SetUserName(username);
                reader.Close();
                s.Close();

                return AppDatabase.GetUserId();
            }

            return 0;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (VerifyLogin(UserText.Text, PassText.Text) != 0)
            {
                this.Hide();
                DashboardPage dashboardPage = new DashboardPage();
                dashboardPage.loginPage = this;
                ActivityLog.TrackUserLogin(AppDatabase.GetUserId());
                dashboardPage.Show();
            }
            else
            {
                MessageBox.Show(loginError, "Error");
                PassText.Text = "";
            }
        }

        private void LoginCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
