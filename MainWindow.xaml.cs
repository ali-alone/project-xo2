using System.Configuration;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Data;
using Microsoft.Data.SqlClient;


namespace project_xxx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string sqlstr = ConfigurationManager.ConnectionStrings["sqlstr"].ConnectionString;

        public MainWindow()
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
                    
                    
                }
                else
                {
                    Console.WriteLine("user");
                    //User form1 = new User();
                    //form1.show();
                    //this.Hide();
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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Password = "";
        }
    }
}