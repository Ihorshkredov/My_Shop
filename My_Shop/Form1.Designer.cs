namespace My_Shop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnEdit = new Button();
            label3 = new Label();
            txtBoxQty = new TextBox();
            label1 = new Label();
            txtBoxEnterCode = new TextBox();
            btnADD = new Button();
            btnBuy = new Button();
            btnCheck = new Button();
            panel2 = new Panel();
            txtBoxAdminPass = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            lblSum = new Label();
            lblSumValue = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBoxQty);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBoxEnterCode);
            panel1.Controls.Add(btnADD);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 117);
            panel1.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(473, 66);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(117, 44);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 9);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 5;
            label3.Text = "Enter Quantity";
            // 
            // txtBoxQty
            // 
            txtBoxQty.Location = new Point(243, 32);
            txtBoxQty.Name = "txtBoxQty";
            txtBoxQty.Size = new Size(136, 27);
            txtBoxQty.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter Barcode";
            // 
            // txtBoxEnterCode
            // 
            txtBoxEnterCode.Location = new Point(3, 32);
            txtBoxEnterCode.Name = "txtBoxEnterCode";
            txtBoxEnterCode.Size = new Size(219, 27);
            txtBoxEnterCode.TabIndex = 2;
            // 
            // btnADD
            // 
            btnADD.Location = new Point(473, 14);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(119, 37);
            btnADD.TabIndex = 0;
            btnADD.Text = "ADD";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Click += btnADD_Click;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(757, 461);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(182, 39);
            btnBuy.TabIndex = 2;
            btnBuy.Text = "BUY";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(757, 146);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(134, 41);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "CHECK";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBoxAdminPass);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(712, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 111);
            panel2.TabIndex = 5;
            // 
            // txtBoxAdminPass
            // 
            txtBoxAdminPass.Location = new Point(20, 24);
            txtBoxAdminPass.Name = "txtBoxAdminPass";
            txtBoxAdminPass.Size = new Size(185, 27);
            txtBoxAdminPass.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(44, 58);
            button1.Name = "button1";
            button1.Size = new Size(126, 34);
            button1.TabIndex = 4;
            button1.Text = "ADMINISTRATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(717, 389);
            dataGridView1.TabIndex = 1;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSum.Location = new Point(778, 230);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(125, 31);
            lblSum.TabIndex = 6;
            lblSum.Text = "Total Sum :";
            // 
            // lblSumValue
            // 
            lblSumValue.AutoSize = true;
            lblSumValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSumValue.Location = new Point(788, 302);
            lblSumValue.Name = "lblSumValue";
            lblSumValue.Size = new Size(0, 25);
            lblSumValue.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 553);
            Controls.Add(lblSumValue);
            Controls.Add(lblSum);
            Controls.Add(panel2);
            Controls.Add(btnBuy);
            Controls.Add(btnCheck);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "My_Shop";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtBoxEnterCode;
        private Button btnCheck;
        private Button btnADD;
        private DataGridView dataGridView1;
        private Button btnBuy;
        private Button button1;
        private Panel panel2;
        private TextBox txtBoxAdminPass;
        private Label lblSum;
        private Label label3;
        private TextBox txtBoxQty;
        private Button btnEdit;
        private Label lblSumValue;
    }
}