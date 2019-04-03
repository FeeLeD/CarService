namespace CarServiceForms
{
    partial class AddCarForm
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
            this.carsNames = new System.Windows.Forms.ComboBox();
            this.carName = new System.Windows.Forms.Label();
            this.carVin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vinTextBox = new System.Windows.Forms.TextBox();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.carModel = new System.Windows.Forms.Label();
            this.engineVolume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.engineVolumeLabel = new System.Windows.Forms.Label();
            this.manufactureDate = new System.Windows.Forms.Label();
            this.manufactureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addCar = new System.Windows.Forms.Button();
            this.truckName = new System.Windows.Forms.Label();
            this.truckNames = new System.Windows.Forms.ComboBox();
            this.defectTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carsNames
            // 
            this.carsNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carsNames.FormattingEnabled = true;
            this.carsNames.Items.AddRange(new object[] {
            "LADA",
            "Audi",
            "BMW",
            "Mercedes",
            "Opel",
            "Chevrolet",
            "Ford",
            "Renault",
            "Citroen",
            "Hyinday",
            "Kia",
            "Skoda",
            "Volkswagen",
            "Volvo",
            "Nissan",
            "Lexus",
            "Mazda",
            "Toyota",
            "Subaru",
            "Honda",
            "Mitsubishi"});
            this.carsNames.Location = new System.Drawing.Point(151, 34);
            this.carsNames.Name = "carsNames";
            this.carsNames.Size = new System.Drawing.Size(307, 21);
            this.carsNames.TabIndex = 0;
            // 
            // carName
            // 
            this.carName.AutoSize = true;
            this.carName.Location = new System.Drawing.Point(8, 37);
            this.carName.Name = "carName";
            this.carName.Size = new System.Drawing.Size(128, 13);
            this.carName.TabIndex = 1;
            this.carName.Text = "Название автомобиля*:";
            // 
            // carVin
            // 
            this.carVin.AutoSize = true;
            this.carVin.Location = new System.Drawing.Point(69, 164);
            this.carVin.Name = "carVin";
            this.carVin.Size = new System.Drawing.Size(67, 13);
            this.carVin.TabIndex = 2;
            this.carVin.Text = "VIN номер*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // vinTextBox
            // 
            this.vinTextBox.Location = new System.Drawing.Point(151, 161);
            this.vinTextBox.Name = "vinTextBox";
            this.vinTextBox.Size = new System.Drawing.Size(307, 20);
            this.vinTextBox.TabIndex = 4;
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Location = new System.Drawing.Point(151, 118);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(307, 20);
            this.carModelTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // carModel
            // 
            this.carModel.AutoSize = true;
            this.carModel.Location = new System.Drawing.Point(83, 121);
            this.carModel.Name = "carModel";
            this.carModel.Size = new System.Drawing.Size(53, 13);
            this.carModel.TabIndex = 5;
            this.carModel.Text = "Модель*:";
            // 
            // engineVolume
            // 
            this.engineVolume.Location = new System.Drawing.Point(151, 208);
            this.engineVolume.Name = "engineVolume";
            this.engineVolume.Size = new System.Drawing.Size(307, 20);
            this.engineVolume.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // engineVolumeLabel
            // 
            this.engineVolumeLabel.AutoSize = true;
            this.engineVolumeLabel.Location = new System.Drawing.Point(32, 211);
            this.engineVolumeLabel.Name = "engineVolumeLabel";
            this.engineVolumeLabel.Size = new System.Drawing.Size(104, 13);
            this.engineVolumeLabel.TabIndex = 8;
            this.engineVolumeLabel.Text = "Объём двигателя*:";
            // 
            // manufactureDate
            // 
            this.manufactureDate.AutoSize = true;
            this.manufactureDate.Location = new System.Drawing.Point(62, 260);
            this.manufactureDate.Name = "manufactureDate";
            this.manufactureDate.Size = new System.Drawing.Size(74, 13);
            this.manufactureDate.TabIndex = 11;
            this.manufactureDate.Text = "Год выпуска:";
            // 
            // manufactureDateTimePicker
            // 
            this.manufactureDateTimePicker.CustomFormat = "yyyy";
            this.manufactureDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.manufactureDateTimePicker.Location = new System.Drawing.Point(151, 254);
            this.manufactureDateTimePicker.MaxDate = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            this.manufactureDateTimePicker.Name = "manufactureDateTimePicker";
            this.manufactureDateTimePicker.Size = new System.Drawing.Size(307, 20);
            this.manufactureDateTimePicker.TabIndex = 12;
            this.manufactureDateTimePicker.Value = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            // 
            // addCar
            // 
            this.addCar.Location = new System.Drawing.Point(166, 583);
            this.addCar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.addCar.Name = "addCar";
            this.addCar.Size = new System.Drawing.Size(137, 23);
            this.addCar.TabIndex = 13;
            this.addCar.Text = "Добавить автомобиль";
            this.addCar.UseVisualStyleBackColor = true;
            this.addCar.Click += new System.EventHandler(this.addCar_Click);
            // 
            // truckName
            // 
            this.truckName.AutoSize = true;
            this.truckName.Location = new System.Drawing.Point(21, 81);
            this.truckName.Name = "truckName";
            this.truckName.Size = new System.Drawing.Size(115, 13);
            this.truckName.TabIndex = 15;
            this.truckName.Text = "Название грузовика:";
            // 
            // truckNames
            // 
            this.truckNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.truckNames.FormattingEnabled = true;
            this.truckNames.Items.AddRange(new object[] {
            "Scania",
            "IVECO",
            "Volvo",
            "MAN",
            "KaMAZ",
            "MAZ",
            "DAF",
            "Isuzu"});
            this.truckNames.Location = new System.Drawing.Point(151, 78);
            this.truckNames.Name = "truckNames";
            this.truckNames.Size = new System.Drawing.Size(307, 21);
            this.truckNames.TabIndex = 14;
            // 
            // defectTextBox
            // 
            this.defectTextBox.Location = new System.Drawing.Point(24, 294);
            this.defectTextBox.Multiline = true;
            this.defectTextBox.Name = "defectTextBox";
            this.defectTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.defectTextBox.Size = new System.Drawing.Size(434, 274);
            this.defectTextBox.TabIndex = 18;
            this.defectTextBox.Text = "Добавьте неисправности/услуги";
            this.defectTextBox.Click += new System.EventHandler(this.defectTextBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 610);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 19;
            // 
            // AddCarForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(484, 621);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.defectTextBox);
            this.Controls.Add(this.truckName);
            this.Controls.Add(this.truckNames);
            this.Controls.Add(this.addCar);
            this.Controls.Add(this.manufactureDateTimePicker);
            this.Controls.Add(this.manufactureDate);
            this.Controls.Add(this.engineVolume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.engineVolumeLabel);
            this.Controls.Add(this.carModelTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.vinTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carVin);
            this.Controls.Add(this.carName);
            this.Controls.Add(this.carsNames);
            this.MaximumSize = new System.Drawing.Size(500, 660);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "AddCarForm";
            this.ShowIcon = false;
            this.Text = "Добавить автомобиль";
            this.Load += new System.EventHandler(this.AddCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox carsNames;
        private System.Windows.Forms.Label carName;
        private System.Windows.Forms.Label carVin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vinTextBox;
        private System.Windows.Forms.TextBox carModelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label carModel;
        private System.Windows.Forms.TextBox engineVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label engineVolumeLabel;
        private System.Windows.Forms.Label manufactureDate;
        private System.Windows.Forms.Button addCar;
        private System.Windows.Forms.Label truckName;
        private System.Windows.Forms.ComboBox truckNames;
        private System.Windows.Forms.TextBox defectTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker manufactureDateTimePicker;
    }
}