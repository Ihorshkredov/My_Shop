namespace My_Shop
{
    partial class Form3
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
            txtBoxLookUp = new TextBox();
            button1 = new Button();
            dataGridFound = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridFound).BeginInit();
            SuspendLayout();
            // 
            // txtBoxLookUp
            // 
            txtBoxLookUp.Location = new Point(46, 52);
            txtBoxLookUp.Name = "txtBoxLookUp";
            txtBoxLookUp.Size = new Size(203, 27);
            txtBoxLookUp.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(286, 47);
            button1.Name = "button1";
            button1.Size = new Size(113, 37);
            button1.TabIndex = 1;
            button1.Text = "FIND";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridFound
            // 
            dataGridFound.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFound.Location = new Point(46, 106);
            dataGridFound.Name = "dataGridFound";
            dataGridFound.RowHeadersWidth = 51;
            dataGridFound.RowTemplate.Height = 29;
            dataGridFound.Size = new Size(723, 332);
            dataGridFound.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 19);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter product name";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridFound);
            Controls.Add(button1);
            Controls.Add(txtBoxLookUp);
            Name = "Form3";
            Text = "LOOK UP";
            ((System.ComponentModel.ISupportInitialize)dataGridFound).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxLookUp;
        private Button button1;
        private DataGridView dataGridFound;
        private Label label1;
    }
}