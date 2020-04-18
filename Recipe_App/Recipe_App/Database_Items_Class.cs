using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Recipe_App
{
    //This class is for getting all the data (Title,Category,Ingredients,Description) from database
    //and store them into variables.
    public class Database_Items_Class
    {
        public static string connectionString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alex\source\repos\ArekkusuTaichou\Recipe_DesktopApp\Recipe_App\Recipe_App\Database.mdf;Integrated Security=True;";
        public string Title { get; set; }
        public string Category { get; set; }
        public string Ingredients { get; set; }
        public string Description { get; set; }

        public SQLiteConnection myConnection;

        public Database_Items_Class()
        {
            myConnection = new SQLiteConnection("Data Source=recipies_db.sqlite3");

            if (!File.Exists("recipies_db.sqlite3")) // if database not exists, create it with the table and rows.
            {
                Console.WriteLine("Database file created");
                SQLiteConnection.CreateFile("recipies_db.sqlite3"); //Creates database
                
                //CREATE TABLE recipies AND ROWS IN DATABASE recipies_db
                string createTable = "CREATE TABLE recipies(Title TEXT NOT NULL,Category TEXT NOT NULL,Ingredients TEXT,Description TEXT,PRIMARY KEY(Title))";
                OpenConnection();
                SQLiteCommand cmd = new SQLiteCommand(createTable, myConnection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void OpenConnection()
        {
            if(myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
    }
}
