﻿using System;
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
    public partial class Form1 : Form
    {
        ClientBase clientBase = new ClientBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void newClient_Click(object sender, EventArgs e)
        {
            new AddClientForm(clientBase, clientList).Show();
        }
    }
}