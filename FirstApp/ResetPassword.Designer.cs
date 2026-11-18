namespace FirstApp
{
    partial class ResetPassword
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
            lblResetPassword = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblUserName = new Label();
            tbUserName = new TextBox();
            lblNewPassword = new Label();
            tbNewPassword = new TextBox();
            lblConfirmPassword = new Label();
            tbConfirmPassword = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            //
            // lblResetPassword
            //
            lblResetPassword.AutoSize = true;
            lblResetPassword.Font = new Font("Script MT Bold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResetPassword.ForeColor = SystemColors.HotTrack;
            lblResetPassword.Location = new Point(180, 20);
            lblResetPassword.Name = "lblResetPassword";
            lblResetPassword.Size = new Size(440, 72);
            lblResetPassword.TabIndex = 0;
            lblResetPassword.Text = "Reset Password";
            //
            // tableLayoutPanel1
            //
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblUserName, 0, 0);
            tableLayoutPanel1.Controls.Add(tbUserName, 1, 0);
            tableLayoutPanel1.Controls.Add(lblNewPassword, 0, 1);
            tableLayoutPanel1.Controls.Add(tbNewPassword, 1, 1);
            tableLayoutPanel1.Controls.Add(lblConfirmPassword, 0, 2);
            tableLayoutPanel1.Controls.Add(tbConfirmPassword, 1, 2);
            tableLayoutPanel1.Location = new Point(191, 120);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(440, 180);
            tableLayoutPanel1.TabIndex = 1;
            //
            // lblUserName
            //
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(3, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(75, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Username";
            //
            // tbUserName
            //
            tbUserName.Location = new Point(223, 3);
            tbUserName.Name = "tbUserName";
            tbUserName.ReadOnly = true;
            tbUserName.Size = new Size(214, 27);
            tbUserName.TabIndex = 1;
            tbUserName.TabStop = false;
            //
            // lblNewPassword
            //
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(3, 60);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(104, 20);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "New Password";
            //
            // tbNewPassword
            //
            tbNewPassword.Location = new Point(223, 63);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Size = new Size(214, 27);
            tbNewPassword.TabIndex = 3;
            tbNewPassword.UseSystemPasswordChar = true;
            //
            // lblConfirmPassword
            //
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(3, 120);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(127, 20);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Confirm Password";
            //
            // tbConfirmPassword
            //
            tbConfirmPassword.Location = new Point(223, 123);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(214, 27);
            tbConfirmPassword.TabIndex = 5;
            tbConfirmPassword.UseSystemPasswordChar = true;
            //
            // btnSubmit
            //
            btnSubmit.Location = new Point(191, 340);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(140, 53);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            //
            // btnCancel
            //
            btnCancel.Location = new Point(480, 340);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 53);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            //
            // ResetPassword
            //
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblResetPassword);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResetPassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reset Password";
            Load += ResetPassword_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResetPassword;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblUserName;
        private TextBox tbUserName;
        private Label lblNewPassword;
        private TextBox tbNewPassword;
        private Label lblConfirmPassword;
        private TextBox tbConfirmPassword;
        private Button btnSubmit;
        private Button btnCancel;
    }
}
