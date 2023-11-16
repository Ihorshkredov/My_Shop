namespace My_Shop
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtBoxCode = new TextBox();
            label2 = new Label();
            txtBoxName = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            txtBoxQuantity = new TextBox();
            label4 = new Label();
            txtBoxPrice = new TextBox();
            btnADD = new Button();
            dataGridView1 = new DataGridView();
            btnRem = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter product data";
            // 
            // txtBoxCode
            // 
            txtBoxCode.Location = new Point(15, 44);
            txtBoxCode.Name = "txtBoxCode";
            txtBoxCode.Size = new Size(163, 27);
            txtBoxCode.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 12);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 2;
            label2.Text = "Code";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(209, 44);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(145, 27);
            txtBoxName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 12);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBoxQuantity);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtBoxPrice);
            panel1.Controls.Add(txtBoxCode);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBoxName);
            panel1.Location = new Point(191, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 97);
            panel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(547, 8);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 8;
            label5.Text = "Quantity";
            // 
            // txtBoxQuantity
            // 
            txtBoxQuantity.Location = new Point(546, 43);
            txtBoxQuantity.Name = "txtBoxQuantity";
            txtBoxQuantity.Size = new Size(125, 27);
            txtBoxQuantity.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 10);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 6;
            label4.Text = "Price";
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(392, 43);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(125, 27);
            txtBoxPrice.TabIndex = 5;
            // 
            // btnADD
            // 
            btnADD.Location = new Point(210, 137);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(178, 54);
            btnADD.TabIndex = 6;
            btnADD.Text = "ADD";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Click += btnADD_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(925, 235);
            dataGridView1.TabIndex = 7;
            // 
            // btnRem
            // 
            btnRem.Location = new Point(407, 137);
            btnRem.Name = "btnRem";
            btnRem.Size = new Size(139, 54);
            btnRem.TabIndex = 8;
            btnRem.Text = "REMOVE";
            btnRem.UseVisualStyleBackColor = true;
            btnRem.Click += btnRem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 458);
            Controls.Add(btnRem);
            Controls.Add(dataGridView1);
            Controls.Add(btnADD);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "ADMINISTRATION";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxCode;
        private Label label2;
        private TextBox txtBoxName;
        private Label label3;
        private Panel panel1;
        private TextBox txtBoxQuantity;
        private Label label4;
        private TextBox txtBoxPrice;
        private Label label5;
        private Button btnADD;
        private DataGridView dataGridView1;
        private Button btnRem;
    }
}