namespace FirstApp
{
    partial class ManageVechileListing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            gvVehicleList = new DataGridView();
            btnAddCar = new Button();
            btnEditCar = new Button();
            btnDeleteCar = new Button();
            ((System.ComponentModel.ISupportInitialize)gvVehicleList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 36F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(132, 21);
            label1.Name = "label1";
            label1.Size = new Size(611, 72);
            label1.TabIndex = 2;
            label1.Text = "Manage Vehicle Listing \r\n";
            // 
            // gvVehicleList
            // 
            gvVehicleList.ColumnHeadersHeight = 29;
            gvVehicleList.Location = new Point(93, 134);
            gvVehicleList.Name = "gvVehicleList";
            gvVehicleList.RowHeadersWidth = 51;
            gvVehicleList.Size = new Size(646, 158);
            gvVehicleList.TabIndex = 0;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(132, 348);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(127, 48);
            btnAddCar.TabIndex = 3;
            btnAddCar.Text = "Add";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // btnEditCar
            // 
            btnEditCar.Location = new Point(348, 349);
            btnEditCar.Name = "btnEditCar";
            btnEditCar.Size = new Size(127, 48);
            btnEditCar.TabIndex = 4;
            btnEditCar.Text = "Edit";
            btnEditCar.UseVisualStyleBackColor = true;
            btnEditCar.Click += btnEditCar_Click;
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.Location = new Point(561, 349);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(127, 47);
            btnDeleteCar.TabIndex = 5;
            btnDeleteCar.Text = "Delete";
            btnDeleteCar.UseVisualStyleBackColor = true;
            btnDeleteCar.Click += btnDeleteCar_Click;
            // 
            // ManageVechileListing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 450);
            Controls.Add(btnDeleteCar);
            Controls.Add(btnEditCar);
            Controls.Add(btnAddCar);
            Controls.Add(gvVehicleList);
            Controls.Add(label1);
            Name = "ManageVechileListing";
            Text = "Manage Vehicle Listing";
            Load += ManageVechileListing_Load;
            ((System.ComponentModel.ISupportInitialize)gvVehicleList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView gvVehicleList;
        private Button btnAddCar;
        private Button btnEditCar;
        private Button btnDeleteCar;
    }
}