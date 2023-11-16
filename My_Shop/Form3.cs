using My_Shop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Shop
{
    public partial class Form3 : Form //Look Up form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtBoxLookUp.Text != string.Empty)
            {
                using (var database = new MyShopContext())
                {
                    var request = database.Products.Where(p => p.Name.ToLower().Contains(txtBoxLookUp.Text.ToLower())).ToList();

                    if (request.Count > 0)
                    {
                        dataGridFound.DataSource = request;
                    }
                    else 
                    {
                        MessageBox.Show("No such products found", "Warning");
                    }

                }

            }
        }
    }
}
