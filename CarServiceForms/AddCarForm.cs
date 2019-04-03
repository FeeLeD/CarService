using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CarService;

namespace CarServiceForms
{
    public partial class AddCarForm : Form
    {
        public List<Cars> Cars { get; set; }
        public List<Trucks> Trucks { get; set; }
        public ListBox CarsListBox { get; set; }
        public ListBox TrucksListBox { get; set; }

        public bool IsCar { get; set; }

        Cars Car = new Cars();
        Trucks Truck = new Trucks();

        ListBox MainListBox;

        public AddCarForm(ListBox mainListBox)
        {
            InitializeComponent();
            MainListBox = mainListBox;
            manufactureDateTimePicker.MaxDate = DateTime.Today;
        }

        private void addCar_Click(object sender, EventArgs e)
        {
            if (IsCar)
            { 
                AddingNewCar(carsNames.Text, carModelTextBox.Text, vinTextBox.Text, engineVolume.Text,
                    manufactureDateTimePicker.Value);
                MainListBox.DataSource = null;
                MainListBox.DataSource = Cars;
            }
            else
            {
                AddingNewTruck(truckNames.Text, carModelTextBox.Text, vinTextBox.Text, engineVolume.Text,
                    manufactureDateTimePicker.Value);
                MainListBox.DataSource = null;
                MainListBox.DataSource = Trucks;
            }
        }

        private void defectTextBox_Click(object sender, EventArgs e)
        {
            if (defectTextBox.Text.StartsWith("Добавьте неисправности/услуги"))
                defectTextBox.Text = "";
        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {
            if (IsCar)
                truckNames.Enabled = false;
            else
                carsNames.Enabled = false;
        }

        private void AddingNewCar(string carName, string model, string vin, string engineVol, DateTime manYear)
        {
            double engineVolume = 0;
            if (engineVol != "")
                engineVolume = Double.Parse(engineVol, CultureInfo.InvariantCulture);
            if (model != "" && vin != "" && engineVolume != 0)
            {
                Car.Name = CarName(carName);
                Car.Model = model;
                Car.VIN = vin;
                Car.EngineVolume = engineVolume;
                Car.ManufactureYear = manYear;
                Car.DefectsDescription.Add(defectTextBox.Text);

                Cars.Add(Car);
                CarsListBox.DataSource = null;
                CarsListBox.DataSource = Cars;


                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните обязательные поля!");
            }
        }

        private void AddingNewTruck(string name, string model, string vin, string engineVol, DateTime manYear)
        {
            double engineVolume = 0;
            if (engineVol != "")
                engineVolume = Double.Parse(engineVol, CultureInfo.InvariantCulture);
            if (model != "" && vin != "" && engineVolume != 0)
            {
                Truck.Name = TruckName(name);
                Truck.Model = model;
                Truck.VIN = vin;
                Truck.EngineVolume = engineVolume;
                Truck.ManufactureYear = manYear;
                Truck.DefectsDescription.Add(defectTextBox.Text);

                Trucks.Add(Truck);
                TrucksListBox.DataSource = null;
                TrucksListBox.DataSource = Trucks;
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните обязательные поля!");
            }
        }

        private CarNames CarName(string name)
        {
            switch (name)
            {
                case "LADA": return CarNames.LADA;
                case "Audi": return CarNames.Audi;
                case "BMW": return CarNames.BMW;
                case "Mercedes": return CarNames.Mercedes;
                case "Opel": return CarNames.Opel;
                case "Chevrolet": return CarNames.Chevrolet;
                case "Ford": return CarNames.Ford;
                case "Renault": return CarNames.Renault;
                case "Citroen": return CarNames.Citroen;
                case "Hyinday": return CarNames.Hyinday;
                case "Kia": return CarNames.Kia;
                case "Skoda": return CarNames.Skoda;
                case "Volkswagen": return CarNames.Volkswagen;
                case "Volvo": return CarNames.Volvo;
                case "Nissan": return CarNames.Nissan;
                case "Lexus": return CarNames.Lexus;
                case "Mazda": return CarNames.Mazda;
                case "Toyota": return CarNames.Toyota;
                case "Subaru": return CarNames.Subaru;
                case "Honda": return CarNames.Honda;
                case "Mitsubishi": return CarNames.Mitsubishi;
                default: throw new Exception("No such name");
            }
        }

        private TruckNames TruckName(string name)
        {
            switch (name)
            {
                case "Scania": return TruckNames.Scania;
                case "IVECO": return TruckNames.IVECO;
                case "Volvo": return TruckNames.Volvo;
                case "MAN": return TruckNames.MAN;
                case "KaMAZ": return TruckNames.KaMAZ;
                case "MAZ": return TruckNames.MAZ;
                case "DAF": return TruckNames.DAF;
                case "Isuzu": return TruckNames.Isuzu;
                default: throw new Exception("No such name");
            }
        }
    }
}
