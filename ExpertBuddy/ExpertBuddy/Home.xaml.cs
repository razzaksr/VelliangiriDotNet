using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExpertBuddy
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            ViewAll view = new ViewAll();
            view.Show();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Delete del = new Delete();
            del.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
