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
    public partial class MainWindow : Form
    {
        private Login _login;
        public string _roleShortName;

        public User _user;
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Login login, User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            _roleShortName = user.UserRoles.FirstOrDefault().Role.ShortName;
        }



        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord();
            addRentalRecord.ShowDialog();
            addRentalRecord.MdiParent = this;

        }

        private void manageVehicleLisingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen(nameof(ManageVechileListing)))
            {
                var vehicleListing = new ManageVechileListing();
                vehicleListing.ShowDialog();
                vehicleListing.MdiParent = this;
            }


        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            var userName = _user.Username;
            toolStripStatusLabel1.Text = $"Logged In As {userName}";

            if (_roleShortName != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
            }
        }

        private void viewArcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageRentalRecords = new ManageRentalRecord();
            manageRentalRecords.ShowDialog();
            manageRentalRecords.MdiParent = this;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (!Utils.FormIsOpen(nameof(ManageUsers)))
            {

                var manageUsers = new ManageUsers();
                manageUsers.ShowDialog();
                manageUsers.MdiParent = this;
            }

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
