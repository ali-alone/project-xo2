using System;
using System.Collections.Generic;
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

namespace project_xo2.user
{
    /// <summary>
    /// Interaction logic for UserWINDOW.xaml
    /// </summary>
    public partial class UserWINDOW : Window
    {
        public UserWINDOW()
        {
            InitializeComponent();
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BackApp_Click(object sender, RoutedEventArgs e)
        {
            var loginForm = new View.Login();
            loginForm.Show();
            this.Hide();
            this.Close();
        }

        private void Btn_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
