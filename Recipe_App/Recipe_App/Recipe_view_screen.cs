using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Recipe_App
{
    public partial class Recipe_view_screen : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alex\source\repos\ArekkusuTaichou\Recipe_DesktopApp\Recipe_App\Recipe_App\Database.mdf;Integrated Security=True;";
        bool isEdit; //for the edit button

        public Recipe_view_screen()
        {
            InitializeComponent();
        }

        private void Recipe_view_screen_Load(object sender, EventArgs e)
        {
            //Display the title that is being selected from the viewlist in the previous screen.
            titleOfSelectedFood.Text = Listof_items_screen.foodTitle;
            titleOfSelectedFood.SelectionAlignment = HorizontalAlignment.Center;//Align Title text in the center.

            //Create a list of this object to be filled with data from the database.
            List<Database_Items_Class> itemsFromDb = new List<Database_Items_Class>();
            
            //Search database Title and put all items with that title into a list.
            string query = "SELECT * from [Table] WHERE Title='" + Listof_items_screen.foodTitle+"'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query,connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Database_Items_Class item = new Database_Items_Class(); //Create the object and fill it's variables with database data.
                            item.Title = reader.GetString(0);
                            item.Category = reader.GetString(1);
                            item.Ingredients = reader.GetString(2);
                            //ingredientsTextBox.Text = reader.GetString(2);
                            item.Description = reader.GetString(3);
                            itemsFromDb.Add(item);

                            //Display the corresponding database cells to the text boxes.
                            ingredientsTextBox.Text = item.Ingredients;
                            descriptionTextBox.Text = item.Description;
                        }
                    }
                    
                    connection.Close();
                }

            }
        }

        private void deleteRecipeButton_Click(object sender, EventArgs e)
        {
            //Delete the recipe from the database
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                string dat = "DELETE from [Table] WHERE Title='" + Listof_items_screen.foodTitle + "'";
                SqlCommand sqlCmd = new SqlCommand(dat, sqlCon);
                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                //sqlCon.Close();  We don't need that since "using(SqlConnection sqlCon....)) closes the connection automatically
            }
            this.Close(); //Closes the form programmatically.
        }

        private void editRecipeButton_Click(object sender, EventArgs e)
        {
            //If isEdit is false then make it true and let user edit the recipe.
            if (isEdit == false)
            {
                //titleOfSelectedFood.ReadOnly = false;
                ingredientsTextBox.ReadOnly = false;
                descriptionTextBox.ReadOnly = false;

                //titleOfSelectedFood.BackColor = Color.Gold;
                ingredientsTextBox.BackColor = Color.Gold;
                descriptionTextBox.BackColor = Color.Gold;

                editRecipeButton.Text = "Save";
                isEdit = true;
            }
            else
            {
                //titleOfSelectedFood.ReadOnly = true;
                ingredientsTextBox.ReadOnly = true;
                descriptionTextBox.ReadOnly = true;

                //titleOfSelectedFood.BackColor = Color.White;
                ingredientsTextBox.BackColor = Color.White;
                descriptionTextBox.BackColor = Color.White;

                editRecipeButton.Text = "Edit";
                isEdit = false;

                editRecipeInDatabase();

            }

        }

        private void editRecipeInDatabase()
        {
            //Edit the recipe from the database
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                string dat = "UPDATE [Table] SET Ingredients='" + ingredientsTextBox.Text + "', Description='" + descriptionTextBox.Text + "' WHERE Title='" + titleOfSelectedFood.Text + "'";
                SqlCommand sqlCmd = new SqlCommand(dat, sqlCon);
                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                //sqlCon.Close();  We don't need that since "using(SqlConnection sqlCon....)) closes the connection automatically
            }
            this.Close(); //Closes the form programmatically.
        }
    }
}
