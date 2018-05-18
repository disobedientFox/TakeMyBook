namespace TakeMyBook
{
    partial class DepartmentsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentsControl));
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.openingHoursTextLabel = new System.Windows.Forms.Label();
            this.openingHoursTextBox = new System.Windows.Forms.TextBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.addressComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.countryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.countryLabel.Location = new System.Drawing.Point(372, 97);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(70, 19);
            this.countryLabel.TabIndex = 0;
            this.countryLabel.Text = "Country:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.cityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.cityLabel.Location = new System.Drawing.Point(372, 135);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(40, 19);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.addressLabel.Location = new System.Drawing.Point(372, 173);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(64, 19);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // openingHoursTextLabel
            // 
            this.openingHoursTextLabel.AutoSize = true;
            this.openingHoursTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.openingHoursTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.openingHoursTextLabel.Location = new System.Drawing.Point(532, 220);
            this.openingHoursTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.openingHoursTextLabel.Name = "openingHoursTextLabel";
            this.openingHoursTextLabel.Size = new System.Drawing.Size(116, 19);
            this.openingHoursTextLabel.TabIndex = 6;
            this.openingHoursTextLabel.Text = "Opening hours:";
            // 
            // openingHoursTextBox
            // 
            this.openingHoursTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.openingHoursTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.openingHoursTextBox.Location = new System.Drawing.Point(500, 244);
            this.openingHoursTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openingHoursTextBox.Name = "openingHoursTextBox";
            this.openingHoursTextBox.ReadOnly = true;
            this.openingHoursTextBox.Size = new System.Drawing.Size(180, 27);
            this.openingHoursTextBox.TabIndex = 7;
            // 
            // countryComboBox
            // 
            this.countryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(500, 94);
            this.countryComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(180, 27);
            this.countryComboBox.TabIndex = 8;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            // 
            // cityComboBox
            // 
            this.cityComboBox.Enabled = false;
            this.cityComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(500, 132);
            this.cityComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(180, 27);
            this.cityComboBox.TabIndex = 9;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // addressComboBox
            // 
            this.addressComboBox.Enabled = false;
            this.addressComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.addressComboBox.FormattingEnabled = true;
            this.addressComboBox.Location = new System.Drawing.Point(500, 170);
            this.addressComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressComboBox.Name = "addressComboBox";
            this.addressComboBox.Size = new System.Drawing.Size(180, 27);
            this.addressComboBox.TabIndex = 10;
            this.addressComboBox.SelectedIndexChanged += new System.EventHandler(this.addressComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 359);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // DepartmentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DepartmentsControl";
            this.Size = new System.Drawing.Size(800, 359);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label openingHoursTextLabel;
        private System.Windows.Forms.TextBox openingHoursTextBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ComboBox addressComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
