namespace CarServiceForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.client = new System.Windows.Forms.TabPage();
            this.clientBasePage = new System.Windows.Forms.TabPage();
            this.changeClient = new System.Windows.Forms.Button();
            this.deleteClient = new System.Windows.Forms.Button();
            this.newClient = new System.Windows.Forms.Button();
            this.clientListBox = new System.Windows.Forms.ListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderDateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trucksListBox = new System.Windows.Forms.ListBox();
            this.carsListBox = new System.Windows.Forms.ListBox();
            this.vNameTextBox = new System.Windows.Forms.TextBox();
            this.vModelTextBox = new System.Windows.Forms.TextBox();
            this.vVolumeTextBox = new System.Windows.Forms.TextBox();
            this.vVinTextBox = new System.Windows.Forms.TextBox();
            this.vDateTextBox = new System.Windows.Forms.TextBox();
            this.defectsTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.базаКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.инструкцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warning1 = new System.Windows.Forms.Label();
            this.warning2 = new System.Windows.Forms.Label();
            this.warning3 = new System.Windows.Forms.Label();
            this.client.SuspendLayout();
            this.clientBasePage.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // client
            // 
            this.client.Controls.Add(this.defectsTextBox);
            this.client.Controls.Add(this.vDateTextBox);
            this.client.Controls.Add(this.vVolumeTextBox);
            this.client.Controls.Add(this.vVinTextBox);
            this.client.Controls.Add(this.vModelTextBox);
            this.client.Controls.Add(this.vNameTextBox);
            this.client.Controls.Add(this.trucksListBox);
            this.client.Controls.Add(this.carsListBox);
            this.client.Controls.Add(this.statusTextBox);
            this.client.Controls.Add(this.label4);
            this.client.Controls.Add(this.orderDateTextBox);
            this.client.Controls.Add(this.label3);
            this.client.Controls.Add(this.phoneNumberTextBox);
            this.client.Controls.Add(this.label2);
            this.client.Controls.Add(this.nameTextBox);
            this.client.Controls.Add(this.label1);
            this.client.Location = new System.Drawing.Point(4, 22);
            this.client.Name = "client";
            this.client.Padding = new System.Windows.Forms.Padding(3);
            this.client.Size = new System.Drawing.Size(676, 398);
            this.client.TabIndex = 1;
            this.client.Text = "Клиент";
            this.client.UseVisualStyleBackColor = true;
            // 
            // clientBasePage
            // 
            this.clientBasePage.Controls.Add(this.warning3);
            this.clientBasePage.Controls.Add(this.warning2);
            this.clientBasePage.Controls.Add(this.warning1);
            this.clientBasePage.Controls.Add(this.changeClient);
            this.clientBasePage.Controls.Add(this.deleteClient);
            this.clientBasePage.Controls.Add(this.newClient);
            this.clientBasePage.Controls.Add(this.clientListBox);
            this.clientBasePage.Location = new System.Drawing.Point(4, 22);
            this.clientBasePage.Name = "clientBasePage";
            this.clientBasePage.Padding = new System.Windows.Forms.Padding(3);
            this.clientBasePage.Size = new System.Drawing.Size(676, 398);
            this.clientBasePage.TabIndex = 0;
            this.clientBasePage.Text = "Клиентская база";
            this.clientBasePage.UseVisualStyleBackColor = true;
            // 
            // changeClient
            // 
            this.changeClient.Location = new System.Drawing.Point(179, 25);
            this.changeClient.Name = "changeClient";
            this.changeClient.Size = new System.Drawing.Size(75, 23);
            this.changeClient.TabIndex = 5;
            this.changeClient.Text = "Изменить";
            this.changeClient.UseVisualStyleBackColor = true;
            this.changeClient.Click += new System.EventHandler(this.changeClient_Click);
            // 
            // deleteClient
            // 
            this.deleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteClient.Location = new System.Drawing.Point(293, 25);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(120, 23);
            this.deleteClient.TabIndex = 4;
            this.deleteClient.Text = "Удалить клиента";
            this.deleteClient.UseVisualStyleBackColor = true;
            this.deleteClient.Click += new System.EventHandler(this.deleteClient_Click);
            // 
            // newClient
            // 
            this.newClient.Location = new System.Drawing.Point(18, 25);
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(120, 23);
            this.newClient.TabIndex = 3;
            this.newClient.Text = "Новый клиент";
            this.newClient.UseVisualStyleBackColor = true;
            this.newClient.Click += new System.EventHandler(this.newClient_Click);
            // 
            // clientListBox
            // 
            this.clientListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientListBox.FormattingEnabled = true;
            this.clientListBox.HorizontalScrollbar = true;
            this.clientListBox.Location = new System.Drawing.Point(8, 68);
            this.clientListBox.Name = "clientListBox";
            this.clientListBox.ScrollAlwaysVisible = true;
            this.clientListBox.Size = new System.Drawing.Size(660, 316);
            this.clientListBox.TabIndex = 0;
            this.clientListBox.Click += new System.EventHandler(this.clientList_Click);
            this.clientListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.clientList_MouseDoubleClick);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl.Controls.Add(this.clientBasePage);
            this.tabControl.Controls.Add(this.client);
            this.tabControl.Location = new System.Drawing.Point(0, 37);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(684, 424);
            this.tabControl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(124, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(543, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(124, 49);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.ReadOnly = true;
            this.phoneNumberTextBox.Size = new System.Drawing.Size(543, 20);
            this.phoneNumberTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер телефона:";
            // 
            // orderDateTextBox
            // 
            this.orderDateTextBox.Location = new System.Drawing.Point(124, 80);
            this.orderDateTextBox.Name = "orderDateTextBox";
            this.orderDateTextBox.ReadOnly = true;
            this.orderDateTextBox.Size = new System.Drawing.Size(543, 20);
            this.orderDateTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата заказа:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.statusTextBox.ForeColor = System.Drawing.Color.Black;
            this.statusTextBox.Location = new System.Drawing.Point(124, 111);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(543, 20);
            this.statusTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Статус заказа:";
            // 
            // trucksListBox
            // 
            this.trucksListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.trucksListBox.FormattingEnabled = true;
            this.trucksListBox.HorizontalScrollbar = true;
            this.trucksListBox.Location = new System.Drawing.Point(223, 150);
            this.trucksListBox.Name = "trucksListBox";
            this.trucksListBox.Size = new System.Drawing.Size(215, 238);
            this.trucksListBox.TabIndex = 38;
            this.trucksListBox.Click += new System.EventHandler(this.trucksListBox_Click);
            // 
            // carsListBox
            // 
            this.carsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.carsListBox.FormattingEnabled = true;
            this.carsListBox.HorizontalScrollbar = true;
            this.carsListBox.Location = new System.Drawing.Point(11, 150);
            this.carsListBox.Name = "carsListBox";
            this.carsListBox.Size = new System.Drawing.Size(206, 238);
            this.carsListBox.TabIndex = 37;
            this.carsListBox.Click += new System.EventHandler(this.carsListBox_Click);
            // 
            // vNameTextBox
            // 
            this.vNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.vNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.vNameTextBox.Location = new System.Drawing.Point(444, 152);
            this.vNameTextBox.Name = "vNameTextBox";
            this.vNameTextBox.ReadOnly = true;
            this.vNameTextBox.Size = new System.Drawing.Size(223, 20);
            this.vNameTextBox.TabIndex = 39;
            this.vNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vModelTextBox
            // 
            this.vModelTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.vModelTextBox.ForeColor = System.Drawing.Color.Black;
            this.vModelTextBox.Location = new System.Drawing.Point(444, 178);
            this.vModelTextBox.Name = "vModelTextBox";
            this.vModelTextBox.ReadOnly = true;
            this.vModelTextBox.Size = new System.Drawing.Size(223, 20);
            this.vModelTextBox.TabIndex = 40;
            this.vModelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vVolumeTextBox
            // 
            this.vVolumeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.vVolumeTextBox.ForeColor = System.Drawing.Color.Black;
            this.vVolumeTextBox.Location = new System.Drawing.Point(444, 230);
            this.vVolumeTextBox.Name = "vVolumeTextBox";
            this.vVolumeTextBox.ReadOnly = true;
            this.vVolumeTextBox.Size = new System.Drawing.Size(223, 20);
            this.vVolumeTextBox.TabIndex = 42;
            this.vVolumeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vVinTextBox
            // 
            this.vVinTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.vVinTextBox.ForeColor = System.Drawing.Color.Black;
            this.vVinTextBox.Location = new System.Drawing.Point(444, 204);
            this.vVinTextBox.Name = "vVinTextBox";
            this.vVinTextBox.ReadOnly = true;
            this.vVinTextBox.Size = new System.Drawing.Size(223, 20);
            this.vVinTextBox.TabIndex = 41;
            this.vVinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vDateTextBox
            // 
            this.vDateTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.vDateTextBox.ForeColor = System.Drawing.Color.Black;
            this.vDateTextBox.Location = new System.Drawing.Point(444, 256);
            this.vDateTextBox.Name = "vDateTextBox";
            this.vDateTextBox.ReadOnly = true;
            this.vDateTextBox.Size = new System.Drawing.Size(223, 20);
            this.vDateTextBox.TabIndex = 43;
            this.vDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // defectsTextBox
            // 
            this.defectsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.defectsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.defectsTextBox.ForeColor = System.Drawing.Color.Black;
            this.defectsTextBox.Location = new System.Drawing.Point(444, 281);
            this.defectsTextBox.Multiline = true;
            this.defectsTextBox.Name = "defectsTextBox";
            this.defectsTextBox.ReadOnly = true;
            this.defectsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.defectsTextBox.Size = new System.Drawing.Size(223, 106);
            this.defectsTextBox.TabIndex = 44;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаКлиентовToolStripMenuItem,
            this.инструкцияToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // базаКлиентовToolStripMenuItem
            // 
            this.базаКлиентовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem1});
            this.базаКлиентовToolStripMenuItem.Name = "базаКлиентовToolStripMenuItem";
            this.базаКлиентовToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.базаКлиентовToolStripMenuItem.Text = "База клиентов";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.загрузитьToolStripMenuItem.Text = "Сохранить";
            // 
            // загрузитьToolStripMenuItem1
            // 
            this.загрузитьToolStripMenuItem1.Name = "загрузитьToolStripMenuItem1";
            this.загрузитьToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.загрузитьToolStripMenuItem1.Text = "Загрузить";
            // 
            // инструкцияToolStripMenuItem
            // 
            this.инструкцияToolStripMenuItem.Name = "инструкцияToolStripMenuItem";
            this.инструкцияToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.инструкцияToolStripMenuItem.Text = "Инструкция";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // warning1
            // 
            this.warning1.AutoSize = true;
            this.warning1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.warning1.Location = new System.Drawing.Point(491, 12);
            this.warning1.Name = "warning1";
            this.warning1.Size = new System.Drawing.Size(114, 13);
            this.warning1.TabIndex = 6;
            this.warning1.Text = "Внесены изменения!";
            this.warning1.Visible = false;
            // 
            // warning2
            // 
            this.warning2.AutoSize = true;
            this.warning2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.warning2.Location = new System.Drawing.Point(439, 27);
            this.warning2.Name = "warning2";
            this.warning2.Size = new System.Drawing.Size(212, 13);
            this.warning2.TabIndex = 7;
            this.warning2.Text = "Для обновления информации в разделе";
            this.warning2.Visible = false;
            // 
            // warning3
            // 
            this.warning3.AutoSize = true;
            this.warning3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.warning3.Location = new System.Drawing.Point(441, 42);
            this.warning3.Name = "warning3";
            this.warning3.Size = new System.Drawing.Size(209, 13);
            this.warning3.TabIndex = 8;
            this.warning3.Text = "\"Клиент\" щёлкните по списку клиентов";
            this.warning3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автосервис";
            this.client.ResumeLayout(false);
            this.client.PerformLayout();
            this.clientBasePage.ResumeLayout(false);
            this.clientBasePage.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage client;
        private System.Windows.Forms.TabPage clientBasePage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Button newClient;
        private System.Windows.Forms.ListBox clientListBox;
        private System.Windows.Forms.Button changeClient;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderDateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox trucksListBox;
        private System.Windows.Forms.ListBox carsListBox;
        private System.Windows.Forms.TextBox defectsTextBox;
        private System.Windows.Forms.TextBox vDateTextBox;
        private System.Windows.Forms.TextBox vVolumeTextBox;
        private System.Windows.Forms.TextBox vVinTextBox;
        private System.Windows.Forms.TextBox vModelTextBox;
        private System.Windows.Forms.TextBox vNameTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem базаКлиентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem инструкцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label warning3;
        private System.Windows.Forms.Label warning2;
        private System.Windows.Forms.Label warning1;
    }
}

