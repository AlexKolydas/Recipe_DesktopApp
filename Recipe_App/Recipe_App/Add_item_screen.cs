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

        public Add_item_screen()
        {
            InitializeComponent();
            dropdownCategory.Items.Add("Food");
            dropdownCategory.Items.Add("Sweet");

        }

        private void ingredientBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dropdownCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_item_screen_Load(object sender, EventArgs e)
        {

        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            //insert items from the form into the database
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                string dat = "Insert into [Table](Title,Category,Ingredients,Description) Values('" + titleTextBox.Text + "','" + dropdownCategory.Text + "','" + addIngredientTextBox.Text + "','" + addDescriptionTextBox.Text + "')";
                //SqlConnection sqlCon = new SqlConnection(connectionString);yh
                SqlCommand sqlCmd = new SqlCommand(dat, sqlCon);
                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                //sqlCon.Close();  We don't need that since "using(SqlConnection sqlCon....)) closes the connection automatically
            }
        }
    }
}
