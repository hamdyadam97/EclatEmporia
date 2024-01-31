namespace App_EclatEmporiaPresentation
{
    partial class Add_Product
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
            txtProductName = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            PnameLab = new Label();
            PdesLab = new Label();
            PpriceLab = new Label();
            numericUpDownStockQuantity = new NumericUpDown();
            PupdownLab = new Label();
            btnaAddProduct = new Button();
            comboBoxCategories = new ComboBox();
            CateLabProduct = new Label();
            dataGridViewProduct = new DataGridView();
            BtnUpdateProduct = new Button();
            BtnDeleteProduct = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            uploadImg = new Button();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStockQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(184, 149);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(150, 27);
            txtProductName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(184, 199);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(150, 27);
            txtDescription.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(184, 259);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 27);
            txtPrice.TabIndex = 2;
            // 
            // PnameLab
            // 
            PnameLab.AutoSize = true;
            PnameLab.Location = new Point(25, 160);
            PnameLab.Name = "PnameLab";
            PnameLab.Size = new Size(107, 20);
            PnameLab.TabIndex = 3;
            PnameLab.Text = "ProductName :";
            // 
            // PdesLab
            // 
            PdesLab.AutoSize = true;
            PdesLab.Location = new Point(46, 221);
            PdesLab.Name = "PdesLab";
            PdesLab.Size = new Size(92, 20);
            PdesLab.TabIndex = 4;
            PdesLab.Text = "Description :";
            // 
            // PpriceLab
            // 
            PpriceLab.AutoSize = true;
            PpriceLab.Location = new Point(80, 263);
            PpriceLab.Name = "PpriceLab";
            PpriceLab.Size = new Size(48, 20);
            PpriceLab.TabIndex = 5;
            PpriceLab.Text = "Price :";
            // 
            // numericUpDownStockQuantity
            // 
            numericUpDownStockQuantity.Location = new Point(184, 315);
            numericUpDownStockQuantity.Margin = new Padding(3, 4, 3, 4);
            numericUpDownStockQuantity.Name = "numericUpDownStockQuantity";
            numericUpDownStockQuantity.Size = new Size(137, 27);
            numericUpDownStockQuantity.TabIndex = 6;
            // 
            // PupdownLab
            // 
            PupdownLab.AutoSize = true;
            PupdownLab.Location = new Point(21, 317);
            PupdownLab.Name = "PupdownLab";
            PupdownLab.Size = new Size(112, 20);
            PupdownLab.TabIndex = 7;
            PupdownLab.Text = "Stock Quantity :";
            // 
            // btnaAddProduct
            // 
            btnaAddProduct.Location = new Point(21, 444);
            btnaAddProduct.Margin = new Padding(3, 4, 3, 4);
            btnaAddProduct.Name = "btnaAddProduct";
            btnaAddProduct.Size = new Size(86, 31);
            btnaAddProduct.TabIndex = 8;
            btnaAddProduct.Text = "Add";
            btnaAddProduct.UseVisualStyleBackColor = true;
            btnaAddProduct.Click += btnaAddProduct_Click;
            // 
            // comboBoxCategories
            // 
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.Location = new Point(184, 369);
            comboBoxCategories.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(138, 28);
            comboBoxCategories.TabIndex = 9;
            comboBoxCategories.SelectedIndexChanged += comboBoxCategories_SelectedIndexChanged;
            // 
            // CateLabProduct
            // 
            CateLabProduct.AutoSize = true;
            CateLabProduct.Location = new Point(46, 380);
            CateLabProduct.Name = "CateLabProduct";
            CateLabProduct.Size = new Size(87, 20);
            CateLabProduct.TabIndex = 10;
            CateLabProduct.Text = "Categories :";
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.GridColor = SystemColors.GrayText;
            dataGridViewProduct.Location = new Point(383, 5);
            dataGridViewProduct.Margin = new Padding(3, 4, 3, 4);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowHeadersWidth = 51;
            dataGridViewProduct.Size = new Size(752, 412);
            dataGridViewProduct.TabIndex = 11;
            dataGridViewProduct.CellContentClick += dataGridViewProduct_CellContentClick;
            dataGridViewProduct.RowHeaderMouseClick += dataGridViewProduct_RowHeaderMouseClick;
            // 
            // BtnUpdateProduct
            // 
            BtnUpdateProduct.Location = new Point(158, 444);
            BtnUpdateProduct.Margin = new Padding(3, 4, 3, 4);
            BtnUpdateProduct.Name = "BtnUpdateProduct";
            BtnUpdateProduct.Size = new Size(86, 31);
            BtnUpdateProduct.TabIndex = 12;
            BtnUpdateProduct.Text = "Update";
            BtnUpdateProduct.UseVisualStyleBackColor = true;
            BtnUpdateProduct.Click += BtnUpdateProduct_Click;
            // 
            // BtnDeleteProduct
            // 
            BtnDeleteProduct.Location = new Point(298, 444);
            BtnDeleteProduct.Margin = new Padding(3, 4, 3, 4);
            BtnDeleteProduct.Name = "BtnDeleteProduct";
            BtnDeleteProduct.Size = new Size(86, 31);
            BtnDeleteProduct.TabIndex = 13;
            BtnDeleteProduct.Text = "Delete";
            BtnDeleteProduct.UseVisualStyleBackColor = true;
            BtnDeleteProduct.Click += BtnDeleteProduct_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 56);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 27);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 60);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 15;
            label1.Text = "SearchByName :";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(438, 425);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(655, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // uploadImg
            // 
            uploadImg.Location = new Point(575, 553);
            uploadImg.Margin = new Padding(3, 4, 3, 4);
            uploadImg.Name = "uploadImg";
            uploadImg.Size = new Size(86, 31);
            uploadImg.TabIndex = 17;
            uploadImg.Text = "Upload";
            uploadImg.UseVisualStyleBackColor = true;
            uploadImg.Click += uploadImg_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Add_Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 600);
            Controls.Add(uploadImg);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(BtnDeleteProduct);
            Controls.Add(BtnUpdateProduct);
            Controls.Add(dataGridViewProduct);
            Controls.Add(CateLabProduct);
            Controls.Add(comboBoxCategories);
            Controls.Add(btnaAddProduct);
            Controls.Add(PupdownLab);
            Controls.Add(numericUpDownStockQuantity);
            Controls.Add(PpriceLab);
            Controls.Add(PdesLab);
            Controls.Add(PnameLab);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtProductName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Add_Product";
            Text = "Add_Product";
            Load += Add_Product_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownStockQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductName;
		private TextBox txtDescription;
		private TextBox txtPrice;
		private Label PnameLab;
		private Label PdesLab;
		private Label PpriceLab;
		private NumericUpDown numericUpDownStockQuantity;
		private Label PupdownLab;
		private Button btnaAddProduct;
		private ComboBox comboBoxCategories;
		private Label CateLabProduct;
		private DataGridView dataGridViewProduct;
		private Button BtnUpdateProduct;
		private Button BtnDeleteProduct;
		private TextBox textBox1;
		private Label label1;
		private PictureBox pictureBox1;
		private Button uploadImg;
		private OpenFileDialog openFileDialog1;
		private OpenFileDialog openFileDialog2;
	}
}