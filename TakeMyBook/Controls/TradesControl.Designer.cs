namespace TakeMyBook
{
    partial class TradesControl
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
            this.tradesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tradesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tradesDataGridView
            // 
            this.tradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tradesDataGridView.Location = new System.Drawing.Point(37, 18);
            this.tradesDataGridView.Name = "tradesDataGridView";
            this.tradesDataGridView.Size = new System.Drawing.Size(648, 322);
            this.tradesDataGridView.TabIndex = 0;
            // 
            // TradesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tradesDataGridView);
            this.Name = "TradesControl";
            this.Size = new System.Drawing.Size(711, 386);
            ((System.ComponentModel.ISupportInitialize)(this.tradesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tradesDataGridView;
    }
}
