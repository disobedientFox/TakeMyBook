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
            this.components = new System.ComponentModel.Container();
            this.tradesDataGridView = new System.Windows.Forms.DataGridView();
            this.tradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isGivenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tradesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tradesDataGridView
            // 
            this.tradesDataGridView.AutoGenerateColumns = false;
            this.tradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tradesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bookDataGridViewTextBoxColumn,
            this.readerDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.isGivenDataGridViewCheckBoxColumn});
            this.tradesDataGridView.DataSource = this.tradeBindingSource;
            this.tradesDataGridView.Location = new System.Drawing.Point(37, 18);
            this.tradesDataGridView.Name = "tradesDataGridView";
            this.tradesDataGridView.Size = new System.Drawing.Size(643, 261);
            this.tradesDataGridView.TabIndex = 0;
            // 
            // tradeBindingSource
            // 
            this.tradeBindingSource.DataSource = typeof(TakeMyBook.Trade);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // bookDataGridViewTextBoxColumn
            // 
            this.bookDataGridViewTextBoxColumn.DataPropertyName = "book";
            this.bookDataGridViewTextBoxColumn.HeaderText = "book";
            this.bookDataGridViewTextBoxColumn.Name = "bookDataGridViewTextBoxColumn";
            // 
            // readerDataGridViewTextBoxColumn
            // 
            this.readerDataGridViewTextBoxColumn.DataPropertyName = "reader";
            this.readerDataGridViewTextBoxColumn.HeaderText = "reader";
            this.readerDataGridViewTextBoxColumn.Name = "readerDataGridViewTextBoxColumn";
            this.readerDataGridViewTextBoxColumn.Visible = false;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // isGivenDataGridViewCheckBoxColumn
            // 
            this.isGivenDataGridViewCheckBoxColumn.DataPropertyName = "IsGiven";
            this.isGivenDataGridViewCheckBoxColumn.HeaderText = "IsGiven";
            this.isGivenDataGridViewCheckBoxColumn.Name = "isGivenDataGridViewCheckBoxColumn";
            // 
            // TradesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tradesDataGridView);
            this.Name = "TradesControl";
            this.Size = new System.Drawing.Size(712, 302);
            ((System.ComponentModel.ISupportInitialize)(this.tradesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tradesDataGridView;
        private System.Windows.Forms.BindingSource tradeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isGivenDataGridViewCheckBoxColumn;
    }
}
