using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace ExpertBuddy
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        SqlConnection connection;
        SqlCommand cmd;
        public Register()
        {
            connection = new SqlConnection("Data Source=SRDB\\SQLEXPRESS;Initial Catalog=velliangiri;Integrated Security=True");
            connection.Open();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IList<Object> sks = (IList<Object>) skill.SelectedItems;
            String tmp = "";
            foreach(Object h in sks)
            {
                tmp += h + ",";
            }
            cmd = new SqlCommand("insert into expert(name,skill,exp) values(@a,@b,@c)", connection);
            cmd.Parameters.AddWithValue("@a",name.Text);
            cmd.Parameters.AddWithValue("@b", tmp);
            cmd.Parameters.AddWithValue("@c",Int32.Parse(exp.Text));

            cmd.ExecuteNonQuery();

            MessageBox.Show("Expert registered successfully");

            connection.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            name.Text = "";
            exp.Text="";
        }
    }
}
