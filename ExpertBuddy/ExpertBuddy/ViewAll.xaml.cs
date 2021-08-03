using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for ViewAll.xaml
    /// </summary>
    public partial class ViewAll : Window
    {
        public ViewAll()
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection("Data Source=SRDB\\SQLEXPRESS;Initial Catalog=velliangiri;Integrated Security=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from expert",connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dg.ItemsSource = table.DefaultView;
            }
        }
    }
}
