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
    /// Interaction logic for STCv.xaml
    /// </summary>
    public partial class STCv : UserControl
    {
        public STCv()
        {
            InitializeComponent();
            LoadStudent();

        }

        private void LoadStudent()
        {
            MyData db = new MyData();
            combobox1.ItemsSource = db.ShowDate("SELECT stno,stno + '_' +  stname + ' ' + stfamily AS FullName FROM sstudent").DefaultView;
            combobox1.DisplayMemberPath = "FullName";
            combobox1.SelectedValuePath = "stno";
            combobox2.ItemsSource = db.ShowDate("select tno,tno + '_' + tname AS FullT from teacher").DefaultView;
            combobox2.DisplayMemberPath = "FullT";
            combobox2.SelectedValuePath = "tno";
            combobox3.ItemsSource = db.ShowDate("select cno,cno + '_' + cname AS FullC from course").DefaultView;
            combobox3.DisplayMemberPath = "FullC";
            combobox3.SelectedValuePath = "cno";

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            STCWM sTCWM = new STCWM(combobox1.SelectedValue.ToString(), combobox2.SelectedValue.ToString(), combobox3.SelectedValue.ToString(), textbox1.Text, textbox2.Text);
            sTCWM.AddSTC();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            STCWM sTCWM = new STCWM(combobox1.SelectedValue.ToString(), combobox2.SelectedValue.ToString(), combobox3.SelectedValue.ToString(), textbox1.Text, textbox2.Text);
            sTCWM.UpdateSTC();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            STCWM sTCWM = new STCWM(combobox1.SelectedValue?.ToString(), combobox2.SelectedValue?.ToString(), combobox3.SelectedValue?.ToString(), textbox1.Text, textbox2.Text);
            sTCWM.deleteSTC();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            STCWM sTCWM = new STCWM();
            DataTable dataTable = sTCWM.ShowSTC();
            datagrid1.ItemsSource = dataTable.DefaultView;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            STCWM sTCWM = new STCWM(combobox1.SelectedValue.ToString(), combobox2.SelectedValue.ToString(), combobox3.SelectedValue.ToString(), textbox1.Text, textbox2.Text);
            DataTable dataTable = sTCWM.SearchSTC(combobox1.SelectedValue.ToString(), combobox2.SelectedValue.ToString(), combobox3.SelectedValue.ToString());
            datagrid1.ItemsSource = dataTable.DefaultView;
        }

        private void datagrid1_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (datagrid1.SelectedItem != null)
            {
                combobox1.SelectedValue = ((DataRowView)datagrid1.SelectedItem).Row[0].ToString();
                combobox2.SelectedValue = ((DataRowView)datagrid1.SelectedItem).Row[1].ToString();
                combobox3.SelectedValue = ((DataRowView)datagrid1.SelectedItem).Row[2].ToString();
                textbox1.Text = ((DataRowView)datagrid1.SelectedItem).Row[3].ToString();
                textbox2.Text = ((DataRowView)datagrid1.SelectedItem).Row[4].ToString();
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            combobox3.Text = "";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            combobox2.Text = "";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            combobox1.Text = "";
        }
    }
}
