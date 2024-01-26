using App.Application.Services;
using App.Context;
using App.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_EclatEmporiaPresentation
{
    public partial class Login : Form
    {
        private readonly UserService _userService;

        private readonly StoreContext context;
   
        public Login()
        {
            InitializeComponent();
            context = new StoreContext();
        }
        private User AuthenticateUser(string username, string password)
        {
            User user = context.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
            return user;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBox1.Text;
            string enteredPassword = textBox2.Text;


            User authenticatedUser = AuthenticateUser(enteredUsername, enteredPassword);

            if (authenticatedUser != null)
            {
                if (authenticatedUser.Role)
                {
                    AddCategoryProduct adminForm = new AddCategoryProduct();
                    adminForm.Show();
                }
                else
                {
                    ShowProducts regularUserForm = new ShowProducts();
                    regularUserForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
        }
    }

}
