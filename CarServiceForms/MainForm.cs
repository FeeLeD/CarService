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
using System.IO;


namespace CarServiceForms
{
    public partial class MainForm : Form
    {
        ClientBase ClientBase = new ClientBase();
        public MainForm()
        {
            InitializeComponent();
            //TestAdding();
            clientListBox.DataSource = ClientBase.List;
        }

        private void newClient_Click(object sender, EventArgs e)
        {
            new AddClientForm(ClientBase, clientListBox).Show();
        }

        private void clientList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int index = this.clientListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                var item = (Clients)clientListBox.Items[index];
                var clf = new CarListForm(item, clientListBox, carsListBox, trucksListBox);
                clf.Show();
            }
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {
            if (clientListBox.SelectedItem is Clients)
            {
                ClientBase.List.Remove((Clients)clientListBox.SelectedItem);
                clientListBox.DataSource = null;
                clientListBox.DataSource = ClientBase.List;
                CleanFields();
            }
        }

        private void clientList_Click(object sender, EventArgs e)
        {
            var index = clientListBox.SelectedIndex;
            if (index >= 0 && ClientBase.List.Count > 0 && clientListBox.GetSelected(index))
            {
                var client = ClientBase.List[index];
                nameTextBox.Text = client.Name;
                phoneNumberTextBox.Text = client.Number.ToString();
                orderDateTextBox.Text = client.OrderDate.Day.ToString() + "." +
                    client.OrderDate.Month.ToString() + "." + client.OrderDate.Year.ToString();
                if (client.OrderDone)
                {
                    statusTextBox.ForeColor = Color.Green;
                    statusTextBox.Text = "Выполнен";
                }
                else
                {
                    statusTextBox.ForeColor = Color.Red;
                    statusTextBox.Text = "Не выполнен";
                }

                warning1.Visible = false;
                warning2.Visible = false;
                warning3.Visible = false;

                carsListBox.DataSource = null;
                carsListBox.DataSource = client.Cars;

                trucksListBox.DataSource = null;
                trucksListBox.DataSource = client.Trucks;
            }

            CleanVechileInfo();
        }

        private void clientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = clientListBox.SelectedIndex;
            if (index >= 0 && ClientBase.List.Count > 0 && clientListBox.GetSelected(index))
            {
                deleteClient.Enabled = true;
                changeClient.Enabled = true;
            }
            else
            {
                deleteClient.Enabled = false;
                changeClient.Enabled = false;
            }
        }

        private void carsListBox_Click(object sender, EventArgs e)
        {
            var carIndex = carsListBox.SelectedIndex;
            var clientIndex = clientListBox.SelectedIndex;
            if (carIndex >= 0 && clientIndex >= 0 && ClientBase.List.Count > 0 &&
                ClientBase.List[clientIndex].Cars.Count > 0 && carsListBox.GetSelected(carIndex))
            {
                var cars = ClientBase.List[clientIndex].Cars[carIndex];
                vNameTextBox.Text = cars.Name.ToString();
                vModelTextBox.Text = cars.Model;
                vVinTextBox.Text = cars.VIN;
                vVolumeTextBox.Text = cars.EngineVolume.ToString();
                vDateTextBox.Text = cars.ManufactureYear.Year.ToString();
                defectsTextBox.Text = "";
                foreach (var defect in cars.DefectsDescription)
                    defectsTextBox.Text += defect;
            }
            else
            {
                CleanVechileInfo();
            }
        }

        private void trucksListBox_Click(object sender, EventArgs e)
        {
            var truckIndex = trucksListBox.SelectedIndex;
            var clientIndex = clientListBox.SelectedIndex;
            if (truckIndex >= 0 && clientIndex >= 0 && ClientBase.List.Count > 0 &&
                ClientBase.List[clientIndex].Trucks.Count > 0 && trucksListBox.GetSelected(truckIndex))
            {
                var trucks = ClientBase.List[clientIndex].Trucks[truckIndex];
                vNameTextBox.Text = trucks.Name.ToString();
                vModelTextBox.Text = trucks.Model;
                vVinTextBox.Text = trucks.VIN;
                vVolumeTextBox.Text = trucks.EngineVolume.ToString();
                vDateTextBox.Text = trucks.ManufactureYear.Year.ToString();
                defectsTextBox.Text = "";
                foreach (var defect in trucks.DefectsDescription)
                    defectsTextBox.Text += defect;
            }
            else
            {
                CleanVechileInfo();
            }
        }

        private void changeClient_Click(object sender, EventArgs e)
        {
            var index = clientListBox.SelectedIndex;
            if (clientListBox.SelectedItem is Clients && index >= 0)
            {
                new ChangeClientForm(warning1, warning2, warning3)
                {
                    Client = ClientBase.List[index],
                    ClientBase = ClientBase,
                    MainListBox = clientListBox
                }.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Добавление клиента
        //private void TestAdding()
        //{
        //    var c = new Clients()
        //    {
        //        Name = "Александр Дмитриевич Попов",
        //        Number = new PhoneNumber("8 912 354 26 83"),
        //        OrderDate = DateTime.Today
        //    };
        //    ClientBase.List.Add(c);
        //    ClientBase.List.Find(e => e.Name == "Александр Дмитриевич Попов").Cars.Add(new Cars
        //    {
        //        Name = CarNames.Mercedes,
        //        Model = "S-class",
        //        VIN = "SANYA99VPORYADKE234",
        //        EngineVolume = 2.5,
        //        ManufactureYear = DateTime.Today
        //    });
        //}

        private void CleanFields()
        {
            nameTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            orderDateTextBox.Text = "";
            statusTextBox.Text = "";
            carsListBox.DataSource = null;
            trucksListBox.DataSource = null;
            vNameTextBox.Text = "";
            vModelTextBox.Text = "";
            vVinTextBox.Text = "";
            vVolumeTextBox.Text = "";
            vDateTextBox.Text = "";
            defectsTextBox.Text = "";
        }

        private void CleanVechileInfo()
        {
            vNameTextBox.Text = "";
            vModelTextBox.Text = "";
            vVinTextBox.Text = "";
            vVolumeTextBox.Text = "";
            vDateTextBox.Text = "";
            defectsTextBox.Text = "";
        }

        private void Instruction_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(File.ReadAllText("instruction.txt", Encoding.Default));
            }
            catch (FileNotFoundException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
