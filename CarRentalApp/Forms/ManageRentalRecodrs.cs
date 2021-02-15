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
    public partial class ManageRentalRecodrs : Form
    {
        private readonly CarRentalEntities _db = new CarRentalEntities();
        BindingSource bs = new BindingSource();
        public ManageRentalRecodrs()
        {
            InitializeComponent();
            

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddRentalRecord arr = new AddRentalRecord
            {
                MdiParent = this.MdiParent,
                WindowState = FormWindowState.Maximized
            };
            arr.Show();

            arr.AddedData += ManageRentalRecodrs_Load;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {


                //get the record object from selection
                var id = (int)dgv_RecordList.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value;
                var record = _db.CarRentalRecords.FirstOrDefault(a => a.Id == id);
                AddRentalRecord arr = new AddRentalRecord(record);
                arr.MdiParent = this.MdiParent;
                arr.WindowState = FormWindowState.Maximized;
                arr.Show();
                arr.AddedData += ManageRentalRecodrs_Load;
            }
            catch(Exception)
            {
                MessageBox.Show("Select at least one row.");
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {


                var id = (int)dgv_RecordList.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value;
                var record = _db.CarRentalRecords.FirstOrDefault(a => a.Id == id);
                _db.CarRentalRecords.Remove(record);
                _db.SaveChanges();
                ManageRentalRecodrs_Load(sender, e);
            }
            catch(Exception)
            {
                MessageBox.Show("Select at least one row");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ManageRentalRecodrs_Load(sender, e);
        }

        private void ManageRentalRecodrs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDataSet.CarRentalRecord' table. You can move, or remove it, as needed.
            this.carRentalRecordTableAdapter.Fill(this.carRentalDataSet.CarRentalRecord);
            

        }
    }
}
