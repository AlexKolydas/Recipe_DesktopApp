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
        List<string> databaseData_food = new List<string>();

        //=============
        private DataTable dt;
        private DataView dv;
        private List<Recipe> recipies;
        ListViewItem lv_food;

        //=============
        //String for database connection
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

            dropDownSelectCategory.SelectedText = "--Choose Category--";

            foodListView.Columns.Add("Title",500);
            foodListView.Columns.Add("Category", 120);
            foodListView.View = View.Details;


            //=============
            dt = new DataTable();
            dt.Columns.Add("SweetList");
            dt.Columns.Add("FoodList");
            display_All_food("SELECT * from [Table]");
            //display_FoodList(); //call function to fetch and display data from database to listviews.

            //=============

        }
        //=============

        private List<Recipe> generateData(ListView databaseData)
        {
            foreach (ListViewItem item in databaseData.Items)
            {
                Console.WriteLine(item.Text);
                //Console.WriteLine(item);
                recipies = new List<Recipe>()
                {
                    new Recipe(item.Text)
                };
            }
            return recipies;
        }

        private void fillDataTable(List<string> recipies_food)
        {
            foreach (string item in recipies_food)
            {
                dt.Rows.Add(item);
            }

        }

        private void populateListView(DataView dv)
        {
            //foodListView.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                //sweetListView.Items.Add(new ListViewItem(new String[] { row[0].ToString() }));
                foodListView.Items.Add(new ListViewItem(new String[] { row[0].ToString() }));
            }
        }
        //=============

        private void display_All_food(string query)
        {
            //Connect to SQL and display the titles of food and sweet from database
            //Create a list with the queries i need (1 query for food and 1 for sweets)
            List<string> queryList = new List<string>();
            //string query1= "SELECT * from [Table] WHERE Category='Sweet'";

            //Create a list and insert all data from database so we can use them everywhere.

            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand(query, sqlCon);
            SqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();
            foodListView.Items.Clear();
            Dictionary<string, string> myDict = new Dictionary<string, string>();
            //Display the list of foods and sweets depending the query
            while (dataReader.Read())
            {
                lv_food = new ListViewItem(dataReader[0].ToString()); //Title
                lv_food.SubItems.Add(dataReader[1].ToString()); //Category
                lv_food.SubItems.Add(dataReader[2].ToString()); //Ingredients
                lv_food.SubItems.Add(dataReader[3].ToString()); //Description
                myDict.Add(dataReader[0].ToString(), dataReader[1].ToString());
                databaseData_food.Add(dataReader[0].ToString()); // Add title from database into a list.
                foodListView.Items.Add(lv_food); //Add into listview all the titles from database. ( Because we added 1 collumn)


                //=============
                //generateData(foodListView);
                //fillDataTable(databaseData_food);
                //fillDataTable(lv_sweets);
                dv = new DataView(dt);
                //populateListView(dv);
                //=============

            }
            foreach (KeyValuePair<string, string> kvp in myDict)
            {
                Console.WriteLine("DICTIONARY:" + kvp.Key);
            }
            dataReader.Close();
            cmd.Dispose();

            sqlCon.Close();
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


        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format(@"SweetList Like '%" + searchTextBox.Text + "%'");
            //dv.RowFilter = string.Format(@"FoodList Like '%" + searchTextBox.Text + "%'");

            populateListView(dv);
        }

        private void dropDownSelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "";
            if (dropDownSelectCategory.Text == "Food")
            {
                query = "SELECT * from [Table] WHERE Category='Food'";
            }
            else if (dropDownSelectCategory.Text == "Sweets")
            {
                query = "SELECT * from [Table] WHERE Category='Sweet'";
            }
            else
            {
                query = "SELECT * from [Table]";
            }
            display_All_food(query);
        }
    }

    class Recipe
    {
        private string title;

        public Recipe(string title)
        {
            this.title = title;
        }

        public string Title
        {
            get { return title; }
        }
    }
}
