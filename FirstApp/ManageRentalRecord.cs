using FirstApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class ManageRentalRecord : Form
    {
        private readonly CarRentalContext _db;
        public ManageRentalRecord()
        {
            InitializeComponent();
            _db = new CarRentalContext();

            gvVehicleListRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvVehicleListRecord.MultiSelect = false;
        }

        private void gvVehicleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord();
            addRentalRecord.MdiParent = this.MdiParent;
            addRentalRecord.Show();

        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvVehicleListRecord.SelectedRows[0].Cells["Id"].Value;
                var record = _db.CarRentals.FirstOrDefault(q => q.Id == id);

                var addEditRentalRecord = new AddEditRentalRecord(record);
                addEditRentalRecord.MdiParent = this.MdiParent;
                addEditRentalRecord.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            } 
        }

        private void labelRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (gvVehicleListRecord.SelectedRows.Count == 0 ||
                gvVehicleListRecord.SelectedRows[0].Cells["Id"].Value is not int id)
            {
                MessageBox.Show("Please select a rental record first.");
                return;
            }

            var record = _db.CarRentals.FirstOrDefault(q => q.Id == id);

            if (record != null)
            {
                try
                {
                    _db.CarRentals.Remove(record);
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    // Undo the pending delete so a later save does not retry it.
                    _db.Entry(record).State = EntityState.Unchanged;
                    MessageBox.Show(ex.Message);
                }
            }

            PopulateGrid();
        }

       

        private void ManageRentalRecord_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            var records = _db.CarRentals.Select(q => new
            {
                Customer = q.Customer,
                DateOut = q.DateRented,
                DateIn = q.DateReturned,
                Id = q.Id,
                q.Cost,
                Car = q.TypeOfCar.Make + " " + q.TypeOfCar.Model

            }).ToList();

            gvVehicleListRecord.DataSource = records ;
            gvVehicleListRecord.Columns["DateIn"].HeaderText = "Date In";
            gvVehicleListRecord.Columns["DateOut"].HeaderText = "Date Out";
            gvVehicleListRecord.Columns["Id"].Visible = false;

        }
    }
}
