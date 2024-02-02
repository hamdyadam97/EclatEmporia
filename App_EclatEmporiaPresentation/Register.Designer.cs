namespace App_EclatEmporiaPresentation
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            FirstName = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            LastName = new Label();
            PhoneNumber = new TextBox();
            label3 = new Label();
            Email = new TextBox();
            label4 = new Label();
            ConfirmPassword = new TextBox();
            label5 = new Label();
            Password = new TextBox();
            label6 = new Label();
            Address = new TextBox();
            label7 = new Label();
            UserName = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FirstName.Location = new Point(29, 50);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(115, 16);
            FirstName.TabIndex = 0;
            FirstName.Text = "First Name :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(291, 299);
            button1.Name = "button1";
            button1.Size = new Size(185, 30);
            button1.TabIndex = 2;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(596, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 23);
            textBox2.TabIndex = 4;
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LastName.Location = new Point(421, 51);
            LastName.Name = "LastName";
            LastName.Size = new Size(106, 16);
            LastName.TabIndex = 3;
            LastName.Text = "Last Name :";
            // 
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(596, 89);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(175, 23);
            PhoneNumber.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(417, 96);
            label3.Name = "label3";
            label3.Size = new Size(133, 16);
            label3.TabIndex = 7;
            label3.Text = "Phone Number :";
            // 
            // Email
            // 
            Email.Location = new Point(186, 96);
            Email.Name = "Email";
            Email.Size = new Size(175, 23);
            Email.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 104);
            label4.Name = "label4";
            label4.Size = new Size(70, 16);
            label4.TabIndex = 5;
            label4.Text = "Email :";
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.Location = new Point(596, 192);
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.Size = new Size(175, 23);
            ConfirmPassword.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(395, 199);
            label5.Name = "label5";
            label5.Size = new Size(169, 16);
            label5.TabIndex = 15;
            label5.Text = "Confirm Password :";
            // 
            // Password
            // 
            Password.Location = new Point(186, 191);
            Password.Name = "Password";
            Password.Size = new Size(175, 23);
            Password.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 199);
            label6.Name = "label6";
            label6.Size = new Size(97, 16);
            label6.TabIndex = 13;
            label6.Text = "Password :";
            // 
            // Address
            // 
            Address.Location = new Point(596, 140);
            Address.Name = "Address";
            Address.Size = new Size(175, 23);
            Address.TabIndex = 12;
            Address.TextChanged += Address_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(421, 151);
            label7.Name = "label7";
            label7.Size = new Size(88, 16);
            label7.TabIndex = 11;
            label7.Text = "Address :";
            label7.Click += label7_Click;
            // 
            // UserName
            // 
            UserName.Location = new Point(186, 144);
            UserName.Name = "UserName";
            UserName.Size = new Size(175, 23);
            UserName.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(29, 147);
            label8.Name = "label8";
            label8.Size = new Size(106, 16);
            label8.TabIndex = 9;
            label8.Text = "User Name :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(29, 247);
            label9.Name = "label9";
            label9.Size = new Size(70, 16);
            label9.TabIndex = 17;
            label9.Text = "State :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(95, 361);
            label10.Name = "label10";
            label10.Size = new Size(133, 16);
            label10.TabIndex = 19;
            label10.Text = "Have Account ?";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(234, 356);
            button2.Name = "button2";
            button2.Size = new Size(88, 26);
            button2.TabIndex = 20;
            button2.Text = "Sign In";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "User" });
            comboBox1.Location = new Point(186, 240);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 23);
            comboBox1.TabIndex = 21;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(ConfirmPassword);
            Controls.Add(label5);
            Controls.Add(Password);
            Controls.Add(label6);
            Controls.Add(Address);
            Controls.Add(label7);
            Controls.Add(UserName);
            Controls.Add(label8);
            Controls.Add(PhoneNumber);
            Controls.Add(label3);
            Controls.Add(Email);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(LastName);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(FirstName);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstName;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label LastName;
        private TextBox PhoneNumber;
        private Label label3;
        private TextBox Email;
        private Label label4;
        private TextBox ConfirmPassword;
        private Label label5;
        private TextBox Password;
        private Label label6;
        private TextBox Address;
        private Label label7;
        private TextBox UserName;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button2;
        private ComboBox comboBox1;
    }
}