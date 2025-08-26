using project_xo2.View;
using qoutecontrol;
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

namespace project_xo2
{
    /// <summary>
    /// Interaction logic for MainForm.xaml
    /// </summary>
    public partial class MainForm : Window
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_Checked(object sender, RoutedEventArgs e)
        {
            QuoteControl qc = new QuoteControl();
            QuoteHost.Content = qc;
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BackApp_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            QuoteHost.Content = null; 
        }

        private void Btn_Unchecked_1(object sender, RoutedEventArgs e)
        {
            QuoteHost.Content = null;

        }

        private void Btn_Unchecked_2(object sender, RoutedEventArgs e)
        {
            QuoteHost.Content = null;

        }

        private void Btn_Unchecked_3(object sender, RoutedEventArgs e)
        {
            QuoteHost.Content = null;

        }

        private void Btn_Unchecked_4(object sender, RoutedEventArgs e)
        {
            QuoteHost.Content = null;
        }
    }
}
