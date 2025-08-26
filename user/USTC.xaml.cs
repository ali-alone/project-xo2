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
    /// Interaction logic for USTC.xaml
    /// </summary>
    public partial class USTC : UserControl
    {
        public USTC()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            USTCWM uSTCWM = new USTCWM();
            datagrid1.ItemsSource = uSTCWM.show().DefaultView;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            USTCWM uSTCWM = new USTCWM();
            datagrid1.ItemsSource = uSTCWM.search(textbox1.Text, textbox2.Text, textbox3.Text).DefaultView;
        }
    }
}
