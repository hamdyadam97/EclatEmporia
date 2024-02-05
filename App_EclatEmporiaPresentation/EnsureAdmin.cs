using App.Application.Services;
using App.Context;
using App.Infrastructure.Repositories;
using App.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App_EclatEmporiaPresentation
{
    public partial class EnsureAdmin : Form
    {
        UserService userService = new UserService(new UserRepository(new StoreContext()));

        public EnsureAdmin()
        {
            InitializeComponent();
            SetupDataGridView();

        }
        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GetOrders();
        }
        private void GetOrders()
        {
            var products = userService.GetUsers().Where(u => u.EnsureAdmin == false && u.Role==true).Select(u => new
            {
                u.UserID,
                u.Username,
                u.Email,
                u.FirstName,
                u.LastName,
                u.Address,
                u.PhoneNumber,
                u.RegistrationDate,
                u.Role
            }).ToList();

            dataGridView1.DataSource = products;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select one row.");
                return;
            }

            int selectedRow = dataGridView1.SelectedRows[0].Index;

            if (selectedRow >= 0 && selectedRow < dataGridView1.Rows.Count)
            {
                int UserID = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["UserID"].Value);
                string Username = Convert.ToString(dataGridView1.Rows[selectedRow].Cells["Username"].Value);
                string Email = Convert.ToString(dataGridView1.Rows[selectedRow].Cells["Email"].Value);


                textBox1.Text = Convert.ToString(Username);
                textBox2.Text = Convert.ToString(Email);
               

                var user = userService.GetUser(UserID);


                user.EnsureAdmin = true;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // All validation passed, proceed to update the product
            var selectedRow = dataGridView1.SelectedRows[0].Index;
            int UserId = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["UserId"].Value);
            var user = userService.GetUser(UserId);
            user.EnsureAdmin = true;
            userService.UpdateUser(user);
            MessageBox.Show("User updated admin successfully.");
            SetupDataGridView();




        
            
}
    }
}
