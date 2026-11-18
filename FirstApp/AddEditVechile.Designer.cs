namespace FirstApp
{
    partial class AddEditVechile
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
            lblTitle = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbMake = new TextBox();
            tbModel = new TextBox();
            tbVIN = new TextBox();
            tbLicenseOlateNumber = new TextBox();
            tbYear = new TextBox();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label8 = new Label();
            tbId = new Label();
            lblTitle.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.ColumnCount = 2;
            lblTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            lblTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            lblTitle.Controls.Add(label2, 0, 0);
            lblTitle.Controls.Add(label3, 0, 1);
            lblTitle.Controls.Add(label4, 0, 2);
            lblTitle.Controls.Add(label5, 0, 3);
            lblTitle.Controls.Add(label6, 0, 4);
            lblTitle.Controls.Add(tbMake, 1, 0);
            lblTitle.Controls.Add(tbModel, 1, 1);
            lblTitle.Controls.Add(tbVIN, 1, 2);
            lblTitle.Controls.Add(tbLicenseOlateNumber, 1, 3);
            lblTitle.Controls.Add(tbYear, 1, 4);
            lblTitle.Location = new Point(12, 102);
            lblTitle.Name = "lblTitle";
            lblTitle.RowCount = 5;
            lblTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            lblTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            lblTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            lblTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            lblTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            lblTitle.Size = new Size(776, 257);
            lblTitle.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 0;
            label2.Text = "Make";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 51);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 1;
            label3.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 102);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 2;
            label4.Text = "VIN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 153);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 3;
            label5.Text = "LicensePlateNumber";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 204);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 4;
            label6.Text = "Year";
            // 
            // tbMake
            // 
            tbMake.Location = new Point(391, 3);
            tbMake.Name = "tbMake";
            tbMake.Size = new Size(125, 27);
            tbMake.TabIndex = 5;
            // 
            // tbModel
            // 
            tbModel.Location = new Point(391, 54);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(125, 27);
            tbModel.TabIndex = 6;
            // 
            // tbVIN
            // 
            tbVIN.Location = new Point(391, 105);
            tbVIN.Name = "tbVIN";
            tbVIN.Size = new Size(125, 27);
            tbVIN.TabIndex = 7;
            // 
            // tbLicenseOlateNumber
            // 
            tbLicenseOlateNumber.Location = new Point(391, 156);
            tbLicenseOlateNumber.Name = "tbLicenseOlateNumber";
            tbLicenseOlateNumber.Size = new Size(125, 27);
            tbLicenseOlateNumber.TabIndex = 8;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(391, 207);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(125, 27);
            tbYear.TabIndex = 9;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(143, 379);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(142, 49);
            btnSaveChanges.TabIndex = 1;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(515, 379);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 49);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 36F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(222, 9);
            label1.Name = "label1";
            label1.Size = new Size(366, 72);
            label1.TabIndex = 3;
            label1.Text = "Add New Car";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(340, 382);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 5;
            // 
            // tbId
            // 
            tbId.AutoSize = true;
            tbId.Location = new Point(387, 382);
            tbId.Name = "tbId";
            tbId.Size = new Size(0, 20);
            tbId.TabIndex = 6;
            tbId.Click += label9_Click;
            // 
            // AddEditVechile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbId);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveChanges);
            Controls.Add(lblTitle);
            Name = "AddEditVechile";
            Text = "AddEditVechile";
            lblTitle.ResumeLayout(false);
            lblTitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel lblTitle;
        private Button btnSaveChanges;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbMake;
        private TextBox tbModel;
        private TextBox tbVIN;
        private TextBox tbLicenseOlateNumber;
        private TextBox tbYear;
        private Label label8;
        private Label tbId;
    }
}