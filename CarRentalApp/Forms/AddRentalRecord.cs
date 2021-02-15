using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class AddRentalRecord : Form
    {
        public event EventHandler AddedData;
        private readonly CarRentalEntities carRentalEntities;
        BindingSource bs;
        private bool isEditMode;
        private CarRentalRecord record;

        public AddRentalRecord()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
            bs = new BindingSource();
            isEditMode = false;
        }

        public AddRentalRecord(CarRentalRecord record)
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
            bs = new BindingSource();
            isEditMode = true;
            this.record = record;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //w taki sposób mozemy pobrać dane z combobox połączonego z bazą danych
            var display = cmb_CarType.Text;
            var value = cmb_CarType.SelectedValue;


            //pobieranie danych z pól tekstowych i wprowadzenie ich do bazy danych
            //za pośrednictwem nowo stworzonego obiektu klasy CarRetnalRecord (automatyczna klasa stworzona na wzór tabeli w bazie danych)
            
            
            if (DataValidation())
            {
                //stworzenie nowego obiektu na cele utworzenia nowego wpisu do bazy danych
                var newr = new CarRentalRecord();

                newr.CustomerName = txt_CustomerName.Text;
                newr.DateRented = dtp_RentDate.Value;
                newr.DateReturned = dtp_ReturnDate.Value;
                newr.Cost = Decimal.Parse(txt_costs.Text);
                newr.CarId = Convert.ToInt32(cmb_CarType.SelectedValue);

                carRentalEntities.CarRentalRecords.Add(newr);
                carRentalEntities.SaveChanges();

                OnAddedData(EventArgs.Empty);
                carRentalEntities.SaveChanges();
                MessageBox.Show("Data updated successfully");
                Close();

            }
            else
                MessageBox.Show("Your Data is invalid\nCheck your form for incorrect data.", "Data Validation System");

        }

        protected virtual void OnAddedData(EventArgs e)
        {
            AddedData?.Invoke(this, e);
        }

        private bool DataValidation()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txt_CustomerName.Text) || string.IsNullOrWhiteSpace(txt_CustomerName.Text))
                result = false;

            if(string.IsNullOrEmpty(txt_costs.Text) || string.IsNullOrWhiteSpace(txt_costs.Text))
                result = false;

            decimal res;
            if (!Decimal.TryParse(txt_costs.Text, out res))
                result = false;

            if (dtp_RentDate.Value > dtp_ReturnDate.Value)
                result = false;

            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cars = carRentalEntities.Cars
                .Select(x => new { CarType = x.Make + " " + x.Model, Id = x.Id})
                .ToList();
            bs.DataSource = cars;
            cmb_CarType.DataSource = bs;
            //wartość wyświetlana przez combobox dla obiektu typu 'Car' (klasa Car została utworzona automatycznie podczas łączenie bazy danych z aplikacją)
            //Jeśli nie określimy tej właściwości poniżej w polu combobox na każdym obiekcie z listy zostanie wywołana metoda ToString()
            //jeśli nie sami nie nadpisaliśmy tej metody w tej klasie, to zostanie ona wywowałana w sposób domyślny i po prostu wyświetli pełną nazwę obiektu typu system.database.object.entity.car...bla bla
            cmb_CarType.DisplayMember = "CarType";
            //wartość przechowywana przez combobox
            //czyli wartość, którą można potem pobrać z combobox.value
            cmb_CarType.ValueMember = "Id";


            if (isEditMode)
            {
                txt_CustomerName.Text = record.CustomerName;
                txt_costs.Text = record.Cost.ToString();
                dtp_RentDate.Value = record.DateRented ?? DateTime.MinValue;
                dtp_ReturnDate.Value = record.DateReturned ?? DateTime.MinValue;


                var car = cars.FirstOrDefault(x => x.Id == record.CarId);
                int index = cars.IndexOf(car);
                cmb_CarType.SelectedIndex = index ;
                
            }
            
        }
    }
}
