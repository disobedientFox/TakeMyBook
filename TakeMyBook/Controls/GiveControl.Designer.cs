namespace TakeMyBook
{
    partial class GiveControl
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.pubHouseTextBox = new System.Windows.Forms.TextBox();
            this.publishingHouseLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.piblishYearLabel = new System.Windows.Forms.Label();
            this.pagesCountLabel = new System.Windows.Forms.Label();
            this.giveButton = new System.Windows.Forms.Button();
            this.pagesCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pagesCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(38, 31);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(131, 28);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(125, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(131, 54);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(125, 20);
            this.authorTextBox.TabIndex = 3;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(38, 57);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Author:";
            // 
            // pubHouseTextBox
            // 
            this.pubHouseTextBox.Location = new System.Drawing.Point(131, 80);
            this.pubHouseTextBox.Name = "pubHouseTextBox";
            this.pubHouseTextBox.Size = new System.Drawing.Size(125, 20);
            this.pubHouseTextBox.TabIndex = 5;
            // 
            // publishingHouseLabel
            // 
            this.publishingHouseLabel.AutoSize = true;
            this.publishingHouseLabel.Location = new System.Drawing.Point(38, 83);
            this.publishingHouseLabel.Name = "publishingHouseLabel";
            this.publishingHouseLabel.Size = new System.Drawing.Size(90, 13);
            this.publishingHouseLabel.TabIndex = 4;
            this.publishingHouseLabel.Text = "Publishing house:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(131, 106);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(125, 20);
            this.yearTextBox.TabIndex = 7;
            // 
            // piblishYearLabel
            // 
            this.piblishYearLabel.AutoSize = true;
            this.piblishYearLabel.Location = new System.Drawing.Point(38, 109);
            this.piblishYearLabel.Name = "piblishYearLabel";
            this.piblishYearLabel.Size = new System.Drawing.Size(67, 13);
            this.piblishYearLabel.TabIndex = 6;
            this.piblishYearLabel.Text = "Publish year:";
            // 
            // pagesCountLabel
            // 
            this.pagesCountLabel.AutoSize = true;
            this.pagesCountLabel.Location = new System.Drawing.Point(38, 135);
            this.pagesCountLabel.Name = "pagesCountLabel";
            this.pagesCountLabel.Size = new System.Drawing.Size(70, 13);
            this.pagesCountLabel.TabIndex = 8;
            this.pagesCountLabel.Text = "Pages count:";
            // 
            // giveButton
            // 
            this.giveButton.Location = new System.Drawing.Point(286, 223);
            this.giveButton.Name = "giveButton";
            this.giveButton.Size = new System.Drawing.Size(75, 23);
            this.giveButton.TabIndex = 10;
            this.giveButton.Text = "Give!";
            this.giveButton.UseVisualStyleBackColor = true;
            this.giveButton.Click += new System.EventHandler(this.giveButton_Click);
            // 
            // pagesCountNumericUpDown
            // 
            this.pagesCountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pagesCountNumericUpDown.Location = new System.Drawing.Point(131, 131);
            this.pagesCountNumericUpDown.Name = "pagesCountNumericUpDown";
            this.pagesCountNumericUpDown.Size = new System.Drawing.Size(125, 23);
            this.pagesCountNumericUpDown.TabIndex = 11;
            // 
            // GiveControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pagesCountNumericUpDown);
            this.Controls.Add(this.giveButton);
            this.Controls.Add(this.pagesCountLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.piblishYearLabel);
            this.Controls.Add(this.pubHouseTextBox);
            this.Controls.Add(this.publishingHouseLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "GiveControl";
            this.Size = new System.Drawing.Size(664, 311);
            ((System.ComponentModel.ISupportInitialize)(this.pagesCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox pubHouseTextBox;
        private System.Windows.Forms.Label publishingHouseLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label piblishYearLabel;
        private System.Windows.Forms.Label pagesCountLabel;
        private System.Windows.Forms.Button giveButton;
        private System.Windows.Forms.NumericUpDown pagesCountNumericUpDown;
    }
}
