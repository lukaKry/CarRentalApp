
namespace CarRentalApp.Forms
{
    partial class ManageRentalRecodrs
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_label1 = new System.Windows.Forms.Label();
            this.dgv_RecordList = new System.Windows.Forms.DataGridView();
            this.carRentalDataSet = new CarRentalApp.CarRentalDataSet();
            this.carRentalRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRentalRecordTableAdapter = new CarRentalApp.CarRentalDataSetTableAdapters.CarRentalRecordTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRentedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RecordList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(678, 422);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(110, 46);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(290, 422);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 46);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete Record";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(170, 422);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(110, 46);
            this.btn_Edit.TabIndex = 9;
            this.btn_Edit.Text = "Edit Record";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(50, 422);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(110, 46);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add new Record";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_label1
            // 
            this.lbl_label1.AutoSize = true;
            this.lbl_label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_label1.Location = new System.Drawing.Point(12, 3);
            this.lbl_label1.Name = "lbl_label1";
            this.lbl_label1.Size = new System.Drawing.Size(396, 42);
            this.lbl_label1.TabIndex = 7;
            this.lbl_label1.Text = "Manage Rental Record";
            // 
            // dgv_RecordList
            // 
            this.dgv_RecordList.AllowUserToAddRows = false;
            this.dgv_RecordList.AllowUserToDeleteRows = false;
            this.dgv_RecordList.AutoGenerateColumns = false;
            this.dgv_RecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RecordList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.dateRentedDataGridViewTextBoxColumn,
            this.dateReturnedDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.carIdDataGridViewTextBoxColumn});
            this.dgv_RecordList.DataSource = this.carRentalRecordBindingSource;
            this.dgv_RecordList.Location = new System.Drawing.Point(12, 69);
            this.dgv_RecordList.Name = "dgv_RecordList";
            this.dgv_RecordList.ReadOnly = true;
            this.dgv_RecordList.RowHeadersWidth = 51;
            this.dgv_RecordList.RowTemplate.Height = 24;
            this.dgv_RecordList.Size = new System.Drawing.Size(776, 347);
            this.dgv_RecordList.TabIndex = 6;
            // 
            // carRentalDataSet
            // 
            this.carRentalDataSet.DataSetName = "CarRentalDataSet";
            this.carRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carRentalRecordBindingSource
            // 
            this.carRentalRecordBindingSource.DataMember = "CarRentalRecord";
            this.carRentalRecordBindingSource.DataSource = this.carRentalDataSet;
            // 
            // carRentalRecordTableAdapter
            // 
            this.carRentalRecordTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateRentedDataGridViewTextBoxColumn
            // 
            this.dateRentedDataGridViewTextBoxColumn.DataPropertyName = "DateRented";
            this.dateRentedDataGridViewTextBoxColumn.HeaderText = "DateRented";
            this.dateRentedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateRentedDataGridViewTextBoxColumn.Name = "dateRentedDataGridViewTextBoxColumn";
            this.dateRentedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateRentedDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateReturnedDataGridViewTextBoxColumn
            // 
            this.dateReturnedDataGridViewTextBoxColumn.DataPropertyName = "DateReturned";
            this.dateReturnedDataGridViewTextBoxColumn.HeaderText = "DateReturned";
            this.dateReturnedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateReturnedDataGridViewTextBoxColumn.Name = "dateReturnedDataGridViewTextBoxColumn";
            this.dateReturnedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateReturnedDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            this.carIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            this.carIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.carIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ManageRentalRecodrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_label1);
            this.Controls.Add(this.dgv_RecordList);
            this.Name = "ManageRentalRecodrs";
            this.Text = "ManageRentalRecodrs";
            this.Load += new System.EventHandler(this.ManageRentalRecodrs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RecordList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalRecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_label1;
        private System.Windows.Forms.DataGridView dgv_RecordList;
        private CarRentalDataSet carRentalDataSet;
        private System.Windows.Forms.BindingSource carRentalRecordBindingSource;
        private CarRentalDataSetTableAdapters.CarRentalRecordTableAdapter carRentalRecordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRentedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReturnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
    }
}