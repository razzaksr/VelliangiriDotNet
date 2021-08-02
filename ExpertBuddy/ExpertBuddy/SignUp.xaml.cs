using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection=new SqlConnection("Data Source = SRDB\\SQLEXPRESS; Initial Catalog = velliangiri; Integrated Security = True"))
            {
                connection.Open();
                if(pass.Password.Equals(conpass.Password))
                {
                    SqlCommand cmd = new SqlCommand("insert into users values(@u,@p)",connection);
                    cmd.Parameters.AddWithValue("@u", user.Text);
                    cmd.Parameters.AddWithValue("@p", pass.Password);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User has created");
                }
                else
                {
                    MessageBox.Show("Password mismatch");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            user.Text = "";
            pass.Password = "";
            conpass.Password = "";
        }
    }
}
