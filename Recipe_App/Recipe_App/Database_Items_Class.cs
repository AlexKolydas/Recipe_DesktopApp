using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_App
{
    //This class is for getting all the data (Title,Category,Ingredients,Description) from database
    //and store them into variables.
    public class Database_Items_Class
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Ingredients { get; set; }
        public string Description { get; set; }
    }
}
