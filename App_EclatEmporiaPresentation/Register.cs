using App.Application.Services;
using App.Context;
using App.Infrastructure.Repositories;
using App.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace App_EclatEmporiaPresentation
{
    public partial class Register : Form
    {
        private readonly UserService _userService;
        private  StoreContext context;
        public bool ValidatePasswordMatch(User user)
        {
            // Check if ConfirmPassword matches Password
            return user.Password == user.ConfirmPassword;
        }
        public Register()
        {
      
            InitializeComponent();
            _userService = new UserService(new UserRepository(new StoreContext()));
        }
        private bool DetermineUserRole(string selectedRole)
        {
            return selectedRole == "Admin";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

               
                var newUser = new User
                {
                    Username = UserName.Text,
                    Email = Email.Text,
                    Password = Password.Text,
                    ConfirmPassword = ConfirmPassword.Text,
                    Address = Address.Text,                 
                    PhoneNumber = PhoneNumber.Text,
                    FirstName = textBox1.Text,
                    LastName = textBox2.Text,
                    Role = DetermineUserRole(comboBox1.Text),
                    RegistrationDate = DateTime.Now
                };
                
                bool _MathPassword = ValidatePasswordMatch(newUser);
                if (!_MathPassword)
                {
                    MessageBox.Show("Password and Confirm must be match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _userService.Add(newUser);

                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                context = new StoreContext();
                User user = context.Users.SingleOrDefault(u => u.Username == UserName.Text && u.Password == Password.Text);
                SessionData.Instance.user = user;

                if (_userService.DetermineUserRole(comboBox1.Text))
                {                
                    Add_Product AddProduct = new Add_Product();

                    AddProduct.user = newUser;
                    AddProduct.Show();
                   
                }
                else 
                {               
                    ShowProducts ShowProducts = new ShowProducts();
                    ShowProducts.user = newUser;
                    ShowProducts.Show();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
