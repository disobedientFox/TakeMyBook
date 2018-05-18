namespace TakeMyBook
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.takeLabel = new System.Windows.Forms.Label();
            this.giveLabel = new System.Windows.Forms.Label();
            this.tradesLabel = new System.Windows.Forms.Label();
            this.departmentsLabel = new System.Windows.Forms.Label();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.pagesTextLabel = new System.Windows.Forms.Label();
            this.pagesLabel = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.settingsControl = new TakeMyBook.SettingsControl();
            this.giveControl = new TakeMyBook.GiveControl();
            this.departmentsControl = new TakeMyBook.DepartmentsControl();
            this.takeControl = new TakeMyBook.TakeControl();
            this.tradesControl = new TakeMyBook.TradesControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.minButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // minButton
            // 
            this.minButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.minButton.Location = new System.Drawing.Point(741, 0);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(30, 30);
            this.minButton.TabIndex = 1;
            this.minButton.Text = "_";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.closeButton.Location = new System.Drawing.Point(770, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(306, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // takeLabel
            // 
            this.takeLabel.AutoSize = true;
            this.takeLabel.Font = new System.Drawing.Font("Lato Thin", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.takeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(16)))), ((int)(((byte)(28)))));
            this.takeLabel.Location = new System.Drawing.Point(27, 46);
            this.takeLabel.Name = "takeLabel";
            this.takeLabel.Size = new System.Drawing.Size(53, 27);
            this.takeLabel.TabIndex = 10;
            this.takeLabel.Text = "Take";
            this.takeLabel.Click += new System.EventHandler(this.takeLabel_Click);
            // 
            // giveLabel
            // 
            this.giveLabel.AutoSize = true;
            this.giveLabel.Font = new System.Drawing.Font("Lato Thin", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.giveLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(16)))), ((int)(((byte)(28)))));
            this.giveLabel.Location = new System.Drawing.Point(128, 46);
            this.giveLabel.Name = "giveLabel";
            this.giveLabel.Size = new System.Drawing.Size(55, 27);
            this.giveLabel.TabIndex = 11;
            this.giveLabel.Text = "Give";
            this.giveLabel.Click += new System.EventHandler(this.giveLabel_Click);
            // 
            // tradesLabel
            // 
            this.tradesLabel.AutoSize = true;
            this.tradesLabel.Font = new System.Drawing.Font("Lato Thin", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tradesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(16)))), ((int)(((byte)(28)))));
            this.tradesLabel.Location = new System.Drawing.Point(229, 46);
            this.tradesLabel.Name = "tradesLabel";
            this.tradesLabel.Size = new System.Drawing.Size(73, 27);
            this.tradesLabel.TabIndex = 12;
            this.tradesLabel.Text = "Trades";
            this.tradesLabel.Click += new System.EventHandler(this.tradesLabel_Click);
            // 
            // departmentsLabel
            // 
            this.departmentsLabel.AutoSize = true;
            this.departmentsLabel.Font = new System.Drawing.Font("Lato Thin", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(16)))), ((int)(((byte)(28)))));
            this.departmentsLabel.Location = new System.Drawing.Point(512, 46);
            this.departmentsLabel.Name = "departmentsLabel";
            this.departmentsLabel.Size = new System.Drawing.Size(135, 27);
            this.departmentsLabel.TabIndex = 13;
            this.departmentsLabel.Text = "Departments";
            this.departmentsLabel.Click += new System.EventHandler(this.departmentsLabel_Click);
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("Lato Thin", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(16)))), ((int)(((byte)(28)))));
            this.SettingsLabel.Location = new System.Drawing.Point(685, 46);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(86, 27);
            this.SettingsLabel.TabIndex = 14;
            this.SettingsLabel.Text = "Settings";
            this.SettingsLabel.Click += new System.EventHandler(this.SettingsLabel_Click);
            // 
            // pagesTextLabel
            // 
            this.pagesTextLabel.AutoSize = true;
            this.pagesTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.pagesTextLabel.Font = new System.Drawing.Font("Lato Thin", 10F);
            this.pagesTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.pagesTextLabel.Location = new System.Drawing.Point(378, 33);
            this.pagesTextLabel.Name = "pagesTextLabel";
            this.pagesTextLabel.Size = new System.Drawing.Size(46, 17);
            this.pagesTextLabel.TabIndex = 15;
            this.pagesTextLabel.Text = "Pages:";
            // 
            // pagesLabel
            // 
            this.pagesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagesLabel.AutoSize = true;
            this.pagesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(1)))), ((int)(((byte)(29)))));
            this.pagesLabel.Font = new System.Drawing.Font("Lato Thin", 17F, System.Drawing.FontStyle.Bold);
            this.pagesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.pagesLabel.Location = new System.Drawing.Point(368, 50);
            this.pagesLabel.Name = "pagesLabel";
            this.pagesLabel.Padding = new System.Windows.Forms.Padding(5);
            this.pagesLabel.Size = new System.Drawing.Size(64, 38);
            this.pagesLabel.TabIndex = 16;
            this.pagesLabel.Text = "655";
            this.pagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.menuPanel.Location = new System.Drawing.Point(12, 76);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(91, 2);
            this.menuPanel.TabIndex = 17;
            this.menuPanel.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 450);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // settingsControl
            // 
            this.settingsControl.departments = null;
            this.settingsControl.Font = new System.Drawing.Font("Lato Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsControl.Location = new System.Drawing.Point(0, 68);
            this.settingsControl.Margin = new System.Windows.Forms.Padding(4);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Size = new System.Drawing.Size(800, 382);
            this.settingsControl.TabIndex = 20;
            // 
            // giveControl
            // 
            this.giveControl.departments = null;
            this.giveControl.Location = new System.Drawing.Point(0, 91);
            this.giveControl.Name = "giveControl";
            this.giveControl.Size = new System.Drawing.Size(800, 359);
            this.giveControl.TabIndex = 19;
            // 
            // departmentsControl
            // 
            this.departmentsControl.departments = null;
            this.departmentsControl.Font = new System.Drawing.Font("Lato Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentsControl.Location = new System.Drawing.Point(0, 91);
            this.departmentsControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentsControl.Name = "departmentsControl";
            this.departmentsControl.Size = new System.Drawing.Size(800, 359);
            this.departmentsControl.TabIndex = 18;
            // 
            // takeControl
            // 
            this.takeControl.Books = null;
            this.takeControl.departments = null;
            this.takeControl.Font = new System.Drawing.Font("Lato Thin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.takeControl.Location = new System.Drawing.Point(0, 91);
            this.takeControl.Name = "takeControl";
            this.takeControl.Size = new System.Drawing.Size(800, 359);
            this.takeControl.TabIndex = 22;
            // 
            // tradesControl
            // 
            this.tradesControl.Location = new System.Drawing.Point(0, 91);
            this.tradesControl.Name = "tradesControl";
            this.tradesControl.Size = new System.Drawing.Size(800, 359);
            this.tradesControl.TabIndex = 21;
            this.tradesControl.trades = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pagesLabel);
            this.Controls.Add(this.pagesTextLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SettingsLabel);
            this.Controls.Add(this.departmentsLabel);
            this.Controls.Add(this.tradesLabel);
            this.Controls.Add(this.giveLabel);
            this.Controls.Add(this.takeLabel);
            this.Controls.Add(this.settingsControl);
            this.Controls.Add(this.giveControl);
            this.Controls.Add(this.departmentsControl);
            this.Controls.Add(this.takeControl);
            this.Controls.Add(this.tradesControl);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label takeLabel;
        private System.Windows.Forms.Label giveLabel;
        private System.Windows.Forms.Label tradesLabel;
        private System.Windows.Forms.Label departmentsLabel;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Label pagesTextLabel;
        private System.Windows.Forms.Label pagesLabel;
        private System.Windows.Forms.Panel menuPanel;
        private DepartmentsControl departmentsControl;
        private GiveControl giveControl;
        private SettingsControl settingsControl;
        private TradesControl tradesControl;
        private TakeControl takeControl;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

