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
    /// Interaction logic for UTeacher.xaml
    /// </summary>
    public partial class UTeacher : UserControl
    {
        public UTeacher()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            UTeacherWM uTeacherWM = new UTeacherWM();
            datagrid1.ItemsSource = uTeacherWM.search(textBox1.Text).DefaultView;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            UTeacherWM uTeacherWM = new UTeacherWM();
            datagrid1.ItemsSource = uTeacherWM.show().DefaultView;
        }
    }
}
