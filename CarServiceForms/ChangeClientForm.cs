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
    public partial class ChangeClientForm : Form
    {
        public Clients Client;
        public ClientBase ClientBase;
        public ListBox MainListBox;

        Label W1;
        Label W2;
        Label W3;

        public ChangeClientForm(Label w1, Label w2, Label w3)
        {
            InitializeComponent();
            W1 = w1;
            W2 = w2;
            W3 = w3;
        }

        private void changeClient_Click(object sender, EventArgs e)
        {
            var check = false;
            var conditions = new List<bool>
            {
                nameTextBox.Text != Client.Name && nameTextBox.Text != "",
                new PhoneNumber(phoneTextBox.Text) != Client.Number && phoneTextBox.Text != "",
                orderCheckBox.Checked != Client.OrderDone
            };

            if (conditions[0] || conditions[1] || conditions[2])
            {
                if (conditions[0])
                {
                    Client.Name = nameTextBox.Text;
                    check = true;
                }

                if (conditions[1])
                {
                    if (new PhoneNumber(phoneTextBox.Text).ToString().Length != 11)
                        MessageBox.Show("Введите корректный номер телефона!");
                    else
                    {
                        Client.Number = new PhoneNumber(phoneTextBox.Text);
                        check = true;
                    }
                }

                if (conditions[2])
                {
                    Client.OrderDone = !Client.OrderDone;
                    check = true;
                }

                if (check)
                {
                    MainListBox.DataSource = null;
                    MainListBox.DataSource = ClientBase.List;
                    W1.Visible = true;
                    W2.Visible = true;
                    W3.Visible = true;
                    Close();
                }
            }
            else
                MessageBox.Show("Введите изменения!");
        }

        private void ChangeClientForm_Load(object sender, EventArgs e)
        {
            if (Client.OrderDone)
                orderCheckBox.CheckState = CheckState.Checked;
        }
    }
}
