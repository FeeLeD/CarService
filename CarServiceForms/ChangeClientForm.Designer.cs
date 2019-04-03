namespace CarServiceForms
{
    partial class ChangeClientForm
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
            this.changeClient = new System.Windows.Forms.Button();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.clientPageTitle = new System.Windows.Forms.Label();
            this.orderCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // changeClient
            // 
            this.changeClient.Location = new System.Drawing.Point(140, 198);
            this.changeClient.Name = "changeClient";
            this.changeClient.Size = new System.Drawing.Size(212, 23);
            this.changeClient.TabIndex = 42;
            this.changeClient.Text = "Изменить данные";
            this.changeClient.UseVisualStyleBackColor = true;
            this.changeClient.Click += new System.EventHandler(this.changeClient_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.Location = new System.Drawing.Point(109, 93);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(363, 20);
            this.phoneTextBox.TabIndex = 40;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(20, 133);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(83, 13);
            this.dateLabel.TabIndex = 39;
            this.dateLabel.Text = "Статус заказа:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(7, 96);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(96, 13);
            this.phoneLabel.TabIndex = 38;
            this.phoneLabel.Text = "Номер телефона:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(109, 58);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(363, 20);
            this.nameTextBox.TabIndex = 37;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(66, 61);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(37, 13);
            this.nameLabel.TabIndex = 36;
            this.nameLabel.Text = "ФИО:";
            // 
            // clientPageTitle
            // 
            this.clientPageTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clientPageTitle.AutoSize = true;
            this.clientPageTitle.Location = new System.Drawing.Point(167, 22);
            this.clientPageTitle.Name = "clientPageTitle";
            this.clientPageTitle.Size = new System.Drawing.Size(152, 13);
            this.clientPageTitle.TabIndex = 35;
            this.clientPageTitle.Text = "Добавление нового клиента";
            this.clientPageTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // orderCheckBox
            // 
            this.orderCheckBox.AutoSize = true;
            this.orderCheckBox.Location = new System.Drawing.Point(109, 132);
            this.orderCheckBox.Name = "orderCheckBox";
            this.orderCheckBox.Size = new System.Drawing.Size(77, 17);
            this.orderCheckBox.TabIndex = 43;
            this.orderCheckBox.Text = "Выполнен";
            this.orderCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChangeClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.orderCheckBox);
            this.Controls.Add(this.changeClient);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.clientPageTitle);
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "ChangeClientForm";
            this.ShowIcon = false;
            this.Text = "Изменить данные клиента";
            this.Load += new System.EventHandler(this.ChangeClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeClient;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label clientPageTitle;
        private System.Windows.Forms.CheckBox orderCheckBox;
    }
}