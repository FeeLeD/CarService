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
        Cars Car;
        ListBox CarListBox;
        Clients Client;
        public ChangeCarForm(Clients client, Cars car, ListBox carListBox)
        {
            InitializeComponent();
            Client = client;
            Car = car;
            CarListBox = carListBox;
            manufactureDateTimePicker.MaxDate = DateTime.Today;
            manufactureDateTimePicker.Value = Car.ManufactureYear;
        }

        private void changeCar_Click(object sender, EventArgs e)
        {
            var check = false;
            var conditions = new List<bool>
            {
                carModelTextBox.Text != Car.Model && carModelTextBox.Text != "",
                carVin.Text != Car.VIN && vinTextBox.Text != "",
                engineVolume.Text != "" && Double.Parse(engineVolume.Text, CultureInfo.InvariantCulture) != Car.EngineVolume,
                defectTextBox.Text != "",
                manufactureDateTimePicker.Value.Year != Car.ManufactureYear.Year
            };

            if (conditions[0] || conditions[1] || conditions[2] || conditions[3] || conditions[4])
            {
                if (conditions[0])
                {
                    Car.Model = carModelTextBox.Text;
                    check = true;
                }

                if (conditions[1])
                {
                    Car.VIN = vinTextBox.Text;
                    check = true;
                }

                if (conditions[2])
                {
                    Car.EngineVolume = Double.Parse(engineVolume.Text, CultureInfo.InvariantCulture);
                    check = true;
                }

                if (conditions[3])
                {
                    Car.DefectsDescription.Add(defectTextBox.Text);
                    check = true;
                }

                if (conditions[4])
                {
                    Car.ManufactureYear = manufactureDateTimePicker.Value;
                    check = true;
                }

                if (check)
                {
                    CarListBox.DataSource = null;
                    CarListBox.DataSource = Client.Cars;
                    Close();
                }
            }
            else
                MessageBox.Show("Введите изменения!");
        }
    }
}
