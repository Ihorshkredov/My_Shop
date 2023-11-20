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
using My_Shop.Servises;

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
            dataGridFound.DataSource = null;

            WorkServise servise = new WorkServise();

            List<ProductModel> foundProducts = servise.GetModelByName(txtBoxLookUp.Text);

            dataGridFound.DataSource = foundProducts;
       
        }
    }
}
