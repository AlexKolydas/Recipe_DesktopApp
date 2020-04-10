using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using NLog.Internal;
using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace Recipe_App
{
    /// <summary>
    /// This class is exporting the recipe (based on the title) into a text file)
    /// </summary>
    public class Export_To_TXT
    {
        static string V = @"C:\Recipies\" + Listof_items_screen.foodTitle + "_recipe.txt";
        static string folder_Creation = @"C:\Recipies\";
        //static string V = @"C:\Recipies\teeest.txt";


        public static void exportDB() 
        {
            Directory.CreateDirectory(folder_Creation);
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alex\source\repos\ArekkusuTaichou\Recipe_DesktopApp\Recipe_App\Recipe_App\Database.mdf;Integrated Security=True;";
            SqlDataReader reader;
            string query = "SELECT * FROM [Table] WHERE Title='"+Listof_items_screen.foodTitle+"'";
            string strDelimiter = "\n";
            string strFilePath = V;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (reader = new SqlCommand(query, conn).ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        StringBuilder sb = new StringBuilder();
                        Object[] items = new Object[reader.FieldCount];
                        List<Database_Items_Class> itemsFromDb = new List<Database_Items_Class>();
                        Database_Items_Class item = new Database_Items_Class(); //Create the object and fill it's variables with database data.

                        while (reader.Read())
                        {
                            reader.GetValues(items);
                            item.Title = reader.GetString(0);
                            item.Category = reader.GetString(1);
                            item.Ingredients = reader.GetString(2);
                            //ingredientsTextBox.Text = reader.GetString(2);
                            item.Description = reader.GetString(3);
                            itemsFromDb.Add(item);
                            //Console.WriteLine(item.Ingredients);
                            // Using two sb.Append is better because if you 
                            // concat the two strings it will first build a new string
                            // and then discard it after its use.
                            //sb.Append(strDelimiter);
                            //sb.Append(item.ToString());
                        }

                        //Write into txt file
                        sb.Append("Title: " + item.Title+ "\n");
                        sb.Append("===========================================================================\n");
                        sb.Append("Ingredients: \n\n"+item.Ingredients+"\n");
                        sb.Append("===========================================================================\n");
                        sb.Append("Description: \n\n"+item.Description+ "\n");

                        File.WriteAllText(strFilePath, sb.ToString());
                    }
                    }
                    conn.Close();
                }
            }
        }
    }


