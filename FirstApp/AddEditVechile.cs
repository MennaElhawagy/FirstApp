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
    public partial class AddEditVechile : Form
    {
        private readonly CarRentalContext _db;
        private ManageVechileListing _manageVechileListing;
        private bool isEditMode;
        public AddEditVechile(ManageVechileListing manageVechileListing)
        {
            InitializeComponent();
            lblTitle.Text = "Add New Vechile";
            isEditMode = false;
            _manageVechileListing = manageVechileListing;
            _db = new CarRentalContext();
            
        }

        public AddEditVechile(TypeOfCar carToEdit , ManageVechileListing manageVechileListing)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Vechile";
            isEditMode = true;
            _manageVechileListing = manageVechileListing;
            _db = new CarRentalContext();
            PopulateFields(carToEdit);

        }

        private void PopulateFields(TypeOfCar car)
        {
            tbId.Text = car.Id.ToString();
            tbMake.Text = car.Make;
            tbModel.Text = car.Model;
            tbVIN.Text = car.Vin;
            tbLicenseOlateNumber.Text = car.LicensePlateNumber;
            tbYear.Text = car.Year.ToString();


        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(tbYear.Text, out int year))
                {
                    MessageBox.Show("Please enter a valid year.");
                    return;
                }

                if (isEditMode)
                {
                    var id = int.Parse(tbId.Text);
                    var car = _db.TypeOfCars.FirstOrDefault(q => q.Id == id);

                    if (car == null)
                    {
                        MessageBox.Show("This vehicle no longer exists.");
                        return;
                    }

                    car.Make = tbMake.Text;
                    car.Model = tbModel.Text;
                    car.Vin = tbVIN.Text;
                    car.LicensePlateNumber = tbLicenseOlateNumber.Text;
                    car.Year = year;

                    _db.SaveChanges();
                }
                else
                {
                    var newCar = new TypeOfCar
                    {
                        Make = tbMake.Text,
                        Model = tbModel.Text,
                        Vin = tbVIN.Text,
                        LicensePlateNumber = tbLicenseOlateNumber.Text,
                        Year = year
                    };

                    _db.TypeOfCars.Add(newCar);
                    _db.SaveChanges();
                }

                MessageBox.Show("Vehicle saved successfully!");
                Close();

                _manageVechileListing.PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
