namespace FirstApp
{
    partial class Login
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
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            lblUserName = new Label();
            lblPassword = new Label();
            btLogin = new Button();
            lblId = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(310, 24);
            label1.Name = "label1";
            label1.Size = new Size(166, 72);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(415, 144);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(165, 27);
            tbUserName.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Marlett", 12F, FontStyle.Bold, GraphicsUnit.Point, 2);
            tbPassword.Location = new Point(415, 250);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(165, 27);
            tbPassword.TabIndex = 4;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Script MT Bold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = SystemColors.HotTrack;
            lblUserName.Location = new Point(169, 131);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(227, 53);
            lblUserName.TabIndex = 5;
            lblUserName.Text = "User Name";
            lblUserName.Click += label2_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Script MT Bold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.HotTrack;
            lblPassword.Location = new Point(180, 228);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(200, 53);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // btLogin
            // 
            btLogin.Font = new Font("Script MT Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogin.ForeColor = SystemColors.HotTrack;
            btLogin.Location = new Point(310, 331);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(163, 53);
            btLogin.TabIndex = 7;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Script MT Bold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = SystemColors.ControlLightLight;
            lblId.Location = new Point(568, 312);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 15);
            lblId.TabIndex = 8;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblId);
            Controls.Add(btLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Label lblUserName;
        private Label lblPassword;
        private Button btLogin;
        private Label lblId;
    }
}