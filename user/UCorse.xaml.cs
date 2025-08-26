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
    /// Interaction logic for UCorse.xaml
    /// </summary>
    public partial class UCorse : UserControl
    {
        public UCorse()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            UCourseWM uCourseWM = new UCourseWM();
            datagrid1.ItemsSource = uCourseWM.show().DefaultView;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            UCourseWM uCourseWM = new UCourseWM();
            datagrid1.ItemsSource = uCourseWM.search(textBox1.Text).DefaultView;
        }
    }
}
