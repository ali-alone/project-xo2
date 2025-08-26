using Microsoft.Identity.Client;
using project_xo2.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// <summary>
    /// Interaction logic for Teacherv.xaml
    /// </summary>
    public partial class Teacherv : UserControl
    {
        public Teacherv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            TeacherWM teacherWM = new TeacherWM(textbox1.Text, textbox2.Text, textbox3.Text, textbox4.Text);
            teacherWM.AddTeacher();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            TeacherWM teacherWM = new TeacherWM(textbox1.Text, textbox2.Text, textbox3.Text, textbox4.Text);
            teacherWM.UpdateTeacher();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            TeacherWM teacherWM = new TeacherWM(textbox1.Text, textbox2.Text, textbox3.Text, textbox4.Text);
            teacherWM.RemoveTeacher();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            TeacherWM teacherWM = new TeacherWM();
            DataTable dt = teacherWM.ShowTeachers();
            datagrid1.ItemsSource = dt.DefaultView;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            TeacherWM teacherWM = new TeacherWM();
            DataTable dataTable = teacherWM.SearchTeacher(textbox1.Text);
            datagrid1.ItemsSource = dataTable.DefaultView;

        }

        private void datagrid1_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)

        {
            if (datagrid1.SelectedItem != null)
            {
                textbox1.Text = ((DataRowView)datagrid1.SelectedItem).Row[0].ToString();
                textbox2.Text = ((DataRowView)datagrid1.SelectedItem).Row[1].ToString();
                textbox3.Text = ((DataRowView)datagrid1.SelectedItem).Row[2].ToString();
                textbox4.Text = ((DataRowView)datagrid1.SelectedItem).Row[3].ToString();
            }
        }
    }
}
