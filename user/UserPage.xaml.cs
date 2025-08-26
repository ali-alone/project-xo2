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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace project_xo2.user
{
    /// <summary>
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : UserControl
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            UserWM userWM = new UserWM();
            datagrid1.ItemsSource = userWM.show().DefaultView;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            UserWM userWM = new UserWM();
            datagrid1.ItemsSource = userWM.search(textBox1.Text).DefaultView;
        }
    }
}
