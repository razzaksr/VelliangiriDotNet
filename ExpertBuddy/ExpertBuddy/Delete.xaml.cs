using System;
using System.Collections;
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
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Window
    {
        public Delete()
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection("Data Source = SRDB\\SQLEXPRESS; Initial Catalog = velliangiri; Integrated Security = True"))
            {
                combo.Items.Add("Select any id");
                connection.Open();
                SqlCommand cmd = new SqlCommand("select id from expert", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    combo.Items.Add((Int32)reader[0]);
                }
            }
        }
        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Selected item is: " + combo.SelectedItem.ToString());
            using (SqlConnection connection = new SqlConnection("Data Source = SRDB\\SQLEXPRESS; Initial Catalog = velliangiri; Integrated Security = True"))
            {
                connection.Open();
                //combo = new ComboBox();
                SqlCommand cmd = new SqlCommand("select * from expert where id=@i", connection);
                cmd.Parameters.AddWithValue("@i", Int32.Parse(combo.SelectedItem.ToString()));
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    name.Text = (String)reader[1];
                    String[] each = reader[2].ToString().Split(",");
                    skill.Items.Clear();
                    foreach (String i in each)
                    {
                        skill.Items.Add(i);
                    }

                    exp.Text = ((Double)reader[3]).ToString();
                }
            }
            name.Visibility = Visibility.Visible;
            skill.Visibility = Visibility.Visible;
            exp.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source = SRDB\\SQLEXPRESS; Initial Catalog = velliangiri; Integrated Security = True"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("delete from expert where id=@i", connection);

                cmd.Parameters.AddWithValue("@i", Int32.Parse(combo.SelectedItem.ToString()));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            name.Text = "";
            exp.Text = "";
            skill.Items.Clear();
        }
    }
}
