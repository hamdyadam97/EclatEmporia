namespace App_EclatEmporiaPresentation
{
    partial class ShowProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowProducts));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(40, 167);
            listView1.Margin = new Padding(4, 3, 4, 3);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(912, 324);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Product ID";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Product Name";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Description";
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Price";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Quantity";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Date";
            columnHeader6.Width = 150;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Control;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(988, 65);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(342, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Location = new Point(168, 607);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(129, 29);
            button2.TabIndex = 3;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(462, 607);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(129, 29);
            button3.TabIndex = 4;
            button3.Text = "The Cart";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(253, 65);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 30);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1202, 235);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 30);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1202, 326);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 30);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1202, 417);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(170, 30);
            textBox4.TabIndex = 8;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(1005, 235);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 27);
            label1.TabIndex = 9;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(1005, 329);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 27);
            label2.TabIndex = 10;
            label2.Text = "Product Price";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(1005, 417);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(160, 27);
            label3.TabIndex = 11;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(73, 68);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(148, 27);
            label4.TabIndex = 12;
            label4.Text = "Search ";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(698, 68);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(241, 24);
            label5.TabIndex = 13;
            label5.Text = "Choose The Category";
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(1022, 130);
            label6.Name = "label6";
            label6.Size = new Size(107, 28);
            label6.TabIndex = 14;
            label6.Text = "The Cart";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1145, 127);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 30);
            textBox5.TabIndex = 15;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(976, 489);
            label7.Name = "label7";
            label7.Size = new Size(174, 25);
            label7.TabIndex = 16;
            label7.Text = "Product Image";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1202, 489);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(749, 603);
            button1.Name = "button1";
            button1.Size = new Size(190, 33);
            button1.TabIndex = 18;
            button1.Text = "Show My Orders";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(300, 544);
            button4.Name = "button4";
            button4.Size = new Size(121, 30);
            button4.TabIndex = 19;
            button4.Text = "Previous";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(594, 544);
            button5.Name = "button5";
            button5.Size = new Size(121, 30);
            button5.TabIndex = 20;
            button5.Text = "Next";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ShowProducts
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1435, 667);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(listView1);
            Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ShowProducts";
            Text = "ShowProducts";
            Load += ShowProducts_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button4;
        private Button button5;
    }
}