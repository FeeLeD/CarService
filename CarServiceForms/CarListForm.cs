using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarService;
using CarServiceForms.Properties;

namespace CarServiceForms
{
    public partial class CarListForm : Form
    {
        Clients Client;
        ListBox ClientsListBox;
        ListBox MainCarsListBox;
        ListBox MainTrucksListBox;
        public CarListForm(Clients client, ListBox clientsListBox, ListBox mainCarsListBox, ListBox mainTrucksListBox)
        {
            InitializeComponent();
            Client = client;
            ClientsListBox = clientsListBox;
            MainCarsListBox = mainCarsListBox;
            MainTrucksListBox = mainTrucksListBox;
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            new AddCarForm(MainCarsListBox)
            {
                Cars = Client.Cars,
                CarsListBox = carsListBox,
                IsCar = true
            }.Show();
        }

        private void addTruckButton_Click(object sender, EventArgs e)
        {
            new AddCarForm(MainTrucksListBox)
            {
                Trucks = Client.Trucks,
                TrucksListBox = trucksListBox,
                IsCar = false
            }.Show();
        }

        private void CarListForm_Load(object sender, EventArgs e)
        {
            if (Client.Cars.Count > 0)
            {
                carsListBox.DataSource = Client.Cars;
            }
            if (Client.Trucks.Count > 0)
            {
                trucksListBox.DataSource = Client.Trucks;
            }
        }

        private void deleteCarButton_Click(object sender, EventArgs e)
        {
            if (carsListBox.SelectedItem is Cars)
            {
                Client.Cars.Remove((Cars)carsListBox.SelectedItem);
                carsListBox.DataSource = null;
                carsListBox.DataSource = Client.Cars;
                vechileNameTextBox.Text = "";
                vechileModelTextBox.Text = "";
                vechileVinTextBox.Text = "";
                vechileVolumeTextBox.Text = "";
                vechileManufactedTextBox.Text = "";
                vechileManufactedTextBox.Text = "";
            }

            MainCarsListBox.DataSource = null;
            MainCarsListBox.DataSource = Client.Cars;
        }

        private void deleteTruckButton_Click(object sender, EventArgs e)
        {
            if (trucksListBox.SelectedItem is Trucks)
            {
                Client.Trucks.Remove((Trucks)trucksListBox.SelectedItem);
                trucksListBox.DataSource = null;
                trucksListBox.DataSource = Client.Trucks;
                vechileNameTextBox.Text = "";
                vechileModelTextBox.Text = "";
                vechileVinTextBox.Text = "";
                vechileVolumeTextBox.Text = "";
                vechileManufactedTextBox.Text = "";
                vechileManufactedTextBox.Text = "";
            }

            MainTrucksListBox.DataSource = null;
            MainTrucksListBox.DataSource = Client.Trucks;
        }

        private void carsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteCarButton.Enabled = carsListBox.SelectedItem is Cars;
        }

        private void trucksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteTruckButton.Enabled = trucksListBox.SelectedItem is Trucks;
        }

        private void carsListBox_Click(object sender, EventArgs e)
        {
            var index = carsListBox.SelectedIndex;
            if (index >= 0 && Client.Cars.Count > 0 && carsListBox.GetSelected(index))
            {
                var cars = Client.Cars[index];
                vechileNameTextBox.Text = cars.Name.ToString();
                vechileModelTextBox.Text = cars.Model;
                vechileVinTextBox.Text = cars.VIN;
                vechileVolumeTextBox.Text = cars.EngineVolume.ToString();
                vechileManufactedTextBox.Text = cars.ManufactureYear.Year.ToString();
                vechileDefectsTextBox.Text = "";
                if (cars.DefectsDescription.Count > 0)
                { 
                    foreach (var defect in cars.DefectsDescription)
                        vechileDefectsTextBox.Text += (defect + "; ");
                }
                warning1.Visible = false;
                warning2.Visible = false;
            }
            else
            {
                CleanVechileInfo();
            }
        }

        private void trucksListBox_Click(object sender, EventArgs e)
        {
            var index = trucksListBox.SelectedIndex;
            if (index >= 0 && Client.Trucks.Count > 0 && trucksListBox.GetSelected(index))
            {
                var trucks = Client.Trucks[index];
                vechileNameTextBox.Text = trucks.Name.ToString();
                vechileModelTextBox.Text = trucks.Model;
                vechileVinTextBox.Text = trucks.VIN;
                vechileVolumeTextBox.Text = trucks.EngineVolume.ToString();
                vechileManufactedTextBox.Text = trucks.ManufactureYear.Year.ToString();
                vechileDefectsTextBox.Text = "";
                if (trucks.DefectsDescription.Count > 0)
                {
                    foreach (var defect in trucks.DefectsDescription)
                        vechileDefectsTextBox.Text += (defect + "; ");
                }
                warning1.Visible = false;
                warning2.Visible = false;
            }
            else
            {
                CleanVechileInfo();
            }
        }

        private void CleanVechileInfo()
        {
            vechileNameTextBox.Text = "";
            vechileModelTextBox.Text = "";
            vechileVinTextBox.Text = "";
            vechileVolumeTextBox.Text = "";
            vechileManufactedTextBox.Text = "";
            vechileDefectsTextBox.Text = "";
        }

        private void carsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.carsListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                var item = (Cars)carsListBox.Items[index];
                var ccf = new ChangeCarForm(Client, carsListBox, null, item)
                {
                    Warning1 = warning1,
                    Warning2 = warning2
                };
                ccf.Show();
            }
        }

        private void trucksListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.trucksListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                var item = (Trucks)trucksListBox.Items[index];
                var ccf = new ChangeCarForm(Client, null, trucksListBox, null, item)
                {
                    Warning1 = warning1,
                    Warning2 = warning2
                };
                ccf.Show();
            }
        }
    }
}
