using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Recipe_App
{
    public partial class Recipe_view_screen : Form
    {
        bool isEdit; //for the edit button
        //sqlite object
        Database_Items_Class databaseObject = new Database_Items_Class();

        public Recipe_view_screen()
        {
            InitializeComponent();
        }

        private void Recipe_view_screen_Load(object sender, EventArgs e)
        {
            //Display the title that is being selected from the viewlist in the previous screen.
            titleOfSelectedFood.Text = Listof_items_screen.foodTitle;
            //titleOfSelectedFood.SelectionAlignment = HorizontalAlignment.Center;//Align Title text in the center.

            //Create a list of this object to be filled with data from the database.
            List<Database_Items_Class> itemsFromDb = new List<Database_Items_Class>();

            //Search database Title and put all items with that title into a list.
            string query = "SELECT * from recipies WHERE Title='" + Listof_items_screen.foodTitle + "'";

            using (SQLiteCommand cmd = new SQLiteCommand(query, databaseObject.myConnection))
            {
                databaseObject.myConnection.Open();
                using (SQLiteDataReader reader = cmd.ExecuteReader())
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
                databaseObject.myConnection.Close();
            }
        }


        private void deleteRecipeButton_Click(object sender, EventArgs e)
        {
            //Delete the recipe from the database
            string dat = "DELETE from recipies WHERE Title='" + Listof_items_screen.foodTitle + "'";
            SQLiteCommand sqlCmd = new SQLiteCommand(dat, databaseObject.myConnection);
            databaseObject.myConnection.Open();
            sqlCmd.ExecuteNonQuery();
            databaseObject.myConnection.Close();

            MessageBox.Show("Recipe Has Successfully Been Deleted");
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
            string dat = "UPDATE recipies SET Ingredients='" + ingredientsTextBox.Text + "', Description='" + descriptionTextBox.Text + "' WHERE Title='" + titleOfSelectedFood.Text + "'";
            SQLiteCommand sqlCmd = new SQLiteCommand(dat, databaseObject.myConnection);
            databaseObject.myConnection.Open();
            sqlCmd.ExecuteNonQuery();
            databaseObject.myConnection.Close();

            this.Close(); //Closes the form programmatically.
        }

        private void titleOfSelectedFood_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Exported Into C:\\Recipies Folder!");
            Export_To_TXT.exportDB(); //Call function to export the recipe into a text file.
        }

        private void titleOfSelectedFood_MouseHover(object sender, EventArgs e)
        {
            titleOfSelectedFood.BackColor = Color.DarkCyan;
        }

        private void titleOfSelectedFood_MouseLeave(object sender, EventArgs e)
        {
            titleOfSelectedFood.BackColor = Color.Transparent;
        }

    }
}
