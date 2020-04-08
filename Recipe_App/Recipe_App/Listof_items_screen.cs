using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_App
{
    public partial class Listof_items_screen : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alex\source\repos\ArekkusuTaichou\Recipe_DesktopApp\Recipe_App\Recipe_App\Database.mdf;Integrated Security=True;";

        public Listof_items_screen()
        {
            InitializeComponent();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Listof_items_screen_Load(object sender, EventArgs e)
        {
            sweetListView.Columns.Add("List Of Sweets", 500);
            sweetListView.View = View.Details;

            foodListView.Columns.Add("List Of Food", 500);
            foodListView.View = View.Details;

            display_FoodList(); //call function to fetch and display data from database to listviews.

        }

        private void display_FoodList()
        {

            //Connect to SQL and display the titles of food and sweet from database
            //Create a list with the queries i need (1 query for food and 1 for sweets)
            List<string> queryList = new List<string>();
            queryList.Add("SELECT * from [Table] WHERE Category='Food'");
            queryList.Add("SELECT * from [Table] WHERE Category='Sweet'");

            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            //itterate the list and run each query
            foreach (var query in queryList)
            {
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                sweetListView.Items.Clear();

                //Display the list of foods and sweets depending the query
                while (dataReader.Read())
                {
                    if (query.Contains("Food") == true)
                    {
                        ListViewItem lv = new ListViewItem(dataReader[0].ToString());
                        foodListView.Items.Add(lv);
                    }
                    else
                    {
                        ListViewItem lv1 = new ListViewItem(dataReader[0].ToString());
                        sweetListView.Items.Add(lv1);
                    }
                }
                dataReader.Close();
                cmd.Dispose();
            }
                sqlCon.Close();
        }
    }
}
