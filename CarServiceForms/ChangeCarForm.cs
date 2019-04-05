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
    public partial class ChangeCarForm : Form
    {
        Cars Car = null;
        Trucks Truck = null;
        ListBox CarListBox;
        ListBox TruckListBox;
        Clients Client;
        
        private Vechiles Vechile;

        public Label Warning1;
        public Label Warning2;

        public ChangeCarForm(Clients client, ListBox carListBox = null, ListBox truckListBox = null, Cars car = null, Trucks truck = null)
        {
            InitializeComponent();
            Client = client;

            if (car != null)
            {
                Car = car;
                CarListBox = carListBox;
            }
            else
            {
                Truck = truck;
                TruckListBox = truckListBox;
            }

            if (Car != null)
                Vechile = Car;
            else
                Vechile = Truck;

            manufactureDateTimePicker.MaxDate = DateTime.Today;

            carModelTextBox.Text = Vechile.Model;
            vinTextBox.Text = Vechile.VIN;
            engineVolume.Text = Vechile.EngineVolume.ToString();
            manufactureDateTimePicker.Value = Vechile.ManufactureYear;
        }

        private bool specialChecker = false;

        private void changeCar_Click(object sender, EventArgs e)
        {
            var check = false;

            var conditions = new List<bool>
            {
                carModelTextBox.Text != Vechile.Model && carModelTextBox.Text != "",
                vinTextBox.Text != Vechile.VIN && vinTextBox.Text != "",
                engineVolume.Text != "" && ParseToDouble(engineVolume.Text) != Vechile.EngineVolume,
                defectTextBox.Text != "",
                manufactureDateTimePicker.Value.Year != Vechile.ManufactureYear.Year
            };

            if (conditions[0] || conditions[1] || conditions[2] || conditions[3] || conditions[4])
            {
                if (conditions[0])
                {
                    Vechile.Model = carModelTextBox.Text;
                    check = true;
                }

                if (conditions[1])
                {
                    Vechile.VIN = vinTextBox.Text;
                    check = true;
                }

                if (conditions[2])
                {
                    Vechile.EngineVolume = ParseToDouble(engineVolume.Text);
                    check = true;
                }

                if (conditions[3])
                {
                    Vechile.DefectsDescription.Add(defectTextBox.Text);
                    check = true;
                }

                if (conditions[4])
                {
                    Vechile.ManufactureYear = manufactureDateTimePicker.Value;
                    check = true;
                }

                if (check)
                {
                    if (Car != null)
                    {
                        CarListBox.DataSource = null;
                        CarListBox.DataSource = Client.Cars;
                        Close();
                    }
                    else
                    {
                        TruckListBox.DataSource = null;
                        TruckListBox.DataSource = Client.Trucks;
                        Close();
                    }
                    Warning1.Visible = true;
                    Warning2.Visible = true;
                }
            }
            else
            {
                if (!specialChecker)
                    MessageBox.Show("Введите изменения!");
            }
        }

        private double ParseToDouble(string date)
        {
            if (date.Contains("."))
                date = date.Replace(".", ",");
            try
            {
                return Double.Parse(date);
            }
            catch
            {
                this.Close();
                specialChecker = true;
                MessageBox.Show("Неверный формат ввода объёма двигателя!");
                return Vechile.EngineVolume;
            }
        }

        private void defectTextBox_Click(object sender, EventArgs e)
        {
            textToChange.Visible = false;
        }
    }
}
