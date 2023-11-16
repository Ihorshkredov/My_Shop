
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
    public partial class Form2 : Form //Administrative form
    {
        List<Product> products = new List<Product>();
        MyShopContext dataBase = new MyShopContext();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (txtBoxCode.Text != string.Empty &&
                txtBoxName.Text != string.Empty &&
                txtBoxPrice.Text != string.Empty &&
                txtBoxQuantity.Text != string.Empty)
            {
                
                bool priceIsOk = Decimal.TryParse(txtBoxPrice.Text, out decimal productPrice);
                bool QuantityIsOk = Int32.TryParse(txtBoxQuantity.Text, out int productQuantity);

                if ( priceIsOk && QuantityIsOk)
                {
                    Product productForAdd = new Product()
                    {
                        Code = txtBoxCode.Text,
                        Name = txtBoxName.Text,
                        Price = productPrice,
                        Quantity = productQuantity
                    };
                    try
                    {
                        dataBase.Products.Add(productForAdd);
                        dataBase.SaveChanges();
                        MessageBox.Show($"You add product Code - {productForAdd.Code} " +
                            $"with Price - {productForAdd.Price}, in quantity" +
                            $" - {productForAdd.Quantity} pcs", "Product added");
                        
                        dataGridView1.DataSource = dataBase.Products.ToList();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Problem with data insertion");
                    }
                }
            }
            else
                MessageBox.Show("Please fill all of the data before add " +
                    "product to the storage");
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            var productForRemove  = dataBase.Products.Where(p => p.Code == txtBoxCode.Text).FirstOrDefault(); 
            if ( productForRemove != null )
            {
                try
                {
                    dataBase.Products.Remove(productForRemove);
                    MessageBox.Show($"You removed product with Code: {productForRemove.Code} " +
                        $", {productForRemove.Name} , {productForRemove.Price}, {productForRemove.Quantity}");
                    dataBase.SaveChanges();
                    
                    dataGridView1.DataSource = dataBase.Products.ToList();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Deleting error");
                }
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var request = dataBase.Products;

            foreach (var product in request)
            {
                products.Add(product);
            }
            dataGridView1.DataSource = products;
            dataGridView1.Columns["ID"].Visible = false;

        }
    }
}
