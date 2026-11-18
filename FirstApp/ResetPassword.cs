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
    public partial class ResetPassword : Form
    {
        private readonly CarRentalContext _db;
        private readonly int _userId;
        private User? _user;

        public ResetPassword(int userId)
        {
            InitializeComponent();
            _db = new CarRentalContext();
            _userId = userId;
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            _user = _db.Users.FirstOrDefault(q => q.Id == _userId);

            if (_user == null)
            {
                MessageBox.Show("This user no longer exists.");
                Close();
                return;
            }

            tbUserName.Text = _user.Username;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_user == null) return;

            var newPassword = tbNewPassword.Text;
            var confirmPassword = tbConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please enter a new password.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("The passwords do not match.");
                return;
            }

            try
            {
                _user.Password = Utils.HashPassword(newPassword);
                _db.SaveChanges();

                MessageBox.Show($"{_user.Username}'s password has been reset!");
                DialogResult = DialogResult.OK;   // closes the form
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
