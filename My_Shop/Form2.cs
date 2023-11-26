using My_Shop.Models;
using My_Shop.Helpers;
using My_Shop.Services;
using System.Data;

namespace My_Shop
{
    public partial class Form2 : Form 
    {
        private ProductService service; 

        public Form2()
        {
            InitializeComponent();
            service = new ProductService();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

			MessageBox.Show(MessageInfo.ShowWarnAboutProductAdd(txtBoxCode.Text, txtBoxName.Text,
                                                        txtBoxPrice.Text, txtBoxQuantity.Text));
            bool success = service.AddProductToStorage(txtBoxCode.Text, txtBoxName.Text,
                                        txtBoxPrice.Text, txtBoxQuantity.Text);

            MessageBox.Show(success ? MessageInfo.ShowSuccesMessage : MessageInfo.ShowFailMessage);
            dataGridView1.DataSource = service.ShowProductsInStorage();
            CleanForm();

        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            MessageBox.Show(MessageInfo.ShowWarnAboutProductDelete(txtBoxCode.Text, txtBoxName.Text,
                                                        txtBoxPrice.Text, txtBoxQuantity.Text));
            bool success = service.RemoveProductFromStorage(txtBoxCode.Text);

            MessageBox.Show(success ? MessageInfo.ShowSuccesMessage : MessageInfo.ShowFailMessage);
            dataGridView1.DataSource = service.ShowProductsInStorage();
            CleanForm();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtBoxCode.Focus();
            dataGridView1.DataSource = service.ShowProductsInStorage();

        }

        private void CleanForm()
        {
            txtBoxCode.Text = string.Empty;
            txtBoxName.Text = string.Empty;
            txtBoxPrice.Text = string.Empty;
            txtBoxQuantity.Text = string.Empty;
        }
    }
}
