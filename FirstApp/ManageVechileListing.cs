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
    public partial class ManageVechileListing : Form
    {
        private readonly CarRentalContext _db;
        public ManageVechileListing()
        {
            InitializeComponent();
            _db = new CarRentalContext();

            // Clicking a cell selects the whole row, so SelectedRows is never empty after a click
            gvVehicleList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvVehicleList.MultiSelect = false;
        }

        private void ManageVechileListing_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            //var cars = _db.TypeOfCars.Select(q => new { CarId = q.Id, CarName = q.Name }).ToList();

            //var cars = _db.TypeOfCars.ToList();

            var cars = _db.TypeOfCars
                .Select(q => new { 
                    Make = q.Make, 
                    Model = q.Model, 
                    VIN = q.Vin, 
                    License = q.LicensePlateNumber, 
                    Year = q.Year, 
                    q.Id }).ToList();

            gvVehicleList.DataSource = cars;
            //gvVehicleList.Columns[0].HeaderText = "ID";
            //gvVehicleList.Columns[1].HeaderText = "NAME";
            gvVehicleList.Columns[5].Visible = false;

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var addEditVechile = new AddEditVechile(this);
            addEditVechile.MdiParent = this.MdiParent;
            addEditVechile.Show();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            if (gvVehicleList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a vehicle first.");
                return;
            }

            var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
            var car = _db.TypeOfCars.FirstOrDefault(q => q.Id == id);
            var addEditVechile = new AddEditVechile(car , this);
            addEditVechile.MdiParent = this.MdiParent;
            addEditVechile.Show();



        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (gvVehicleList.SelectedRows.Count == 0 ||
                gvVehicleList.SelectedRows[0].Cells["Id"].Value is not int id)
            {
                MessageBox.Show("Please select a vehicle first.");
                return;
            }

           

            var car = _db.TypeOfCars.FirstOrDefault(q => q.Id == id);

            if (car != null)
            {
                DialogResult dr = MessageBox.Show(this,
                    "Are You Sure You Want To Delete This Record?",
                    "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr != DialogResult.Yes)
                {
                    return;
                }

                try
                {
                    _db.TypeOfCars.Remove(car);
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    // Undo the pending delete so the next SaveChanges on _db doesn't retry it
                    _db.Entry(car).State = EntityState.Unchanged;
                    MessageBox.Show(ex.Message);
                }
            }

            // Reload from the database so the deleted car disappears from the grid
            PopulateGrid();



        }

        
    }
}
