using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_App
{
    public partial class First_screen : Form
    {
        public First_screen()
        {
            InitializeComponent();
        }

        private void showlistButton_Click(object sender, EventArgs e)
        {
            Listof_items_screen showList = new Listof_items_screen();
            showList.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add_item_screen add = new Add_item_screen();
            add.Show();
        }
    }
}
