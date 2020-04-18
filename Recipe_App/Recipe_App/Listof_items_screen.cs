using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_App
{
    public partial class Listof_items_screen : Form
    {
        List<string> databaseData_food = new List<string>();

        //=============
        private DataTable dt;
        private DataView dv;
        ListViewItem lv_food;
        //=============

        //sqlite object
        Database_Items_Class databaseObject = new Database_Items_Class();

        //This string is for getting the Title of the food we choose from the viewlist.
        //It's static because we will use it to other classes.
        public static string foodTitle;

        public Listof_items_screen()
        {
            InitializeComponent();
        }

        private void Listof_items_screen_Load(object sender, EventArgs e)
        {

            dropDownSelectCategory.SelectedText = "--Choose Category--";

            foodListView.Columns.Add("Title",500);
            foodListView.Columns.Add("Category", 120);
            foodListView.View = View.Details;


            dt = new DataTable();
            dt.Columns.Add("SweetList");
            dt.Columns.Add("FoodList");
            display_All_food("SELECT * from recipies");

        }


        private void display_All_food(string query)
        {
            //Connect to SQL and display the titles of food and sweet from database
            //Create a list with the queries i need (1 query for food and 1 for sweets)
            List<string> queryList = new List<string>();

            //Create a list and insert all data from database so we can use them everywhere.

            SQLiteCommand cmd = new SQLiteCommand(query, databaseObject.myConnection);
            databaseObject.OpenConnection();

            SQLiteDataReader dataReader;
            dataReader = cmd.ExecuteReader();
            foodListView.Items.Clear();
            //Display the list of foods and sweets depending the query
            while (dataReader.Read())
            {
                lv_food = new ListViewItem(dataReader[0].ToString()); //Title
                lv_food.SubItems.Add(dataReader[1].ToString()); //Category
                lv_food.SubItems.Add(dataReader[2].ToString()); //Ingredients
                lv_food.SubItems.Add(dataReader[3].ToString()); //Description

                databaseData_food.Add(dataReader[0].ToString()); // Add title from database into a list.
                foodListView.Items.Add(lv_food); //Add into listview all the titles from database. ( Because we added 1 collumn)

                dv = new DataView(dt);


            }
            dataReader.Close();
            cmd.Dispose();
            databaseObject.CloseConnection();
        }

        private void foodListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Get the name of the title which were double clicked from the Viewlist.
            foodTitle = foodListView.SelectedItems[0].SubItems[0].Text;
            //Click on item in viewlist and open the window that displays the recipe of that item.
            Recipe_view_screen add = new Recipe_view_screen();
            add.Show();
            this.Close();
        }

        private void dropDownSelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "";
            if (dropDownSelectCategory.Text == "Food")
            {
                query = "SELECT * from recipies WHERE Category='Food'";
            }
            else if (dropDownSelectCategory.Text == "Sweets")
            {
                query = "SELECT * from recipies WHERE Category='Sweet'";
            }
            else
            {
                query = "SELECT * from recipies";
            }
            display_All_food(query);
        }

    }

}
