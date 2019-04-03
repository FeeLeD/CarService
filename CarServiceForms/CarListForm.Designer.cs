namespace CarServiceForms
{
    partial class CarListForm
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
            this.deleteTruckButton = new System.Windows.Forms.Button();
            this.addTruckButton = new System.Windows.Forms.Button();
            this.deleteCarButton = new System.Windows.Forms.Button();
            this.addCarButton = new System.Windows.Forms.Button();
            this.trucksListBox = new System.Windows.Forms.ListBox();
            this.carsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vechileNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vechileModelTextBox = new System.Windows.Forms.TextBox();
            this.vechileVinTextBox = new System.Windows.Forms.TextBox();
            this.vechileVolumeTextBox = new System.Windows.Forms.TextBox();
            this.vechileManufactedTextBox = new System.Windows.Forms.TextBox();
            this.vechileDefectsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deleteTruckButton
            // 
            this.deleteTruckButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteTruckButton.Enabled = false;
            this.deleteTruckButton.Location = new System.Drawing.Point(360, 49);
            this.deleteTruckButton.Name = "deleteTruckButton";
            this.deleteTruckButton.Size = new System.Drawing.Size(75, 23);
            this.deleteTruckButton.TabIndex = 41;
            this.deleteTruckButton.Text = "Удалить";
            this.deleteTruckButton.UseVisualStyleBackColor = true;
            this.deleteTruckButton.Click += new System.EventHandler(this.deleteTruckButton_Click);
            // 
            // addTruckButton
            // 
            this.addTruckButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTruckButton.Location = new System.Drawing.Point(279, 49);
            this.addTruckButton.Name = "addTruckButton";
            this.addTruckButton.Size = new System.Drawing.Size(75, 23);
            this.addTruckButton.TabIndex = 40;
            this.addTruckButton.Text = "Добавить";
            this.addTruckButton.UseVisualStyleBackColor = true;
            this.addTruckButton.Click += new System.EventHandler(this.addTruckButton_Click);
            // 
            // deleteCarButton
            // 
            this.deleteCarButton.Enabled = false;
            this.deleteCarButton.Location = new System.Drawing.Point(93, 49);
            this.deleteCarButton.Name = "deleteCarButton";
            this.deleteCarButton.Size = new System.Drawing.Size(75, 23);
            this.deleteCarButton.TabIndex = 39;
            this.deleteCarButton.Text = "Удалить";
            this.deleteCarButton.UseVisualStyleBackColor = true;
            this.deleteCarButton.Click += new System.EventHandler(this.deleteCarButton_Click);
            // 
            // addCarButton
            // 
            this.addCarButton.Location = new System.Drawing.Point(12, 49);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(75, 23);
            this.addCarButton.TabIndex = 38;
            this.addCarButton.Text = "Добавить";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // trucksListBox
            // 
            this.trucksListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.trucksListBox.FormattingEnabled = true;
            this.trucksListBox.HorizontalScrollbar = true;
            this.trucksListBox.Location = new System.Drawing.Point(279, 78);
            this.trucksListBox.Name = "trucksListBox";
            this.trucksListBox.Size = new System.Drawing.Size(271, 277);
            this.trucksListBox.TabIndex = 36;
            this.trucksListBox.Click += new System.EventHandler(this.trucksListBox_Click);
            this.trucksListBox.SelectedIndexChanged += new System.EventHandler(this.trucksListBox_SelectedIndexChanged);
            // 
            // carsListBox
            // 
            this.carsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.carsListBox.FormattingEnabled = true;
            this.carsListBox.HorizontalScrollbar = true;
            this.carsListBox.Location = new System.Drawing.Point(12, 78);
            this.carsListBox.Name = "carsListBox";
            this.carsListBox.Size = new System.Drawing.Size(258, 277);
            this.carsListBox.TabIndex = 35;
            this.carsListBox.Click += new System.EventHandler(this.carsListBox_Click);
            this.carsListBox.SelectedIndexChanged += new System.EventHandler(this.carsListBox_SelectedIndexChanged);
            this.carsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.carsListBox_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Список автомобилей клиента";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Список грузовых автомобилей клиента";
            // 
            // vechileNameTextBox
            // 
            this.vechileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vechileNameTextBox.Location = new System.Drawing.Point(567, 78);
            this.vechileNameTextBox.Name = "vechileNameTextBox";
            this.vechileNameTextBox.ReadOnly = true;
            this.vechileNameTextBox.Size = new System.Drawing.Size(205, 20);
            this.vechileNameTextBox.TabIndex = 44;
            this.vechileNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Подробная информация";
            // 
            // vechileModelTextBox
            // 
            this.vechileModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vechileModelTextBox.Location = new System.Drawing.Point(567, 104);
            this.vechileModelTextBox.Name = "vechileModelTextBox";
            this.vechileModelTextBox.ReadOnly = true;
            this.vechileModelTextBox.Size = new System.Drawing.Size(205, 20);
            this.vechileModelTextBox.TabIndex = 46;
            this.vechileModelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vechileVinTextBox
            // 
            this.vechileVinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vechileVinTextBox.Location = new System.Drawing.Point(567, 130);
            this.vechileVinTextBox.Name = "vechileVinTextBox";
            this.vechileVinTextBox.ReadOnly = true;
            this.vechileVinTextBox.Size = new System.Drawing.Size(205, 20);
            this.vechileVinTextBox.TabIndex = 47;
            this.vechileVinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vechileVolumeTextBox
            // 
            this.vechileVolumeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vechileVolumeTextBox.Location = new System.Drawing.Point(567, 156);
            this.vechileVolumeTextBox.Name = "vechileVolumeTextBox";
            this.vechileVolumeTextBox.ReadOnly = true;
            this.vechileVolumeTextBox.Size = new System.Drawing.Size(205, 20);
            this.vechileVolumeTextBox.TabIndex = 48;
            this.vechileVolumeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vechileManufactedTextBox
            // 
            this.vechileManufactedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vechileManufactedTextBox.Location = new System.Drawing.Point(567, 182);
            this.vechileManufactedTextBox.Name = "vechileManufactedTextBox";
            this.vechileManufactedTextBox.ReadOnly = true;
            this.vechileManufactedTextBox.Size = new System.Drawing.Size(205, 20);
            this.vechileManufactedTextBox.TabIndex = 49;
            this.vechileManufactedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vechileDefectsTextBox
            // 
            this.vechileDefectsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.vechileDefectsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vechileDefectsTextBox.Location = new System.Drawing.Point(567, 208);
            this.vechileDefectsTextBox.Multiline = true;
            this.vechileDefectsTextBox.Name = "vechileDefectsTextBox";
            this.vechileDefectsTextBox.ReadOnly = true;
            this.vechileDefectsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.vechileDefectsTextBox.Size = new System.Drawing.Size(205, 147);
            this.vechileDefectsTextBox.TabIndex = 50;
            // 
            // CarListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.vechileDefectsTextBox);
            this.Controls.Add(this.vechileManufactedTextBox);
            this.Controls.Add(this.vechileVolumeTextBox);
            this.Controls.Add(this.vechileVinTextBox);
            this.Controls.Add(this.vechileModelTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vechileNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteTruckButton);
            this.Controls.Add(this.addTruckButton);
            this.Controls.Add(this.deleteCarButton);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.trucksListBox);
            this.Controls.Add(this.carsListBox);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "CarListForm";
            this.ShowIcon = false;
            this.Text = "Добавление автомобилей";
            this.Load += new System.EventHandler(this.CarListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteTruckButton;
        private System.Windows.Forms.Button addTruckButton;
        private System.Windows.Forms.Button deleteCarButton;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.ListBox trucksListBox;
        private System.Windows.Forms.ListBox carsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vechileNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vechileModelTextBox;
        private System.Windows.Forms.TextBox vechileVinTextBox;
        private System.Windows.Forms.TextBox vechileVolumeTextBox;
        private System.Windows.Forms.TextBox vechileManufactedTextBox;
        private System.Windows.Forms.TextBox vechileDefectsTextBox;
    }
}