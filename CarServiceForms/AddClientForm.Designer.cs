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
            this.addClientButton = new System.Windows.Forms.Button();
            this.addNewClient = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addClient
            // 
            this.addClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addClient.Location = new System.Drawing.Point(205, 426);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(125, 23);
            this.addClient.TabIndex = 17;
            this.addClient.Text = "Добавить";
            this.addClient.UseVisualStyleBackColor = true;
            // 
            // clientPageTitle
            // 
            this.clientPageTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clientPageTitle.AutoSize = true;
            this.clientPageTitle.Location = new System.Drawing.Point(167, 22);
            this.clientPageTitle.Name = "clientPageTitle";
            this.clientPageTitle.Size = new System.Drawing.Size(152, 13);
            this.clientPageTitle.TabIndex = 16;
            this.clientPageTitle.Text = "Добавление нового клиента";
            this.clientPageTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addClientButton
            // 
            this.addClientButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addClientButton.Location = new System.Drawing.Point(131, 326);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(227, 23);
            this.addClientButton.TabIndex = 26;
            this.addClientButton.Text = "Добавить клиента";
            this.addClientButton.UseVisualStyleBackColor = true;
            // 
            // addNewClient
            // 
            this.addNewClient.Location = new System.Drawing.Point(140, 198);
            this.addNewClient.Name = "addNewClient";
            this.addNewClient.Size = new System.Drawing.Size(212, 23);
            this.addNewClient.TabIndex = 34;
            this.addNewClient.Text = "Добавить клиента";
            this.addNewClient.UseVisualStyleBackColor = true;
            this.addNewClient.Click += new System.EventHandler(this.addNewClient_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Location = new System.Drawing.Point(109, 127);
            this.dateTimePicker.MaxDate = new System.DateTime(2019, 4, 3, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(363, 20);
            this.dateTimePicker.TabIndex = 33;
            this.dateTimePicker.Value = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.Location = new System.Drawing.Point(109, 93);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(363, 20);
            this.phoneTextBox.TabIndex = 32;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(28, 133);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(75, 13);
            this.dateLabel.TabIndex = 31;
            this.dateLabel.Text = "Дата заказа:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(7, 96);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(96, 13);
            this.phoneLabel.TabIndex = 30;
            this.phoneLabel.Text = "Номер телефона:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(109, 58);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(363, 20);
            this.nameTextBox.TabIndex = 29;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(66, 61);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(37, 13);
            this.nameLabel.TabIndex = 28;
            this.nameLabel.Text = "ФИО:";
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.addNewClient);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.clientPageTitle);
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
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
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button addNewClient;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
    }
}