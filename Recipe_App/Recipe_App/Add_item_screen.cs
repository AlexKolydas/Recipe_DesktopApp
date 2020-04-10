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
    public partial class Add_item_screen : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alex\source\repos\ArekkusuTaichou\Recipe_DesktopApp\Recipe_App\Recipe_App\Database.mdf;Integrated Security=True;";
        bool correctTitle =false;
        bool correctDropdown = false;
        public Add_item_screen()
        {
            InitializeComponent();
            runAlwaysTimer.Start();
            addItemButton.Enabled = false;

            dropdownCategory.Items.Add("Food");
            dropdownCategory.Items.Add("Sweet");
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            //insert items from the form into the database
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                string dat = "Insert into [Table](Title,Category,Ingredients,Description) Values('" + titleTextBox.Text + "','" + dropdownCategory.Text + "','" + addIngredientTextBox.Text + "','" + addDescriptionTextBox.Text + "')";
                SqlCommand sqlCmd = new SqlCommand(dat, sqlCon);
                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                //sqlCon.Close();  We don't need that since "using(SqlConnection sqlCon....)) closes the connection automatically
            }
            this.Close(); //Closes the form programmatically.
        }

        private void addDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dropdownCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdownCategory.Text=="Food" || dropdownCategory.Text == "Sweet")
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
            if(correctTitle && correctDropdown)
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