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
            this.SuspendLayout();
            // 
            // addressComboBox
            // 
            this.addressComboBox.Enabled = false;
            this.addressComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressComboBox.FormattingEnabled = true;
            this.addressComboBox.Location = new System.Drawing.Point(494, 133);
            this.addressComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressComboBox.Name = "addressComboBox";
            this.addressComboBox.Size = new System.Drawing.Size(160, 24);
            this.addressComboBox.TabIndex = 18;
            this.addressComboBox.SelectedIndexChanged += new System.EventHandler(this.addressComboBox_SelectedIndexChanged);
            // 
            // cityComboBox
            // 
            this.cityComboBox.Enabled = false;
            this.cityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(494, 101);
            this.cityComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(160, 24);
            this.cityComboBox.TabIndex = 17;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // countryComboBox
            // 
            this.countryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(494, 69);
            this.countryComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(160, 24);
            this.countryComboBox.TabIndex = 16;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            // 
            // openingHoursTextBox
            // 
            this.openingHoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openingHoursTextBox.Location = new System.Drawing.Point(533, 174);
            this.openingHoursTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openingHoursTextBox.Name = "openingHoursTextBox";
            this.openingHoursTextBox.ReadOnly = true;
            this.openingHoursTextBox.Size = new System.Drawing.Size(151, 23);
            this.openingHoursTextBox.TabIndex = 15;
            // 
            // openingHoursTextLabel
            // 
            this.openingHoursTextLabel.AutoSize = true;
            this.openingHoursTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openingHoursTextLabel.Location = new System.Drawing.Point(419, 177);
            this.openingHoursTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.openingHoursTextLabel.Name = "openingHoursTextLabel";
            this.openingHoursTextLabel.Size = new System.Drawing.Size(106, 17);
            this.openingHoursTextLabel.TabIndex = 14;
            this.openingHoursTextLabel.Text = "Opening hours:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLabel.Location = new System.Drawing.Point(419, 137);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 13;
            this.addressLabel.Text = "Address";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityLabel.Location = new System.Drawing.Point(419, 105);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 17);
            this.cityLabel.TabIndex = 12;
            this.cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.Location = new System.Drawing.Point(419, 73);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(61, 17);
            this.countryLabel.TabIndex = 11;
            this.countryLabel.Text = "Country:";
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(65, 45);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(74, 17);
            this.nicknameLabel.TabIndex = 19;
            this.nicknameLabel.Text = "Nickname:";
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Enabled = false;
            this.nicknameTextBox.Location = new System.Drawing.Point(182, 45);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(135, 23);
            this.nicknameTextBox.TabIndex = 20;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(182, 88);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(135, 23);
            this.nameTextBox.TabIndex = 22;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(65, 88);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Name:";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(182, 197);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(135, 23);
            this.newPasswordTextBox.TabIndex = 24;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(52, 200);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(103, 17);
            this.newPasswordLabel.TabIndex = 23;
            this.newPasswordLabel.Text = "New password:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(182, 226);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(135, 23);
            this.confirmPasswordTextBox.TabIndex = 26;
            // 
            // comfirmPasswordLabel
            // 
            this.comfirmPasswordLabel.AutoSize = true;
            this.comfirmPasswordLabel.Location = new System.Drawing.Point(52, 229);
            this.comfirmPasswordLabel.Name = "comfirmPasswordLabel";
            this.comfirmPasswordLabel.Size = new System.Drawing.Size(124, 17);
            this.comfirmPasswordLabel.TabIndex = 25;
            this.comfirmPasswordLabel.Text = "Confirm password:";
            // 
            // changeNameButton
            // 
            this.changeNameButton.Location = new System.Drawing.Point(182, 131);
            this.changeNameButton.Name = "changeNameButton";
            this.changeNameButton.Size = new System.Drawing.Size(135, 26);
            this.changeNameButton.TabIndex = 27;
            this.changeNameButton.Text = "Change name";
            this.changeNameButton.UseVisualStyleBackColor = true;
            this.changeNameButton.Click += new System.EventHandler(this.changeNameButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(182, 255);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(135, 26);
            this.changePasswordButton.TabIndex = 28;
            this.changePasswordButton.Text = "Change password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // changeDepartmentButton
            // 
            this.changeDepartmentButton.Location = new System.Drawing.Point(533, 204);
            this.changeDepartmentButton.Name = "changeDepartmentButton";
            this.changeDepartmentButton.Size = new System.Drawing.Size(151, 26);
            this.changeDepartmentButton.TabIndex = 29;
            this.changeDepartmentButton.Text = "Change department";
            this.changeDepartmentButton.UseVisualStyleBackColor = true;
            this.changeDepartmentButton.Click += new System.EventHandler(this.changeDepartmentButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(182, 168);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(135, 23);
            this.passwordTextBox.TabIndex = 31;
            // 
            // paswwordLabel
            // 
            this.paswwordLabel.AutoSize = true;
            this.paswwordLabel.Location = new System.Drawing.Point(52, 171);
            this.paswwordLabel.Name = "paswwordLabel";
            this.paswwordLabel.Size = new System.Drawing.Size(73, 17);
            this.paswwordLabel.TabIndex = 30;
            this.paswwordLabel.Text = "Password:";
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(721, 293);
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
    }
}
