using FirstApp.Models;

namespace FirstApp
{
    public partial class AddEditRentalRecord : Form
    {

        private readonly CarRentalContext _db;
        private bool isEditMode;
        public AddEditRentalRecord()
        {
            InitializeComponent();
            label1.Text = "Add New Rental Record";
            this.Text = "Add New Rental Record";
            isEditMode = false;
            _db = new CarRentalContext();
        }

        public AddEditRentalRecord(CarRental recordToEdit)
        {
            InitializeComponent();
            label1.Text = "Edit Rental Record";
            this.Text = "Add Rental Record";
            isEditMode = true;
            _db = new CarRentalContext();
            PopulateFields(recordToEdit);


        }

        private void PopulateFields(CarRental recordToEdit)
        {
            tbCustomerName.Text = recordToEdit.Customer;
            tbCost.Text = recordToEdit.Cost.ToString();
            dtpDateRented.Value = (DateTime)recordToEdit.DateRented;
            dtpDateReturned.Value = (DateTime)recordToEdit.DateReturned;
            lblRecord.Text = recordToEdit.Id.ToString();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = tbCustomerName.Text;
                var dateOut = dtpDateRented.Value;
                var dateIn = dtpDateReturned.Value;
                double cost = Convert.ToDouble(tbCost.Text);

                var carType = cbTypeOfCar.Text;
                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter missing data.\n\r";
                }

                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMessage += "Error: Illegal Date Selection\n\r";
                }

                if (isValid)
                {
                    var rentalRecord = new CarRental();

                    if (isEditMode)
                    {
                        var id = int.Parse(lblRecord.Text);
                        rentalRecord = _db.CarRentals.FirstOrDefault(q => q.Id == id);
                    }

                    rentalRecord.Customer = customerName;
                    rentalRecord.DateRented = dateOut;
                    rentalRecord.DateReturned = dateIn;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.TypeOfCarId = (int)cbTypeOfCar.SelectedValue;

                    if (!isEditMode)
                        _db.CarRentals.Add(rentalRecord);

                    _db.SaveChanges();


                    MessageBox.Show($"Customer Name: {customerName}\n\r" +
                                    $"Date Rented: {dateOut}\n\r" +
                                    $"Date Returned: {dateIn}\n\r" +
                                    $"Cost: {cost}\n\r" +
                                    $"Car Type: {carType}\n\r" +
                                    $"THANK YOU FOR YOUR BUSINESS");

                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using var db = new CarRentalContext();

            //cbTypeOfCar.DataSource = db.TypeOfCars.ToList();
            var cars = db.TypeOfCars.Select(q => new { Id = q.Id, Name = q.Make + " " + q.Model }).ToList();
            cbTypeOfCar.DisplayMember = "Name";
            cbTypeOfCar.ValueMember = "Id";
            cbTypeOfCar.DataSource = cars;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


    }
}
