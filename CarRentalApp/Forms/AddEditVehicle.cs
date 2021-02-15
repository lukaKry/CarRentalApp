using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp.Forms
{
    public partial class AddEditVehicle : Form
    {
        //private Car carToEdit;
        private readonly CarRentalEntities _db = new CarRentalEntities();
        private bool isEditMode;
        public AddEditVehicle()
        {
            InitializeComponent();
            lbl_Title.Text = "Add New Vehicle";
            isEditMode = false;
        }

        public AddEditVehicle(Car carToEdit)
        {
            InitializeComponent();
            lbl_Title.Text = "Edit Vehicle";
            PopulateFields(carToEdit);
            isEditMode = true;
           // this.carToEdit = carToEdit;
        }

        private void PopulateFields(Car carToEdit)
        {
            txt_Make.Text = carToEdit.Make;
            txt_Model.Text = carToEdit.Model;
            txt_LicensePlate.Text = carToEdit.LicensePlateNumber;
            txt_Vin.Text = carToEdit.VIN;
            txt_Year.Text = carToEdit.Year.ToString();
            lbl_Id.Text = carToEdit.Id.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                //Edit code here
                var id = int.Parse(lbl_Id.Text);
                var carToEdit = _db.Cars.FirstOrDefault(x => x.Id == id);

                carToEdit.Make = txt_Make.Text;
                carToEdit.Model = txt_Model.Text;
                carToEdit.LicensePlateNumber = txt_LicensePlate.Text;
                carToEdit.VIN = txt_Vin.Text;
                carToEdit.Year = int.Parse(txt_Year.Text);

                _db.SaveChanges();
                MessageBox.Show("Data saved successfully");
                this.Close();
                
            }
            else
            {
                //Add code here
                Car carToEdit = new Car()
                {
                    Make = txt_Make.Text,
                    Model = txt_Model.Text,
                    LicensePlateNumber = txt_LicensePlate.Text,
                    VIN = txt_Vin.Text,
                    Year = int.Parse(txt_Year.Text)
                };

                _db.Cars.Add(carToEdit);
                _db.SaveChanges();
                MessageBox.Show("Data edited successfully");
                this.Close();


            }
        }

    private void btn_Cancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
}
