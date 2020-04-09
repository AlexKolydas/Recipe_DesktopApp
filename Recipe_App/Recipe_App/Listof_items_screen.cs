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
        
        //This string is for getting the Title of the food we choose from the viewlist.
        //It's static because we will use it to other classes.
        public static string foodTitle; 
        
        public Listof_items_screen()
        {
            InitializeComponent();
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
                        ListViewItem lv_food = new ListViewItem(dataReader[0].ToString()); //Title
                        lv_food.SubItems.Add(dataReader[1].ToString()); //Category
                        lv_food.SubItems.Add(dataReader[2].ToString()); //Ingredients
                        lv_food.SubItems.Add(dataReader[3].ToString()); //Description

                        foodListView.Items.Add(lv_food);
                    }
                    else
                    {
                        ListViewItem lv_sweets = new ListViewItem(dataReader[0].ToString()); //Title
                        lv_sweets.SubItems.Add(dataReader[1].ToString()); //Category
                        lv_sweets.SubItems.Add(dataReader[2].ToString()); //Ingredients
                        lv_sweets.SubItems.Add(dataReader[3].ToString()); //Description
                        sweetListView.Items.Add(lv_sweets);
                    }
                    
                }
                dataReader.Close();
                cmd.Dispose();
            }
                sqlCon.Close();
        }

        private void foodListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Get the name of the title which were double clicked from the Viewlist.
            foodTitle = foodListView.SelectedItems[0].SubItems[0].Text; 

            //Click on item in viewlist and open the window that displays the recipe of that item.
            Recipe_view_screen add = new Recipe_view_screen();
            add.Show();
        }

        private void sweetListView_DoubleClick(object sender, EventArgs e)
        {
            //Get the name of the title which were double clicked from the Viewlist.
            foodTitle = sweetListView.SelectedItems[0].SubItems[0].Text;

            //Click on item in viewlist and open the window that displays the recipe of that item.
            Recipe_view_screen add = new Recipe_view_screen();
            add.Show();
        }
    }
}
