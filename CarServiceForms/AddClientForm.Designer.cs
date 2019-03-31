namespace CarServiceForms
{
    partial class AddClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addClient = new System.Windows.Forms.Button();
            this.clientPageTitle = new System.Windows.Forms.Label();
            this.orderTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.orderDate = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addClient
            // 
            this.addClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addClient.Location = new System.Drawing.Point(178, 196);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(75, 23);
            this.addClient.TabIndex = 17;
            this.addClient.Text = "Добавить";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // clientPageTitle
            // 
            this.clientPageTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clientPageTitle.AutoSize = true;
            this.clientPageTitle.Location = new System.Drawing.Point(142, 22);
            this.clientPageTitle.Name = "clientPageTitle";
            this.clientPageTitle.Size = new System.Drawing.Size(152, 13);
            this.clientPageTitle.TabIndex = 16;
            this.clientPageTitle.Text = "Добавление нового клиента";
            this.clientPageTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // orderTimePicker
            // 
            this.orderTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderTimePicker.Location = new System.Drawing.Point(112, 120);
            this.orderTimePicker.MaxDate = new System.DateTime(2019, 3, 31, 0, 0, 0, 0);
            this.orderTimePicker.Name = "orderTimePicker";
            this.orderTimePicker.Size = new System.Drawing.Size(310, 20);
            this.orderTimePicker.TabIndex = 15;
            this.orderTimePicker.Value = new System.DateTime(2019, 3, 31, 0, 0, 0, 0);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.Location = new System.Drawing.Point(112, 86);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(310, 20);
            this.textBoxPhone.TabIndex = 14;
            // 
            // orderDate
            // 
            this.orderDate.AutoSize = true;
            this.orderDate.Location = new System.Drawing.Point(29, 126);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(75, 13);
            this.orderDate.TabIndex = 13;
            this.orderDate.Text = "Дата заказа:";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Location = new System.Drawing.Point(8, 89);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(96, 13);
            this.phoneNumber.TabIndex = 12;
            this.phoneNumber.Text = "Номер телефона:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(112, 51);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(310, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(67, 54);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(37, 13);
            this.name.TabIndex = 10;
            this.name.Text = "ФИО:";
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.clientPageTitle);
            this.Controls.Add(this.orderTimePicker);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.name);
            this.Name = "AddClientForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление нового клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Label clientPageTitle;
        private System.Windows.Forms.DateTimePicker orderTimePicker;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label orderDate;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label name;
    }
}