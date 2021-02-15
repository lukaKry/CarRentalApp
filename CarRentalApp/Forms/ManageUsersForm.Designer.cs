
namespace CarRentalApp.Forms
{
    partial class ManageUsersForm
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Deactive = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_label1 = new System.Windows.Forms.Label();
            this.dgv_UserList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(678, 423);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(110, 46);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Deactive
            // 
            this.btn_Deactive.Location = new System.Drawing.Point(290, 423);
            this.btn_Deactive.Name = "btn_Deactive";
            this.btn_Deactive.Size = new System.Drawing.Size(144, 46);
            this.btn_Deactive.TabIndex = 10;
            this.btn_Deactive.Text = "Activate or Deactivate User";
            this.btn_Deactive.UseVisualStyleBackColor = true;
            this.btn_Deactive.Click += new System.EventHandler(this.btn_Deactive_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(170, 423);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(110, 46);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Reset Password";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(50, 423);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(110, 46);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add new User";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_label1
            // 
            this.lbl_label1.AutoSize = true;
            this.lbl_label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_label1.Location = new System.Drawing.Point(12, 4);
            this.lbl_label1.Name = "lbl_label1";
            this.lbl_label1.Size = new System.Drawing.Size(371, 42);
            this.lbl_label1.TabIndex = 7;
            this.lbl_label1.Text = "Manage Users Listing";
            // 
            // dgv_UserList
            // 
            this.dgv_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserList.Location = new System.Drawing.Point(12, 65);
            this.dgv_UserList.Name = "dgv_UserList";
            this.dgv_UserList.RowHeadersWidth = 51;
            this.dgv_UserList.RowTemplate.Height = 24;
            this.dgv_UserList.Size = new System.Drawing.Size(776, 347);
            this.dgv_UserList.TabIndex = 6;
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Deactive);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_label1);
            this.Controls.Add(this.dgv_UserList);
            this.Name = "ManageUsersForm";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Deactive;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_label1;
        private System.Windows.Forms.DataGridView dgv_UserList;
    }
}