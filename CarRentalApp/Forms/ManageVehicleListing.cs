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
    public partial class ManageVehicleListing : Form
    {
        
        private readonly CarRentalEntities _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {

            var cars = _db.Cars
                    .Select(x => new {  Make = x.Make, 
                                        Model = x.Model,
                                        LicensePlate = x.LicensePlateNumber,
                                        VIN = x.VIN, 
                                        Year = x.Year,
                                        Id = x.Id})
                    .ToList();

            
            dgv_VehicleList.DataSource = cars;
            dgv_VehicleList.Columns[2].HeaderText = "License Plate";
            dgv_VehicleList.Columns[5].Visible = false;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddEditVehicle aev = new AddEditVehicle();
            aev.MdiParent = this.MdiParent;
            aev.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_VehicleList.SelectedRows.Count != 0)
            {
                var id = (int)dgv_VehicleList.SelectedRows[0].Cells["Id"].Value;
                var car = _db.Cars.FirstOrDefault(x => x.Id == id);


                AddEditVehicle aev = new AddEditVehicle(car);
                aev.MdiParent = this.MdiParent;
                aev.Show();
            }
            else
                MessageBox.Show("Select any row before click Edit button");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var id = (int)dgv_VehicleList.SelectedRows[0].Cells["Id"].Value;
            var car = _db.Cars.FirstOrDefault(x => x.Id == id);
            _db.Cars.Remove(car);
            _db.SaveChanges();

            dgv_VehicleList.Refresh();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            var cars = _db.Cars
                   .Select(x => new {
                       Make = x.Make,
                       Model = x.Model,
                       LicensePlate = x.LicensePlateNumber,
                       VIN = x.VIN,
                       Year = x.Year,
                       Id = x.Id
                   })
                   .ToList();


            dgv_VehicleList.DataSource = cars;
            dgv_VehicleList.Columns[2].HeaderText = "License Plate";
            dgv_VehicleList.Columns[5].Visible = false;
            dgv_VehicleList.Update();
        }
    }
}
