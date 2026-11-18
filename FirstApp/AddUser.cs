using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class AddUser : Form
    {
        private readonly CarRentalContext _db;
        private ManageUsers _manageUsers;
        public AddUser(ManageUsers manageUsers)
        {
            InitializeComponent();
            _db = new CarRentalContext();
            _manageUsers = manageUsers;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = _db.Roles.ToList();
            cbRole.DataSource = roles;
            cbRole.ValueMember = "id";
            cbRole.DisplayMember = "name";
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var userName = tbUserName.Text.Trim();

                if (string.IsNullOrWhiteSpace(userName))
                {
                    MessageBox.Show("Please enter a username.");
                    return;
                }

                if (cbRole.SelectedValue == null)
                {
                    MessageBox.Show("Please select a role.");
                    return;
                }

                if (_db.Users.Any(q => q.Username == userName))
                {
                    MessageBox.Show($"The username '{userName}' is already taken.");
                    return;
                }

                var roleId = (int)cbRole.SelectedValue;
                var password = Utils.DefaultHashPassword();
                var user = new User
                {
                    Username = userName,
                    Password = password,
                    IsActive = true
                };

                var userid = user.Id;
                user.UserRoles.Add(new UserRole { RoleId = roleId , UserId = userid });

                _db.Users.Add(user);
                _db.SaveChanges();

                MessageBox.Show($"{userName} added successfully");
                _manageUsers.PopulateGrid();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
