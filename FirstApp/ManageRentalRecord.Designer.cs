namespace FirstApp
{
    partial class ManageRentalRecord
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
            btnDeleteRecord = new Button();
            btnEditRecord = new Button();
            btnAddRecord = new Button();
            gvVehicleListRecord = new DataGridView();
            labelRecord = new Label();
            ((System.ComponentModel.ISupportInitialize)gvVehicleListRecord).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.Location = new Point(563, 349);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(127, 47);
            btnDeleteRecord.TabIndex = 11;
            btnDeleteRecord.Text = "Delete";
            btnDeleteRecord.UseVisualStyleBackColor = true;
            btnDeleteRecord.Click += btnDeleteRecord_Click;
            // 
            // btnEditRecord
            // 
            btnEditRecord.Location = new Point(350, 349);
            btnEditRecord.Name = "btnEditRecord";
            btnEditRecord.Size = new Size(127, 48);
            btnEditRecord.TabIndex = 10;
            btnEditRecord.Text = "Edit";
            btnEditRecord.UseVisualStyleBackColor = true;
            btnEditRecord.Click += btnEditRecord_Click;
            // 
            // btnAddRecord
            // 
            btnAddRecord.Location = new Point(134, 348);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(127, 48);
            btnAddRecord.TabIndex = 9;
            btnAddRecord.Text = "Add";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // gvVehicleListRecord
            // 
            gvVehicleListRecord.ColumnHeadersHeight = 29;
            gvVehicleListRecord.Location = new Point(87, 156);
            gvVehicleListRecord.Name = "gvVehicleListRecord";
            gvVehicleListRecord.RowHeadersWidth = 51;
            gvVehicleListRecord.Size = new Size(646, 158);
            gvVehicleListRecord.TabIndex = 7;
            gvVehicleListRecord.CellContentClick += gvVehicleList_CellContentClick;
            // 
            // labelRecord
            // 
            labelRecord.AutoSize = true;
            labelRecord.Font = new Font("Script MT Bold", 36F, FontStyle.Bold);
            labelRecord.ForeColor = SystemColors.HotTrack;
            labelRecord.Location = new Point(87, 34);
            labelRecord.Name = "labelRecord";
            labelRecord.Size = new Size(599, 72);
            labelRecord.TabIndex = 13;
            labelRecord.Text = "Manage Rental Record";
            labelRecord.Click += labelRecord_Click;
            // 
            // ManageRentalRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRecord);
            Controls.Add(btnDeleteRecord);
            Controls.Add(btnEditRecord);
            Controls.Add(btnAddRecord);
            Controls.Add(gvVehicleListRecord);
            Name = "ManageRentalRecord";
            Text = "Manage Rental Record";
            Load += ManageRentalRecord_Load;
            ((System.ComponentModel.ISupportInitialize)gvVehicleListRecord).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDeleteRecord;
        private Button btnEditRecord;
        private Button btnAddRecord;
        private DataGridView gvVehicleListRecord;
        private Label labelRecord;
    }
}
