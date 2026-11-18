using FirstApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Login : Form
    {
        private readonly CarRentalContext _db;
        public Login()
        {
            InitializeComponent();
            _db = new CarRentalContext();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var userName = tbUserName.Text.Trim();
                var password = tbPassword.Text;
                var hashed_password = Utils.HashPassword(password);

                var user = _db.Users
                    .AsNoTracking()
                    .Include(q => q.UserRoles)
                    .ThenInclude(q => q.Role)
                    .FirstOrDefault(q => q.Username == userName && q.Password == hashed_password && q.IsActive == true);

                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    var mainWindow = new MainWindow(this, user);
                    mainWindow.Show();
                    Hide();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Please try again.\n\n{ex.Message}");

            }
        }
    }
}
