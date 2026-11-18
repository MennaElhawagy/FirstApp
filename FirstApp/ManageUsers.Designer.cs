namespace FirstApp
{
    partial class ManageUsers
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
            lblManageUsers = new Label();
            btnDeactiveUser = new Button();
            btnResetPassword = new Button();
            btnAddNewUser = new Button();
            gvUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gvUsers).BeginInit();
            SuspendLayout();
            // 
            // lblManageUsers
            // 
            lblManageUsers.AutoSize = true;
            lblManageUsers.Font = new Font("Script MT Bold", 36F, FontStyle.Bold);
            lblManageUsers.ForeColor = SystemColors.HotTrack;
            lblManageUsers.Location = new Point(198, 44);
            lblManageUsers.Name = "lblManageUsers";
            lblManageUsers.Size = new Size(385, 72);
            lblManageUsers.TabIndex = 18;
            lblManageUsers.Text = "Manage Users";
            // 
            // btnDeactiveUser
            // 
            btnDeactiveUser.Location = new Point(553, 359);
            btnDeactiveUser.Name = "btnDeactiveUser";
            btnDeactiveUser.Size = new Size(191, 47);
            btnDeactiveUser.TabIndex = 17;
            btnDeactiveUser.Text = "Deactivate/Activate User";
            btnDeactiveUser.UseVisualStyleBackColor = true;
            btnDeactiveUser.Click += btnDeactiveUser_Click;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(340, 359);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(127, 48);
            btnResetPassword.TabIndex = 16;
            btnResetPassword.Text = "Reset Password";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.Location = new Point(124, 358);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(127, 48);
            btnAddNewUser.TabIndex = 15;
            btnAddNewUser.Text = "Add New User";
            btnAddNewUser.UseVisualStyleBackColor = true;
            btnAddNewUser.Click += btnAddNewUser_Click;
            // 
            // gvUsers
            // 
            gvUsers.ColumnHeadersHeight = 29;
            gvUsers.Location = new Point(77, 142);
            gvUsers.Name = "gvUsers";
            gvUsers.RowHeadersWidth = 51;
            gvUsers.Size = new Size(646, 182);
            gvUsers.TabIndex = 14;
            gvUsers.CellContentClick += gvUsers_CellContentClick;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblManageUsers);
            Controls.Add(btnDeactiveUser);
            Controls.Add(btnResetPassword);
            Controls.Add(btnAddNewUser);
            Controls.Add(gvUsers);
            Name = "ManageUsers";
            Text = "Manage Users";
            Load += ManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)gvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblManageUsers;
        private Button btnDeactiveUser;
        private Button btnResetPassword;
        private Button btnAddNewUser;
        private DataGridView gvUsers;
    }
}