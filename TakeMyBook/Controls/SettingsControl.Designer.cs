namespace TakeMyBook
{
    partial class SettingsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            this.addressComboBox = new System.Windows.Forms.ComboBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.openingHoursTextBox = new System.Windows.Forms.TextBox();
            this.openingHoursTextLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.comfirmPasswordLabel = new System.Windows.Forms.Label();
            this.changeNameButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.changeDepartmentButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.paswwordLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addressComboBox
            // 
            this.addressComboBox.Enabled = false;
            this.addressComboBox.Font = new System.Drawing.Font("Lato Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.addressComboBox.FormattingEnabled = true;
            this.addressComboBox.Location = new System.Drawing.Point(616, 144);
            this.addressComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressComboBox.Name = "addressComboBox";
            this.addressComboBox.Size = new System.Drawing.Size(156, 27);
            this.addressComboBox.TabIndex = 18;
            this.addressComboBox.SelectedIndexChanged += new System.EventHandler(this.addressComboBox_SelectedIndexChanged);
            // 
            // cityComboBox
            // 
            this.cityComboBox.Enabled = false;
            this.cityComboBox.Font = new System.Drawing.Font("Lato Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(616, 112);
            this.cityComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(156, 27);
            this.cityComboBox.TabIndex = 17;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // countryComboBox
            // 
            this.countryComboBox.Font = new System.Drawing.Font("Lato Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(616, 80);
            this.countryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(156, 27);
            this.countryComboBox.TabIndex = 16;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            // 
            // openingHoursTextBox
            // 
            this.openingHoursTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.openingHoursTextBox.Font = new System.Drawing.Font("Lato Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openingHoursTextBox.Location = new System.Drawing.Point(616, 200);
            this.openingHoursTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.openingHoursTextBox.Name = "openingHoursTextBox";
            this.openingHoursTextBox.ReadOnly = true;
            this.openingHoursTextBox.Size = new System.Drawing.Size(156, 27);
            this.openingHoursTextBox.TabIndex = 15;
            // 
            // openingHoursTextLabel
            // 
            this.openingHoursTextLabel.AutoSize = true;
            this.openingHoursTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.openingHoursTextLabel.Font = new System.Drawing.Font("Lato Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openingHoursTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.openingHoursTextLabel.Location = new System.Drawing.Point(637, 179);
            this.openingHoursTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.openingHoursTextLabel.Name = "openingHoursTextLabel";
            this.openingHoursTextLabel.Size = new System.Drawing.Size(116, 19);
            this.openingHoursTextLabel.TabIndex = 14;
            this.openingHoursTextLabel.Text = "Opening hours:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.addressLabel.Font = new System.Drawing.Font("Lato Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.addressLabel.Location = new System.Drawing.Point(533, 147);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(68, 19);
            this.addressLabel.TabIndex = 13;
            this.addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.cityLabel.Font = new System.Drawing.Font("Lato Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.cityLabel.Location = new System.Drawing.Point(533, 115);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(40, 19);
            this.cityLabel.TabIndex = 12;
            this.cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.countryLabel.Font = new System.Drawing.Font("Lato Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.countryLabel.Location = new System.Drawing.Point(531, 83);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(70, 19);
            this.countryLabel.TabIndex = 11;
            this.countryLabel.Text = "Country:";
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.nicknameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.nicknameLabel.Location = new System.Drawing.Point(77, 57);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(81, 19);
            this.nicknameLabel.TabIndex = 19;
            this.nicknameLabel.Text = "Nickname:";
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.nicknameTextBox.Enabled = false;
            this.nicknameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.nicknameTextBox.Location = new System.Drawing.Point(45, 80);
            this.nicknameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.ReadOnly = true;
            this.nicknameTextBox.Size = new System.Drawing.Size(151, 27);
            this.nicknameTextBox.TabIndex = 20;
            // 
            // nameTextBox
            // 
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.nameTextBox.Location = new System.Drawing.Point(339, 80);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(151, 27);
            this.nameTextBox.TabIndex = 22;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.nameLabel.Location = new System.Drawing.Point(265, 83);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(54, 19);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Name:";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.newPasswordTextBox.Location = new System.Drawing.Point(339, 233);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(151, 27);
            this.newPasswordTextBox.TabIndex = 24;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.newPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.newPasswordLabel.Location = new System.Drawing.Point(217, 236);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(116, 19);
            this.newPasswordLabel.TabIndex = 23;
            this.newPasswordLabel.Text = "New password:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(339, 266);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(151, 27);
            this.confirmPasswordTextBox.TabIndex = 26;
            // 
            // comfirmPasswordLabel
            // 
            this.comfirmPasswordLabel.AutoSize = true;
            this.comfirmPasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.comfirmPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.comfirmPasswordLabel.Location = new System.Drawing.Point(193, 269);
            this.comfirmPasswordLabel.Name = "comfirmPasswordLabel";
            this.comfirmPasswordLabel.Size = new System.Drawing.Size(140, 19);
            this.comfirmPasswordLabel.TabIndex = 25;
            this.comfirmPasswordLabel.Text = "Confirm password:";
            // 
            // changeNameButton
            // 
            this.changeNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.changeNameButton.FlatAppearance.BorderSize = 0;
            this.changeNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeNameButton.ForeColor = System.Drawing.Color.White;
            this.changeNameButton.Location = new System.Drawing.Point(339, 115);
            this.changeNameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeNameButton.Name = "changeNameButton";
            this.changeNameButton.Size = new System.Drawing.Size(151, 31);
            this.changeNameButton.TabIndex = 27;
            this.changeNameButton.Text = "Change name";
            this.changeNameButton.UseVisualStyleBackColor = false;
            this.changeNameButton.Click += new System.EventHandler(this.changeNameButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.changePasswordButton.FlatAppearance.BorderSize = 0;
            this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordButton.ForeColor = System.Drawing.Color.White;
            this.changePasswordButton.Location = new System.Drawing.Point(338, 301);
            this.changePasswordButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(152, 31);
            this.changePasswordButton.TabIndex = 28;
            this.changePasswordButton.Text = "Change password";
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // changeDepartmentButton
            // 
            this.changeDepartmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.changeDepartmentButton.FlatAppearance.BorderSize = 0;
            this.changeDepartmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDepartmentButton.ForeColor = System.Drawing.Color.White;
            this.changeDepartmentButton.Location = new System.Drawing.Point(616, 233);
            this.changeDepartmentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeDepartmentButton.Name = "changeDepartmentButton";
            this.changeDepartmentButton.Size = new System.Drawing.Size(156, 31);
            this.changeDepartmentButton.TabIndex = 29;
            this.changeDepartmentButton.Text = "Change department";
            this.changeDepartmentButton.UseVisualStyleBackColor = false;
            this.changeDepartmentButton.Click += new System.EventHandler(this.changeDepartmentButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.passwordTextBox.Location = new System.Drawing.Point(339, 200);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(151, 27);
            this.passwordTextBox.TabIndex = 31;
            // 
            // paswwordLabel
            // 
            this.paswwordLabel.AutoSize = true;
            this.paswwordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.paswwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.paswwordLabel.Location = new System.Drawing.Point(253, 203);
            this.paswwordLabel.Name = "paswwordLabel";
            this.paswwordLabel.Size = new System.Drawing.Size(80, 19);
            this.paswwordLabel.TabIndex = 30;
            this.paswwordLabel.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 359);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.paswwordLabel);
            this.Controls.Add(this.changeDepartmentButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.changeNameButton);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.comfirmPasswordLabel);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.addressComboBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.openingHoursTextBox);
            this.Controls.Add(this.openingHoursTextLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Lato Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(800, 359);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox addressComboBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.TextBox openingHoursTextBox;
        private System.Windows.Forms.Label openingHoursTextLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label comfirmPasswordLabel;
        private System.Windows.Forms.Button changeNameButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button changeDepartmentButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label paswwordLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
