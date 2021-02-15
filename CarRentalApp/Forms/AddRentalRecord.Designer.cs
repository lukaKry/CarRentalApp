
namespace CarRentalApp
{
    partial class AddRentalRecord
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
            this.lbl_label1 = new System.Windows.Forms.Label();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_RentDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_CarType = new System.Windows.Forms.ComboBox();
            this.lbl_CarType = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_costs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_label1
            // 
            this.lbl_label1.AutoSize = true;
            this.lbl_label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_label1.Location = new System.Drawing.Point(10, 19);
            this.lbl_label1.Name = "lbl_label1";
            this.lbl_label1.Size = new System.Drawing.Size(330, 42);
            this.lbl_label1.TabIndex = 0;
            this.lbl_label1.Text = "Add Rental Record";
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Location = new System.Drawing.Point(17, 95);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(248, 22);
            this.txt_CustomerName.TabIndex = 1;
            this.txt_CustomerName.Text = "Default Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            // 
            // dtp_RentDate
            // 
            this.dtp_RentDate.Location = new System.Drawing.Point(17, 179);
            this.dtp_RentDate.Name = "dtp_RentDate";
            this.dtp_RentDate.Size = new System.Drawing.Size(248, 22);
            this.dtp_RentDate.TabIndex = 3;
            // 
            // dtp_ReturnDate
            // 
            this.dtp_ReturnDate.Location = new System.Drawing.Point(373, 179);
            this.dtp_ReturnDate.Name = "dtp_ReturnDate";
            this.dtp_ReturnDate.Size = new System.Drawing.Size(248, 22);
            this.dtp_ReturnDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rent Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(369, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Return Date";
            // 
            // cmb_CarType
            // 
            this.cmb_CarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CarType.FormattingEnabled = true;
            this.cmb_CarType.Location = new System.Drawing.Point(16, 262);
            this.cmb_CarType.Name = "cmb_CarType";
            this.cmb_CarType.Size = new System.Drawing.Size(249, 24);
            this.cmb_CarType.TabIndex = 7;
            // 
            // lbl_CarType
            // 
            this.lbl_CarType.AutoSize = true;
            this.lbl_CarType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_CarType.Location = new System.Drawing.Point(13, 240);
            this.lbl_CarType.Name = "lbl_CarType";
            this.lbl_CarType.Size = new System.Drawing.Size(76, 19);
            this.lbl_CarType.TabIndex = 8;
            this.lbl_CarType.Text = "Car Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(369, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total Costs";
            // 
            // txt_costs
            // 
            this.txt_costs.Location = new System.Drawing.Point(373, 95);
            this.txt_costs.Name = "txt_costs";
            this.txt_costs.Size = new System.Drawing.Size(248, 22);
            this.txt_costs.TabIndex = 10;
            // 
            // AddRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 314);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_costs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_CarType);
            this.Controls.Add(this.cmb_CarType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_ReturnDate);
            this.Controls.Add(this.dtp_RentDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CustomerName);
            this.Controls.Add(this.lbl_label1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "AddRentalRecord";
            this.ShowIcon = false;
            this.Text = "Car Rental System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_label1;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_RentDate;
        private System.Windows.Forms.DateTimePicker dtp_ReturnDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_CarType;
        private System.Windows.Forms.Label lbl_CarType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_costs;
    }
}

