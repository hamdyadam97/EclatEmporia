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
            ((System.ComponentModel.ISupportInitialize)numericUpDownStockQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(138, 12);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 23);
            txtProductName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(138, 54);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(138, 106);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 2;
            // 
            // PnameLab
            // 
            PnameLab.AutoSize = true;
            PnameLab.Location = new Point(36, 20);
            PnameLab.Name = "PnameLab";
            PnameLab.Size = new Size(87, 15);
            PnameLab.TabIndex = 3;
            PnameLab.Text = "ProductName :";
            // 
            // PdesLab
            // 
            PdesLab.AutoSize = true;
            PdesLab.Location = new Point(36, 62);
            PdesLab.Name = "PdesLab";
            PdesLab.Size = new Size(73, 15);
            PdesLab.TabIndex = 4;
            PdesLab.Text = "Description :";
            // 
            // PpriceLab
            // 
            PpriceLab.AutoSize = true;
            PpriceLab.Location = new Point(54, 114);
            PpriceLab.Name = "PpriceLab";
            PpriceLab.Size = new Size(39, 15);
            PpriceLab.TabIndex = 5;
            PpriceLab.Text = "Price :";
            // 
            // numericUpDownStockQuantity
            // 
            numericUpDownStockQuantity.Location = new Point(138, 161);
            numericUpDownStockQuantity.Name = "numericUpDownStockQuantity";
            numericUpDownStockQuantity.Size = new Size(120, 23);
            numericUpDownStockQuantity.TabIndex = 6;
            // 
            // PupdownLab
            // 
            PupdownLab.AutoSize = true;
            PupdownLab.Location = new Point(32, 163);
            PupdownLab.Name = "PupdownLab";
            PupdownLab.Size = new Size(91, 15);
            PupdownLab.TabIndex = 7;
            PupdownLab.Text = "Stock Quantity :";
            // 
            // btnaAddProduct
            // 
            btnaAddProduct.Location = new Point(48, 277);
            btnaAddProduct.Name = "btnaAddProduct";
            btnaAddProduct.Size = new Size(75, 23);
            btnaAddProduct.TabIndex = 8;
            btnaAddProduct.Text = "Add";
            btnaAddProduct.UseVisualStyleBackColor = true;
            btnaAddProduct.Click += btnaAddProduct_Click;
            // 
            // comboBoxCategories
            // 
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.Location = new Point(137, 211);
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(121, 23);
            comboBoxCategories.TabIndex = 9;
            comboBoxCategories.SelectedIndexChanged += comboBoxCategories_SelectedIndexChanged;
            // 
            // CateLabProduct
            // 
            CateLabProduct.AutoSize = true;
            CateLabProduct.Location = new Point(40, 214);
            CateLabProduct.Name = "CateLabProduct";
            CateLabProduct.Size = new Size(69, 15);
            CateLabProduct.TabIndex = 10;
            CateLabProduct.Text = "Categories :";
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.GridColor = SystemColors.GrayText;
            dataGridViewProduct.Location = new Point(420, 20);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.Size = new Size(277, 197);
            dataGridViewProduct.TabIndex = 11;
            dataGridViewProduct.CellContentClick += dataGridViewProduct_CellContentClick;
            dataGridViewProduct.RowHeaderMouseClick += dataGridViewProduct_RowHeaderMouseClick;
            // 
            // BtnUpdateProduct
            // 
            BtnUpdateProduct.Location = new Point(173, 277);
            BtnUpdateProduct.Name = "BtnUpdateProduct";
            BtnUpdateProduct.Size = new Size(75, 23);
            BtnUpdateProduct.TabIndex = 12;
            BtnUpdateProduct.Text = "Update";
            BtnUpdateProduct.UseVisualStyleBackColor = true;
            BtnUpdateProduct.Click += BtnUpdateProduct_Click;
            // 
            // BtnDeleteProduct
            // 
            BtnDeleteProduct.Location = new Point(295, 277);
            BtnDeleteProduct.Name = "BtnDeleteProduct";
            BtnDeleteProduct.Size = new Size(75, 23);
            BtnDeleteProduct.TabIndex = 13;
            BtnDeleteProduct.Text = "Delete";
            BtnDeleteProduct.UseVisualStyleBackColor = true;
            BtnDeleteProduct.Click += BtnDeleteProduct_Click;
            // 
            // Add_Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Add_Product";
            Text = "Add_Product";
            Load += Add_Product_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownStockQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
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
	}
}