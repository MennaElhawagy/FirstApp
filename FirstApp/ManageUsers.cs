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
    public partial class ManageUsers : Form
    {
        private readonly CarRentalContext _db;
        
        public ManageUsers()
        {
            InitializeComponent();
            _db = new CarRentalContext();

            gvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvUsers.MultiSelect = false;
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void gvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }
        }

        public void PopulateGrid()
        {
            var users = _db.Users
                .Select(q => new {
                    Id = q.Id,
                    Username = q.Username,
                    Name = q.UserRoles.FirstOrDefault().Role.Name,
                    IsActive = q.IsActive
                }).ToList();

            gvUsers.DataSource = users;
            gvUsers.Columns["Name"].HeaderText = "Role Name";
            gvUsers.Columns["IsActive"].HeaderText = "Active";
            gvUsers.Columns["Id"].Visible = false;

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (gvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            var id = (int)gvUsers.SelectedRows[0].Cells["Id"].Value;

            using var resetPassword = new ResetPassword(id);
            resetPassword.ShowDialog(this);
        }

        private void btnDeactiveUser_Click(object sender, EventArgs e)
        {
            if (gvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            var id = (int)gvUsers.SelectedRows[0].Cells["Id"].Value;

            var user = _db.Users.FirstOrDefault(q => q.Id == id);
            if (user == null)
            {
                MessageBox.Show("This user no longer exists.");
                PopulateGrid();
                return;
            }

            var wasActive = user.IsActive == true;

            try
            {
                user.IsActive = !wasActive;
                _db.SaveChanges();

                MessageBox.Show($"{user.Username} has been {(wasActive ? "deactivated" : "activated")}.");

                // Refresh the Active column, then keep the same user selected
                PopulateGrid();
                SelectUserRow(id);
            }
            catch (Exception ex)
            {
                // Undo the change so the next save doesn't retry it
                user.IsActive = wasActive;
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void SelectUserRow(int id)
        {
            foreach (DataGridViewRow row in gvUsers.Rows)
            {
                if (row.Cells["Id"].Value is int rowId && rowId == id)
                {
                    gvUsers.CurrentCell = row.Cells["Username"];
                    return;
                }
            }
        }

    }

}
