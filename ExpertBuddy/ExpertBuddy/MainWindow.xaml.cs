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

namespace ExpertBuddy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String user = text1.Text;
            String pas = pass.Password;
            if (user.Equals("velliangiri") && pas.Equals("salem"))
            {
                MessageBox.Show("USer login sucess");
                text1.Text = "";
                pass.Password = "";
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            text1.Text = "";
            pass.Password = "";
        }
    }
}
