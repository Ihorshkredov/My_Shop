using My_Shop.Models;
using System.ComponentModel;
using My_Shop.Servises;

namespace My_Shop
{
    public partial class Form1 : Form  //Main Form
    {
        List<ProductModel> buyPacage; 

        public decimal sum;

        public Form1()
        {
            InitializeComponent();
            buyPacage = new List<ProductModel>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBoxEnterCode.Select();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
           new Form3().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) //Administarte button
        {
            if (txtBoxAdminPass.Text == "123")
            {   
                txtBoxAdminPass.Text = string.Empty;
                new Form2().ShowDialog();
            }
            else
                MessageBox.Show(MessageInfo.ShowNeedAdminPassMessage);
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            ProductServise service = new ProductServise();

            if (int.TryParse(txtBoxQty.Text,out int result))
            {
                service.AddToPackage(buyPacage, txtBoxEnterCode.Text, result);
                lblSumValue.Text = DisplayTotalSum(buyPacage).ToString();
                dataGridView1.DataSource = buyPacage;
                ClearEntryFields();
            }
            else
            {
                MessageBox.Show(MessageInfo.WarningNotCorrectInputMessage);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
                if (buyPacage.Any())
                {
                    buyPacage.Clear();
                }

                ClearEntryFields();
                dataGridView1.DataSource = null;
                lblSumValue.Text = string.Empty;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            ProductServise servise = new ProductServise();
            servise.BuyOrderFromShop( buyPacage );
            
            lblSumValue.Text = string.Empty;
            dataGridView1.DataSource = null;
           
            ClearEntryFields(); 
            MessageBox.Show(MessageInfo.ShowSuccessBuyMessage);
            dataGridView1.DataSource = buyPacage;

        }

        private void ClearEntryFields()
        {
            txtBoxQty.Text = string.Empty;
            txtBoxEnterCode.Text = string.Empty;
        }

        private double DisplayTotalSum( List<ProductModel> buyPakcage)
        {
			double sum = 0;
			if (buyPacage.Any())
			{
				foreach (var item in buyPacage)
				{
					sum += (int)item.Quantity * (double)item.Price;
				}
			}
			return sum;

		}
    }
}