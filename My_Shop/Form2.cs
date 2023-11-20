
using My_Shop.Models;
using My_Shop.Servises;
using System.Data;

namespace My_Shop
{
    public partial class Form2 : Form //Administrative form
    {
        WorkServise service = new WorkServise();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            MessageBox.Show(ShowInfo.WarnAboutProductAdd(txtBoxCode.Text, txtBoxName.Text,
                                                        txtBoxPrice.Text, txtBoxQuantity.Text));
            bool success = service.AddProductToStorage(txtBoxCode.Text, txtBoxName.Text,
                                        txtBoxPrice.Text, txtBoxQuantity.Text);

            MessageBox.Show(success ? ShowInfo.ShowSucces() : ShowInfo.ShowFail());
            dataGridView1.DataSource = service.ShowProductsInStorage();
            CleanForm();

        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            MessageBox.Show(ShowInfo.WarnAboutProductDelete(txtBoxCode.Text, txtBoxName.Text,
                                                        txtBoxPrice.Text, txtBoxQuantity.Text));
            bool success = service.RemoveProductFromStorage(txtBoxCode.Text);

            MessageBox.Show(success ? ShowInfo.ShowSucces() : ShowInfo.ShowFail());
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
