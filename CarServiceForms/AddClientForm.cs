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

namespace CarServiceForms
{
    public partial class AddClientForm : Form
    {
        public ClientBase ClientBase;
        public Clients Client;
        public ListBox ClientsListBox;
        public AddClientForm(ClientBase clientBase, ListBox clientsListBox)
        {
            ClientBase = clientBase;
            ClientsListBox = clientsListBox;
            Client = new Clients();
            InitializeComponent();
            dateTimePicker.MaxDate = DateTime.Today;
            dateTimePicker.Value = DateTime.Today;
        }

        private void addNewClient_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var phoneNumber = new PhoneNumber()
            {
                Number = phoneTextBox.Text
            };
            var orderDate = dateTimePicker.Value;

            var conditions = new List<bool>()
            {
                name != "",
                phoneNumber.ToString() != "",
                phoneNumber.ToString().Count() == 11,
                TryParse(phoneNumber.ToString())
            };

            if (conditions[0] && conditions[1] && conditions[2] && conditions[3])
            {
                Client.Name = name;
                Client.Number = phoneNumber;
                Client.OrderDate = orderDate;

                ClientBase.List.Add(Client);

                ClientsListBox.DataSource = null;
                ClientsListBox.DataSource = ClientBase.List;
                this.Close();
            }
            else
            {
                if (!conditions[2] || !conditions[3])
                    MessageBox.Show("Введите корректный номер телефона");
                else
                    MessageBox.Show("Заполните обязательные поля!");
            }
        }
        private bool TryParse(string number)
        {
            try
            {
                Double.Parse(number);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
