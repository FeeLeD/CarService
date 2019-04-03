namespace CarServiceForms
{
    partial class ChangeCarForm
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
            this.defectTextBox = new System.Windows.Forms.TextBox();
            this.changeCar = new System.Windows.Forms.Button();
            this.manufactureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.manufactureDate = new System.Windows.Forms.Label();
            this.engineVolume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.engineVolumeLabel = new System.Windows.Forms.Label();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.carModel = new System.Windows.Forms.Label();
            this.vinTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.carVin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // defectTextBox
            // 
            this.defectTextBox.Location = new System.Drawing.Point(15, 231);
            this.defectTextBox.Multiline = true;
            this.defectTextBox.Name = "defectTextBox";
            this.defectTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.defectTextBox.Size = new System.Drawing.Size(434, 274);
            this.defectTextBox.TabIndex = 35;
            // 
            // changeCar
            // 
            this.changeCar.Location = new System.Drawing.Point(166, 523);
            this.changeCar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.changeCar.Name = "changeCar";
            this.changeCar.Size = new System.Drawing.Size(137, 23);
            this.changeCar.TabIndex = 32;
            this.changeCar.Text = "Внести изменения";
            this.changeCar.UseVisualStyleBackColor = true;
            this.changeCar.Click += new System.EventHandler(this.changeCar_Click);
            // 
            // manufactureDateTimePicker
            // 
            this.manufactureDateTimePicker.CustomFormat = "yyyy";
            this.manufactureDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.manufactureDateTimePicker.Location = new System.Drawing.Point(142, 178);
            this.manufactureDateTimePicker.MaxDate = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            this.manufactureDateTimePicker.Name = "manufactureDateTimePicker";
            this.manufactureDateTimePicker.Size = new System.Drawing.Size(307, 20);
            this.manufactureDateTimePicker.TabIndex = 31;
            this.manufactureDateTimePicker.Value = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            // 
            // manufactureDate
            // 
            this.manufactureDate.AutoSize = true;
            this.manufactureDate.Location = new System.Drawing.Point(53, 184);
            this.manufactureDate.Name = "manufactureDate";
            this.manufactureDate.Size = new System.Drawing.Size(74, 13);
            this.manufactureDate.TabIndex = 30;
            this.manufactureDate.Text = "Год выпуска:";
            // 
            // engineVolume
            // 
            this.engineVolume.Location = new System.Drawing.Point(142, 132);
            this.engineVolume.Name = "engineVolume";
            this.engineVolume.Size = new System.Drawing.Size(307, 20);
            this.engineVolume.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 28;
            // 
            // engineVolumeLabel
            // 
            this.engineVolumeLabel.AutoSize = true;
            this.engineVolumeLabel.Location = new System.Drawing.Point(23, 135);
            this.engineVolumeLabel.Name = "engineVolumeLabel";
            this.engineVolumeLabel.Size = new System.Drawing.Size(104, 13);
            this.engineVolumeLabel.TabIndex = 27;
            this.engineVolumeLabel.Text = "Объём двигателя*:";
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Location = new System.Drawing.Point(142, 42);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(307, 20);
            this.carModelTextBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 25;
            // 
            // carModel
            // 
            this.carModel.AutoSize = true;
            this.carModel.Location = new System.Drawing.Point(74, 45);
            this.carModel.Name = "carModel";
            this.carModel.Size = new System.Drawing.Size(53, 13);
            this.carModel.TabIndex = 24;
            this.carModel.Text = "Модель*:";
            // 
            // vinTextBox
            // 
            this.vinTextBox.Location = new System.Drawing.Point(142, 85);
            this.vinTextBox.Name = "vinTextBox";
            this.vinTextBox.Size = new System.Drawing.Size(307, 20);
            this.vinTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 22;
            // 
            // carVin
            // 
            this.carVin.AutoSize = true;
            this.carVin.Location = new System.Drawing.Point(60, 88);
            this.carVin.Name = "carVin";
            this.carVin.Size = new System.Drawing.Size(67, 13);
            this.carVin.TabIndex = 21;
            this.carVin.Text = "VIN номер*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 546);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 36;
            // 
            // ChangeCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.defectTextBox);
            this.Controls.Add(this.changeCar);
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
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ChangeCarForm";
            this.ShowIcon = false;
            this.Text = "Изменение данных автомобиля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox defectTextBox;
        private System.Windows.Forms.Button changeCar;
        private System.Windows.Forms.DateTimePicker manufactureDateTimePicker;
        private System.Windows.Forms.Label manufactureDate;
        private System.Windows.Forms.TextBox engineVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label engineVolumeLabel;
        private System.Windows.Forms.TextBox carModelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label carModel;
        private System.Windows.Forms.TextBox vinTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label carVin;
        private System.Windows.Forms.Label label4;
    }
}