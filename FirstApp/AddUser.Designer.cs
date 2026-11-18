namespace FirstApp
{
    partial class AddUser
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
            lblAddUser = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbRole = new Label();
            label1 = new Label();
            tbUserName = new TextBox();
            cbRole = new ComboBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddUser
            // 
            lblAddUser.AutoSize = true;
            lblAddUser.Font = new Font("Script MT Bold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddUser.ForeColor = SystemColors.HotTrack;
            lblAddUser.Location = new Point(284, 20);
            lblAddUser.Name = "lblAddUser";
            lblAddUser.Size = new Size(262, 72);
            lblAddUser.TabIndex = 1;
            lblAddUser.Text = "Add User";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tbRole, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbUserName, 1, 0);
            tableLayoutPanel1.Controls.Add(cbRole, 1, 1);
            tableLayoutPanel1.Location = new Point(191, 150);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(440, 172);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tbRole
            // 
            tbRole.AutoSize = true;
            tbRole.Location = new Point(3, 86);
            tbRole.Name = "tbRole";
            tbRole.Size = new Size(39, 20);
            tbRole.TabIndex = 2;
            tbRole.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(223, 3);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(214, 27);
            tbUserName.TabIndex = 1;
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(223, 89);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(214, 28);
            cbRole.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(191, 356);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(140, 53);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += this.btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(489, 356);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 53);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblAddUser);
            Name = "AddUser";
            Text = "Add User";
            Load += AddUser_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddUser;
        private TableLayoutPanel tableLayoutPanel1;
        private Label tbRole;
        private Label label1;
        private TextBox tbUserName;
        private ComboBox cbRole;
        private Button btnSubmit;
        private Button btnCancel;
    }
}