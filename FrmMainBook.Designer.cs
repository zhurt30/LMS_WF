namespace LMS_WindowsForms
{
    partial class FrmMainBook
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainBook));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpIntime = new System.Windows.Forms.DateTimePicker();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Lbl_Intime = new System.Windows.Forms.Label();
            this.Lbl_Publisher = new System.Windows.Forms.Label();
            this.Lbl_Bookprice = new System.Windows.Forms.Label();
            this.Lbl_Bookname = new System.Windows.Forms.Label();
            this.Lbl_Bookcode = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.bookcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbbookinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_LibraryMSDataSet = new LMS_WindowsForms.db_LibraryMSDataSet();
            this.tb_bookinfoTableAdapter = new LMS_WindowsForms.db_LibraryMSDataSetTableAdapters.tb_bookinfoTableAdapter();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbookinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_LibraryMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.dtpIntime);
            this.groupBox1.Controls.Add(this.txtPublisher);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtBookName);
            this.groupBox1.Controls.Add(this.txtBarCode);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.Lbl_Intime);
            this.groupBox1.Controls.Add(this.Lbl_Publisher);
            this.groupBox1.Controls.Add(this.Lbl_Bookprice);
            this.groupBox1.Controls.Add(this.Lbl_Bookname);
            this.groupBox1.Controls.Add(this.Lbl_Bookcode);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Library Information System";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(521, 135);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete book";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dtpIntime
            // 
            this.dtpIntime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIntime.Location = new System.Drawing.Point(608, 73);
            this.dtpIntime.Name = "dtpIntime";
            this.dtpIntime.Size = new System.Drawing.Size(100, 20);
            this.dtpIntime.TabIndex = 12;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(81, 73);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(334, 20);
            this.txtPublisher.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(608, 26);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(315, 26);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(100, 20);
            this.txtBookName.TabIndex = 9;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(81, 26);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(96, 20);
            this.txtBarCode.TabIndex = 8;
            this.txtBarCode.Validated += new System.EventHandler(this.TxtBarCode_Validated);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(366, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(228, 135);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit book";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(66, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add book";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Lbl_Intime
            // 
            this.Lbl_Intime.AutoSize = true;
            this.Lbl_Intime.Location = new System.Drawing.Point(518, 80);
            this.Lbl_Intime.Name = "Lbl_Intime";
            this.Lbl_Intime.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Intime.TabIndex = 4;
            this.Lbl_Intime.Text = "Intime";
            // 
            // Lbl_Publisher
            // 
            this.Lbl_Publisher.AutoSize = true;
            this.Lbl_Publisher.Location = new System.Drawing.Point(18, 76);
            this.Lbl_Publisher.Name = "Lbl_Publisher";
            this.Lbl_Publisher.Size = new System.Drawing.Size(49, 13);
            this.Lbl_Publisher.TabIndex = 3;
            this.Lbl_Publisher.Text = "publisher";
            // 
            // Lbl_Bookprice
            // 
            this.Lbl_Bookprice.AutoSize = true;
            this.Lbl_Bookprice.Location = new System.Drawing.Point(507, 33);
            this.Lbl_Bookprice.Name = "Lbl_Bookprice";
            this.Lbl_Bookprice.Size = new System.Drawing.Size(55, 13);
            this.Lbl_Bookprice.TabIndex = 2;
            this.Lbl_Bookprice.Text = "Bookprice";
            // 
            // Lbl_Bookname
            // 
            this.Lbl_Bookname.AutoSize = true;
            this.Lbl_Bookname.Location = new System.Drawing.Point(225, 33);
            this.Lbl_Bookname.Name = "Lbl_Bookname";
            this.Lbl_Bookname.Size = new System.Drawing.Size(58, 13);
            this.Lbl_Bookname.TabIndex = 1;
            this.Lbl_Bookname.Text = "Bookname";
            // 
            // Lbl_Bookcode
            // 
            this.Lbl_Bookcode.AutoSize = true;
            this.Lbl_Bookcode.Location = new System.Drawing.Point(18, 33);
            this.Lbl_Bookcode.Name = "Lbl_Bookcode";
            this.Lbl_Bookcode.Size = new System.Drawing.Size(56, 13);
            this.Lbl_Bookcode.TabIndex = 0;
            this.Lbl_Bookcode.Text = "Bookcode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBookList);
            this.groupBox2.Location = new System.Drawing.Point(16, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Information";
            // 
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToOrderColumns = true;
            this.dgvBookList.AutoGenerateColumns = false;
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookcode,
            this.bookname,
            this.price,
            this.publisher,
            this.inTime});
            this.dgvBookList.DataSource = this.tbbookinfoBindingSource;
            this.dgvBookList.Location = new System.Drawing.Point(20, 19);
            this.dgvBookList.MultiSelect = false;
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.Size = new System.Drawing.Size(702, 159);
            this.dgvBookList.TabIndex = 0;
            this.dgvBookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBookList_CellContentClick);
            this.dgvBookList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBookList_RowEnter);
            // 
            // bookcode
            // 
            this.bookcode.DataPropertyName = "bookcode";
            this.bookcode.HeaderText = "bookcode";
            this.bookcode.Name = "bookcode";
            // 
            // bookname
            // 
            this.bookname.DataPropertyName = "bookname";
            this.bookname.HeaderText = "bookname";
            this.bookname.Name = "bookname";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // publisher
            // 
            this.publisher.DataPropertyName = "pubname";
            this.publisher.HeaderText = "publisher";
            this.publisher.Name = "publisher";
            // 
            // inTime
            // 
            this.inTime.DataPropertyName = "inTime";
            this.inTime.HeaderText = "inTime";
            this.inTime.Name = "inTime";
            // 
            // tbbookinfoBindingSource
            // 
            this.tbbookinfoBindingSource.DataMember = "tb_bookinfo";
            this.tbbookinfoBindingSource.DataSource = this.db_LibraryMSDataSet;
            // 
            // db_LibraryMSDataSet
            // 
            this.db_LibraryMSDataSet.DataSetName = "db_LibraryMSDataSet";
            this.db_LibraryMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_bookinfoTableAdapter
            // 
            this.tb_bookinfoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMainBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainBook";
            this.Text = "FrmMainBook";
            this.Load += new System.EventHandler(this.FrmMainBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbookinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_LibraryMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_Intime;
        private System.Windows.Forms.Label Lbl_Publisher;
        private System.Windows.Forms.Label Lbl_Bookprice;
        private System.Windows.Forms.Label Lbl_Bookname;
        private System.Windows.Forms.Label Lbl_Bookcode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpIntime;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvBookList;
        private db_LibraryMSDataSet db_LibraryMSDataSet;
        private System.Windows.Forms.BindingSource tbbookinfoBindingSource;
        private db_LibraryMSDataSetTableAdapters.tb_bookinfoTableAdapter tb_bookinfoTableAdapter;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookname;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn inTime;
    }
}

