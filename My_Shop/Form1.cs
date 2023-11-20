using My_Shop.Models;
using System.ComponentModel;
using My_Shop.Servises;

namespace My_Shop
{
    public partial class Form1 : Form  //Main Form
    {
        List<ProductModel> buyPacage = new List<ProductModel>();

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
           new Form3().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) //Administarte button
        {
            if (txtBoxAdminPass.Text == "123")
            {   txtBoxAdminPass.Text = string.Empty;
                new Form2().ShowDialog();
            }
            else
                MessageBox.Show(ShowInfo.ShowNeedAdminPass());
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            WorkServise service = new WorkServise();
            if (int.TryParse(txtBoxQty.Text,out int result))
            {
               service.AddToPackage(buyPacage, txtBoxEnterCode.Text, result);
                lblSumValue.Text = service.GetTotalSum(buyPacage).ToString();
                dataGridView1.DataSource = buyPacage;
                ClearEntryFields();
            }
            else
            {
                MessageBox.Show(ShowInfo.WarningNotCorrectInput());
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
            WorkServise servise = new WorkServise();
            servise.BuyOrderFromShop( buyPacage );
            
            lblSumValue.Text = string.Empty;
            dataGridView1.DataSource = null;
            ClearEntryFields();  
            MessageBox.Show(ShowInfo.ShowSuccessBuy());
            dataGridView1.DataSource = buyPacage;

        }

        private void ClearEntryFields()
        {
            txtBoxQty.Text = string.Empty;
            txtBoxEnterCode.Text = string.Empty;
        }
    }
}