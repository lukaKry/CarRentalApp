
namespace CarRentalApp.Forms
{
    partial class ManageVehicleListing
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
            this.dgv_VehicleList = new System.Windows.Forms.DataGridView();
            this.lbl_label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_VehicleList
            // 
            this.dgv_VehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VehicleList.Location = new System.Drawing.Point(12, 70);
            this.dgv_VehicleList.Name = "dgv_VehicleList";
            this.dgv_VehicleList.RowHeadersWidth = 51;
            this.dgv_VehicleList.RowTemplate.Height = 24;
            this.dgv_VehicleList.Size = new System.Drawing.Size(776, 347);
            this.dgv_VehicleList.TabIndex = 0;
            // 
            // lbl_label1
            // 
            this.lbl_label1.AutoSize = true;
            this.lbl_label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_label1.Location = new System.Drawing.Point(12, 9);
            this.lbl_label1.Name = "lbl_label1";
            this.lbl_label1.Size = new System.Drawing.Size(393, 42);
            this.lbl_label1.TabIndex = 1;
            this.lbl_label1.Text = "Manage Vehicle Listing";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(50, 428);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(110, 46);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add new Car";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(170, 428);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(110, 46);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Edit Car";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(290, 428);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 46);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete Car";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(678, 428);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(110, 46);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_label1);
            this.Controls.Add(this.dgv_VehicleList);
            this.Name = "ManageVehicleListing";
            this.Text = "ManageViewListing";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_VehicleList;
        private System.Windows.Forms.Label lbl_label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Refresh;
    }
}