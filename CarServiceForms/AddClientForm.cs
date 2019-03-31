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
        public ListBox Clients;
        public AddClientForm(ClientBase clientBase, ListBox clients)
        {
            ClientBase = clientBase;
            Clients = clients;
            InitializeComponent();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            var phoneNumber = new PhoneNumber(textBoxPhone.Text);
            var orderDate = orderTimePicker.Value;

            if (name != "" && phoneNumber != null)
            {
                var client = new Clients()
                {
                    Name = name,
                    Number = phoneNumber,
                    OrderDate = orderDate
                };
                ClientBase.List.Add(client);
                MessageBox.Show("Клиент добавлен!");

                Clients.Items.Add(client);

                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }

        }
    }
}
