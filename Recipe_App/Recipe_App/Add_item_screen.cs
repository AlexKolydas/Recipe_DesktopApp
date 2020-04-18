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
using System.Data.SQLite;


namespace Recipe_App
{
    public partial class Add_item_screen : Form
    {
        //sqlite object
        Database_Items_Class databaseObject = new Database_Items_Class();

        bool correctTitle = false;
        bool correctDropdown = false;
        public Add_item_screen()
        {
            InitializeComponent();

            runAlwaysTimer.Start(); //Added a timer to run all the time.
            addItemButton.Enabled = false;

            dropdownCategory.Items.Add("Food");
            dropdownCategory.Items.Add("Sweet");
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {

            string query = "Insert into recipies (Title, Category, Ingredients, Description) Values('" + titleTextBox.Text + "','" + dropdownCategory.Text + "','" + addIngredientTextBox.Text + "','" + addDescriptionTextBox.Text + "')";
            SQLiteCommand sqlcmd = new SQLiteCommand(query, databaseObject.myConnection);
            databaseObject.OpenConnection();
            var resultExcecution = sqlcmd.ExecuteNonQuery();
            databaseObject.CloseConnection();
            Console.WriteLine("Rows Added: {0}", resultExcecution);
            this.Close(); //Closes the form programmatically.

        }

        private bool findIfTitleExists()
        {
            using (SqlConnection sqlCon = new SqlConnection(Database_Items_Class.connectionString))
            {
                string dat = "SELECT * FROM [TABLE]";
                SqlCommand sqlCmd = new SqlCommand(dat, sqlCon);
                sqlCon.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    if (titleTextBox.Text == reader[0].ToString())
                    {
                        return true;
                    }
                }
                reader.Close();
            }
            return false;
        }

        private void dropdownCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdownCategory.Text == "Food" || dropdownCategory.Text == "Sweet")
            {
                correctDropdown = true;
            }
            else
            {
                correctDropdown = false;
            }
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (titleTextBox.Text != "Add Title")
            {
                correctTitle = true;
            }
            else
            {
                correctTitle = false;
            }
        }

        private void runAlwaysTimer_Tick(object sender, EventArgs e)
        {
            enableAddButton();
        }

        private void enableAddButton()
        {
            if (correctTitle && correctDropdown)
            {
                addItemButton.Enabled = true;
            }
            else
            {
                addItemButton.Enabled = false;
            }
        }
    }
}