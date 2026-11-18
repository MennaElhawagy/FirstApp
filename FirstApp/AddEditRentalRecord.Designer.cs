namespace FirstApp
{
    partial class AddEditRentalRecord
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            dtpDateRented = new DateTimePicker();
            dtpDateReturned = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            cbTypeOfCar = new ComboBox();
            label5 = new Label();
            tbCustomerName = new TextBox();
            tbCost = new TextBox();
            label6 = new Label();
            lblRecord = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Script MT Bold", 15F, FontStyle.Bold);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(328, 365);
            button1.Name = "button1";
            button1.Size = new Size(94, 44);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 36F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(178, 9);
            label1.Name = "label1";
            label1.Size = new Size(416, 72);
            label1.TabIndex = 1;
            label1.Text = "Add Car Rental";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(31, 81);
            label2.Name = "label2";
            label2.Size = new Size(164, 28);
            label2.TabIndex = 2;
            label2.Text = "Customer Name";
            // 
            // dtpDateRented
            // 
            dtpDateRented.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateRented.CalendarForeColor = SystemColors.HotTrack;
            dtpDateRented.CalendarTitleForeColor = SystemColors.HotTrack;
            dtpDateRented.Location = new Point(31, 204);
            dtpDateRented.Name = "dtpDateRented";
            dtpDateRented.Size = new Size(298, 27);
            dtpDateRented.TabIndex = 3;
            // 
            // dtpDateReturned
            // 
            dtpDateReturned.CalendarTitleForeColor = SystemColors.HotTrack;
            dtpDateReturned.Location = new Point(459, 204);
            dtpDateReturned.Name = "dtpDateReturned";
            dtpDateReturned.Size = new Size(288, 27);
            dtpDateReturned.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(31, 161);
            label3.Name = "label3";
            label3.Size = new Size(130, 28);
            label3.TabIndex = 5;
            label3.Text = "Date Rented";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(459, 161);
            label4.Name = "label4";
            label4.Size = new Size(150, 28);
            label4.TabIndex = 6;
            label4.Text = "Date Returned";
            label4.Click += label4_Click;
            // 
            // cbTypeOfCar
            // 
            cbTypeOfCar.FormattingEnabled = true;
            cbTypeOfCar.Items.AddRange(new object[] { "Honda", "Toyota", "Lada", "Bugy" });
            cbTypeOfCar.Location = new Point(31, 295);
            cbTypeOfCar.Name = "cbTypeOfCar";
            cbTypeOfCar.Size = new Size(298, 28);
            cbTypeOfCar.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(31, 252);
            label5.Name = "label5";
            label5.Size = new Size(123, 28);
            label5.TabIndex = 8;
            label5.Text = "Type Of Car";
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(31, 121);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(298, 27);
            tbCustomerName.TabIndex = 9;
            // 
            // tbCost
            // 
            tbCost.Location = new Point(459, 121);
            tbCost.Name = "tbCost";
            tbCost.Size = new Size(288, 27);
            tbCost.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(459, 81);
            label6.Name = "label6";
            label6.Size = new Size(53, 28);
            label6.TabIndex = 11;
            label6.Text = "Cost";
            label6.Click += label6_Click;
            // 
            // lblRecord
            // 
            lblRecord.AutoSize = true;
            lblRecord.Location = new Point(569, 380);
            lblRecord.Name = "lblRecord";
            lblRecord.Size = new Size(0, 20);
            lblRecord.TabIndex = 12;
            // 
            // AddEditRentalRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRecord);
            Controls.Add(label6);
            Controls.Add(tbCost);
            Controls.Add(tbCustomerName);
            Controls.Add(label5);
            Controls.Add(cbTypeOfCar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpDateReturned);
            Controls.Add(dtpDateRented);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "AddEditRentalRecord";
            Text = "Add Rental Record";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpDateRented;
        private DateTimePicker dtpDateReturned;
        private Label label3;
        private Label label4;
        private ComboBox cbTypeOfCar;
        private Label label5;
        private TextBox tbCustomerName;
        private TextBox tbCost;
        private Label label6;
        private Label lblRecord;
    }
}
