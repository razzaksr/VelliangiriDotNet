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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source = SRDB\\SQLEXPRESS; Initial Catalog = velliangiri; Integrated Security = True"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from users where username=@u and password=@p",connection);
                cmd.Parameters.AddWithValue("@u", user.Text);
                cmd.Parameters.AddWithValue("@p", pass.Password);

                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    MessageBox.Show("Authorised login");
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            user.Text = "";
            pass.Password = "";
        }
    }
}
