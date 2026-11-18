namespace FirstApp
{
    partial class MainWindow
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
            menuStrip1 = new MenuStrip();
            manageVehicleLisingToolStripMenuItem = new ToolStripMenuItem();
            manageRentalRecordsToolStripMenuItem = new ToolStripMenuItem();
            addRentalRecordToolStripMenuItem = new ToolStripMenuItem();
            viewArcToolStripMenuItem = new ToolStripMenuItem();
            editRentalRecordToolStripMenuItem = new ToolStripMenuItem();
            manageUsersToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { manageVehicleLisingToolStripMenuItem, manageRentalRecordsToolStripMenuItem, manageUsersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // manageVehicleLisingToolStripMenuItem
            // 
            manageVehicleLisingToolStripMenuItem.Name = "manageVehicleLisingToolStripMenuItem";
            manageVehicleLisingToolStripMenuItem.Size = new Size(175, 24);
            manageVehicleLisingToolStripMenuItem.Text = "Manage Vehicle Listing";
            manageVehicleLisingToolStripMenuItem.Click += manageVehicleLisingToolStripMenuItem_Click;
            // 
            // manageRentalRecordsToolStripMenuItem
            // 
            manageRentalRecordsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addRentalRecordToolStripMenuItem, viewArcToolStripMenuItem, editRentalRecordToolStripMenuItem });
            manageRentalRecordsToolStripMenuItem.Name = "manageRentalRecordsToolStripMenuItem";
            manageRentalRecordsToolStripMenuItem.Size = new Size(180, 24);
            manageRentalRecordsToolStripMenuItem.Text = "Manage Rental Records";
            // 
            // addRentalRecordToolStripMenuItem
            // 
            addRentalRecordToolStripMenuItem.Name = "addRentalRecordToolStripMenuItem";
            addRentalRecordToolStripMenuItem.Size = new Size(217, 26);
            addRentalRecordToolStripMenuItem.Text = "Add Rental Record";
            addRentalRecordToolStripMenuItem.Click += addRentalRecordToolStripMenuItem_Click;
            // 
            // viewArcToolStripMenuItem
            // 
            viewArcToolStripMenuItem.Name = "viewArcToolStripMenuItem";
            viewArcToolStripMenuItem.Size = new Size(217, 26);
            viewArcToolStripMenuItem.Text = "View Archive";
            viewArcToolStripMenuItem.Click += viewArcToolStripMenuItem_Click;
            // 
            // editRentalRecordToolStripMenuItem
            // 
            editRentalRecordToolStripMenuItem.Name = "editRentalRecordToolStripMenuItem";
            editRentalRecordToolStripMenuItem.Size = new Size(217, 26);
            editRentalRecordToolStripMenuItem.Text = "Edit Rental Record";
            // 
            // manageUsersToolStripMenuItem
            // 
            manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            manageUsersToolStripMenuItem.Size = new Size(116, 24);
            manageUsersToolStripMenuItem.Text = "Manage Users";
            manageUsersToolStripMenuItem.Click += manageUsersToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 426);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 24);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 18);
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "Car Rental Mangement System";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageVehicleLisingToolStripMenuItem;
        private ToolStripMenuItem manageRentalRecordsToolStripMenuItem;
        private ToolStripMenuItem addRentalRecordToolStripMenuItem;
        private ToolStripMenuItem viewArcToolStripMenuItem;
        private ToolStripMenuItem editRentalRecordToolStripMenuItem;
        private ToolStripMenuItem manageUsersToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}