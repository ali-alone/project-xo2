using Microsoft.Data.SqlClient;
using project_xo2.user;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace project_xo2.View
{


    public partial class Login : Window
    {

        string sqlstr = ConfigurationManager.ConnectionStrings["sqlstr"].ConnectionString;

        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con1 = new SqlConnection(sqlstr);
            string cs = "SELECT * FROM login WHERE uuser = @uuser AND upass = @upass";
            SqlCommand c1 = new SqlCommand(cs, con1);
            c1.Parameters.AddWithValue("@uuser", textBox1.Text);
            c1.Parameters.AddWithValue("@upass", textBox2.Password);
            con1.Open();
            SqlDataReader dr = c1.ExecuteReader();
            if (dr.Read())
            {
                string admin = dr["uuser"].ToString();
                string pass = dr["upass"].ToString();

                if (admin == "admin" && pass == "12345")
                {
                    var mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                   this.Close();
                }

                else if (admin == "user" && pass == "12345")
                {
                    var userForm = new UserWINDOW();
                    userForm.Show();
                    this.Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("not exists");
                }
            }
            else
            {
                MessageBox.Show("not exists");
                con1.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Password = "";
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textBox3.Text = textBox2.Password;
            textBox3.Visibility = Visibility.Visible;
            textBox2.Visibility = Visibility.Collapsed;

        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox2.Password = textBox3.Text;
            textBox2.Visibility = Visibility.Visible;
            textBox3.Visibility = Visibility.Collapsed;
        }
    }
}
