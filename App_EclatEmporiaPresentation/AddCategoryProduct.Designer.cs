namespace App_EclatEmporiaPresentation
{
	partial class AddCategoryProduct
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
			textBox1 = new TextBox();
			namecatLab = new Label();
			descLab = new Label();
			textBox2 = new TextBox();
			addBtnCateg = new Button();
			UpdateBtnCat = new Button();
			DelBtnCateg = new Button();
			dataGridViewCateg = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridViewCateg).BeginInit();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(163, 41);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 0;
			// 
			// namecatLab
			// 
			namecatLab.AutoSize = true;
			namecatLab.Location = new Point(51, 44);
			namecatLab.Name = "namecatLab";
			namecatLab.Size = new Size(93, 15);
			namecatLab.TabIndex = 1;
			namecatLab.Text = "CategoryName :";
			// 
			// descLab
			// 
			descLab.AutoSize = true;
			descLab.Location = new Point(60, 94);
			descLab.Name = "descLab";
			descLab.Size = new Size(73, 15);
			descLab.TabIndex = 2;
			descLab.Text = "Description :";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(163, 86);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 23);
			textBox2.TabIndex = 3;
			// 
			// addBtnCateg
			// 
			addBtnCateg.Location = new Point(12, 173);
			addBtnCateg.Name = "addBtnCateg";
			addBtnCateg.Size = new Size(94, 23);
			addBtnCateg.TabIndex = 4;
			addBtnCateg.Text = "Add";
			addBtnCateg.UseVisualStyleBackColor = true;
			addBtnCateg.Click += addBtnCateg_Click;
			// 
			// UpdateBtnCat
			// 
			UpdateBtnCat.Location = new Point(133, 173);
			UpdateBtnCat.Name = "UpdateBtnCat";
			UpdateBtnCat.Size = new Size(75, 23);
			UpdateBtnCat.TabIndex = 5;
			UpdateBtnCat.Text = "Update";
			UpdateBtnCat.UseVisualStyleBackColor = true;
			UpdateBtnCat.Click += UpdateBtnCat_Click;
			// 
			// DelBtnCateg
			// 
			DelBtnCateg.Location = new Point(234, 177);
			DelBtnCateg.Name = "DelBtnCateg";
			DelBtnCateg.Size = new Size(75, 23);
			DelBtnCateg.TabIndex = 6;
			DelBtnCateg.Text = "Delete";
			DelBtnCateg.UseVisualStyleBackColor = true;
			DelBtnCateg.Click += DelBtnCateg_Click;
			// 
			// dataGridViewCateg
			// 
			dataGridViewCateg.BackgroundColor = SystemColors.ControlLightLight;
			dataGridViewCateg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCateg.Location = new Point(361, 12);
			dataGridViewCateg.Name = "dataGridViewCateg";
			dataGridViewCateg.Size = new Size(427, 184);
			dataGridViewCateg.TabIndex = 8;
			dataGridViewCateg.CellContentClick += dataGridViewCateg_CellContentClick;
			// 
			// AddCategoryProduct
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Highlight;
			ClientSize = new Size(800, 450);
			Controls.Add(dataGridViewCateg);
			Controls.Add(DelBtnCateg);
			Controls.Add(UpdateBtnCat);
			Controls.Add(addBtnCateg);
			Controls.Add(textBox2);
			Controls.Add(descLab);
			Controls.Add(namecatLab);
			Controls.Add(textBox1);
			Name = "AddCategoryProduct";
			Text = "AddCategory";
			
			((System.ComponentModel.ISupportInitialize)dataGridViewCateg).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label namecatLab;
		private Label descLab;
		private TextBox textBox2;
		private Button addBtnCateg;
		private Button UpdateBtnCat;
		private Button DelBtnCateg;
		private DataGridView dataGridViewCateg;
	}
}