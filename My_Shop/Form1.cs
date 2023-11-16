using My_Shop.Models;
using System.ComponentModel;

namespace My_Shop
{
    public partial class Form1 : Form  //Main Form
    {
        BindingList<Product> buyPacage = new BindingList<Product>();
        public decimal sum;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBoxEnterCode.Select();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Form3 lookUpForm = new Form3();
            lookUpForm.Show();
        }

        private void button1_Click(object sender, EventArgs e) //Administarte button
        {
            if (txtBoxAdminPass.Text == "123")
            {
                txtBoxAdminPass.Text = string.Empty;
                Form2 adminForm = new Form2();
                adminForm.Show();
            }
            else
                MessageBox.Show("You mast enter Administrator Password", "Warning");
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (txtBoxEnterCode.Text != string.Empty)
            {

                using (MyShopContext dataBase = new MyShopContext())
                {
                    var product = dataBase.Products.Where(p => p.Code.Contains(txtBoxEnterCode.Text)).FirstOrDefault();
                    if (product != null && product.Quantity > int.Parse(txtBoxQty.Text))
                    {
                        var productForBuy = new Product()
                        {
                            Code = product.Code,
                            Name = product.Name,
                            Id = product.Id,
                            Price = product.Price,
                            Quantity = int.Parse(txtBoxQty.Text)
                        };

                        buyPacage.Add(productForBuy);

                        foreach (Product item in buyPacage)
                        {
                            sum = sum + (int)item.Quantity * item.Price;

                        }
                        lblSumValue.Text = sum.ToString();
                        dataGridView1.DataSource = buyPacage;
                        dataGridView1.Update();
                        txtBoxEnterCode.Text = string.Empty;
                        txtBoxQty.Text = string.Empty;

                    }
                    else
                    {
                        MessageBox.Show("There no such amount of products on storage");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter correct product code and qty into the CODE entry");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (buyPacage.Count > 0)
                {
                    buyPacage.Clear();
                }
                dataGridView1.DataSource = buyPacage;
                sum = 0;
                lblSumValue.Text = string.Empty;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (buyPacage.Count > 0)
            {
                using (MyShopContext dataBase = new MyShopContext())
                {
                    
                    foreach (Product item in buyPacage) 
                    {
                        var product = dataBase.Products.Where(p => p.Code == item.Code).FirstOrDefault();
                        product.Quantity -= item.Quantity; 
                    }
                    dataBase.SaveChanges();
                }
            }
            buyPacage.Clear();
            lblSumValue.Text = string.Empty;
            MessageBox.Show("Success. Thank you for your buings.");

        }
    }
}